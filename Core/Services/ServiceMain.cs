using Core.Core.Entities;
using Newtonsoft.Json;
using Odoo.Concrete;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Core.Services
{
    public class ServiceMain : DbContext
    {
        public ServiceMain()
        {
            
        }

        public string RpcContextToJson(IEnumerable<RpcRecord> requests)
        {
            var jsonResault = "";
            var jsonObjs = "";
            foreach (var request in requests.Select(s => s.GetFields()))
            {
                var jsonObj = "";
                foreach (var field in request)
                {
                    if ((field.Type.Contains("one2many") || field.Type.Contains("many2one")) && field.Value is IEnumerable enumerable)
                    {
                        var vals = new List<int>();
                        foreach (var item in enumerable)
                        {
                            if (item.GetType().Name.Contains("Int32")) { vals.Add(int.Parse(item.ToString())); }
                        }
                        jsonObj += @$"""{field.FieldName.Replace("_", "")}"":""{String.Join(",", vals)}"",";
                    }
                    else if (!field.Type.Contains("many2many"))
                    {
                        jsonObj += @$"""{field.FieldName.Replace("_", "")}"":""{(field.Value==null?"":field.Value.ToString().Replace(@"""",""))}"",";

                    }

                }
                jsonObjs += $@"{{{jsonObj.TrimEnd(',')}}},";
            }

            return jsonResault = $"[{jsonObjs.TrimEnd(',')}]";

        }
        public async Task<List<T>> GetList<T>(RpcConnection conn) where T : class
        {
            List<T> listObjects = new List<T>();

            var types = Assembly.GetExecutingAssembly().GetTypes();

            foreach (Type type in types)
            {
                if (typeof(T).IsAssignableFrom(type) && !type.IsAbstract)
                {
                    var requests = new RpcContext(conn, ConvertToLowerCaseWithDots(type.Name)).Execute(true);
                    var jsonResault = RpcContextToJson(requests);
                    listObjects = JsonConvert.DeserializeObject<List<T>>(jsonResault);
                }
            }
            return listObjects;
        }
        public string ConvertToLowerCaseWithDots(string input)
        {
            StringBuilder result = new StringBuilder();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]))
                {
                    if (i > 0)
                    {
                        result.Append('.');
                    }
                    result.Append(char.ToLower(input[i]));
                }
                else
                {
                    result.Append(input[i]);
                }
            }
            return result.ToString();
        }
        public async Task<List<T>> GetAllWithRelated<T>(RpcConnection conn) where T : class
        {
            var entities = await GetList<T>(conn);

            foreach (var entity in entities)
            {
                LoadRelatedEntities(entity);
            }

            return entities;
        }
        private void LoadRelatedEntities<T>(T entity) where T : class
        {
            var navigationProperties = GetNavigationProperties<T>();

            foreach (var property in navigationProperties)
            {
                // Check if it's a navigation property
                if (property.PropertyType.IsClass && !property.PropertyType.IsArray)
                {
                    var relatedEntity = property.GetValue(entity);
                    if (relatedEntity != null)
                    {
                        var idProperty = relatedEntity.GetType().GetProperty("Id");
                        if (idProperty != null)
                        {
                            var idValue = idProperty.GetValue(relatedEntity);
                            if (idValue != null && idValue is int)
                            {
                                // Load the related entity dynamically
                                var relatedEntityType = property.PropertyType;
                                var genericSetMethod = GetType().GetMethod("Set").MakeGenericMethod(relatedEntityType);
                                var relatedEntityWithId = genericSetMethod.Invoke(this, null)
                                    .GetType().GetMethod("Find").Invoke(genericSetMethod.Invoke(this, null), new object[] { idValue });

                                if (relatedEntityWithId != null)
                                {
                                    property.SetValue(entity, relatedEntityWithId);
                                }
                            }
                        }
                    }
                }
                else if (property.PropertyType.IsGenericType &&
                         property.PropertyType.GetInterfaces().Any(
                             i => i.IsGenericType &&
                                  i.GetGenericTypeDefinition() == typeof(IEnumerable<>)))
                {
                    // It's a collection (List, ICollection, etc.)
                    // You may need to adjust this part based on your actual use case
                    var collection = property.GetValue(entity) as IEnumerable<object>;
                    if (collection != null)
                    {
                        foreach (var item in collection)
                        {
                            LoadRelatedEntities(item);
                        }
                    }
                }
            }
        }
        private IEnumerable<System.Reflection.PropertyInfo> GetNavigationProperties<T>()
        {
            return typeof(T).GetProperties()
                .Where(property =>
                    (property.PropertyType.IsGenericType
                    && property.PropertyType.GetGenericTypeDefinition() == typeof(ICollection<>))
                    ||
                    (property.PropertyType.IsClass
                    && property.PropertyType.Name != "String")
                    );
        }
        // check field value is an array or not, if not it return theoriginal value
        public object GetFieldArrayValue(RpcRecord record, string fieldName)
        {
            var fieldValue = record.GetField(fieldName).Value;

            if (fieldValue is object[] arrayValue && arrayValue.Length > 0)
            {
                return arrayValue[0];
            }

            return fieldValue;
        }

    }
}
