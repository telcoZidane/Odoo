using Core.Core.Utility.EnumOdoo;
using Odoo.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Core.Core.Utility.EnumOdoo.EnumOdoo;

namespace Core.Services
{
    public class ServiceOdoo
    {
        public async Task Get(RpcConnection conn, EnumsOdoo employee)
        {

        }
        
        public async Task Delete(RpcConnection conn, EnumsOdoo employee, int Id)
        {
            var request = new RpcContext(conn, employee.Value());
            request.RpcFilter.Equal("id", Id);
            var result = request.Execute(true).FirstOrDefault();
            var model = new RpcModel(employee.Value(), conn);
            model.Remove(result);
        }
        // delete Departure reason
        public async Task DeleteModel(RpcConnection conn, EnumsOdoo model, int Id)
        {
            var request = new RpcContext(conn, model.Value());//making request with "EnumsOdoo" that contains all tables
            request.RpcFilter.Equal("id", Id);//filter by Id to get one object to be deleted
            var result = request.Execute(true).FirstOrDefault();//executing the request
            var rcpModel = new RpcModel(model.Value(), conn);//making Rpcmodel here as same as request object type
            rcpModel.Remove(result);//executing the deleted operation
        }
    }
}
