using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Fields
/// </summary>
public partial class IrModelField
{
    public int Id { get; set; }

    /// <summary>
    /// Relation field
    /// </summary>
    public int? RelationFieldId { get; set; }

    /// <summary>
    /// Model
    /// </summary>
    public int ModelId { get; set; }

    /// <summary>
    /// Related field
    /// </summary>
    public int? RelatedFieldId { get; set; }

    /// <summary>
    /// Size
    /// </summary>
    public int? Size { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Field Name
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Complete Name
    /// </summary>
    public string? CompleteName { get; set; }

    /// <summary>
    /// Model Name
    /// </summary>
    public string Model { get; set; } = null!;

    /// <summary>
    /// Related Model
    /// </summary>
    public string? Relation { get; set; }

    /// <summary>
    /// Relation Field
    /// </summary>
    public string? RelationField { get; set; }

    /// <summary>
    /// Field Type
    /// </summary>
    public string Ttype { get; set; } = null!;

    /// <summary>
    /// Related Field
    /// </summary>
    public string? Related { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string State { get; set; } = null!;

    /// <summary>
    /// On Delete
    /// </summary>
    public string? OnDelete { get; set; }

    /// <summary>
    /// Domain
    /// </summary>
    public string? Domain { get; set; }

    /// <summary>
    /// Relation Table
    /// </summary>
    public string? RelationTable { get; set; }

    /// <summary>
    /// Column 1
    /// </summary>
    public string? Column1 { get; set; }

    /// <summary>
    /// Column 2
    /// </summary>
    public string? Column2 { get; set; }

    /// <summary>
    /// Dependencies
    /// </summary>
    public string? Depends { get; set; }

    /// <summary>
    /// Field Label
    /// </summary>
    public string FieldDescription { get; set; } = null!;

    /// <summary>
    /// Field Help
    /// </summary>
    public string? Help { get; set; }

    /// <summary>
    /// Compute
    /// </summary>
    public string? Compute { get; set; }

    /// <summary>
    /// Copied
    /// </summary>
    public bool? Copied { get; set; }

    /// <summary>
    /// Required
    /// </summary>
    public bool? Required { get; set; }

    /// <summary>
    /// Readonly
    /// </summary>
    public bool? Readonly { get; set; }

    /// <summary>
    /// Indexed
    /// </summary>
    public bool? Index { get; set; }

    /// <summary>
    /// Translatable
    /// </summary>
    public bool? Translate { get; set; }

    /// <summary>
    /// Expand Groups
    /// </summary>
    public bool? GroupExpand { get; set; }

    /// <summary>
    /// Selectable
    /// </summary>
    public bool? Selectable { get; set; }

    /// <summary>
    /// Stored
    /// </summary>
    public bool? Store { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Enable Ordered Tracking
    /// </summary>
    public int? Tracking { get; set; }

    /// <summary>
    /// Blacklisted in web forms
    /// </summary>
    public bool? WebsiteFormBlacklisted { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<CrmLeadScoringFrequencyField> CrmLeadScoringFrequencyFields { get; set; } = new List<CrmLeadScoringFrequencyField>();

    public virtual ICollection<DataRecycleModel> DataRecycleModels { get; set; } = new List<DataRecycleModel>();

    public virtual ICollection<GamificationGoalDefinition> GamificationGoalDefinitionBatchDistinctiveFieldNavigations { get; set; } = new List<GamificationGoalDefinition>();

    public virtual ICollection<GamificationGoalDefinition> GamificationGoalDefinitionFieldDates { get; set; } = new List<GamificationGoalDefinition>();

    public virtual ICollection<GamificationGoalDefinition> GamificationGoalDefinitionFields { get; set; } = new List<GamificationGoalDefinition>();

    public virtual ICollection<IrModelField> InverseRelatedField { get; set; } = new List<IrModelField>();

    public virtual ICollection<IrModelField> InverseRelationFieldNavigation { get; set; } = new List<IrModelField>();

    public virtual ICollection<IrActServer> IrActServers { get; set; } = new List<IrActServer>();

    public virtual ICollection<IrDefault> IrDefaults { get; set; } = new List<IrDefault>();

    public virtual ICollection<IrModelFieldsSelection> IrModelFieldsSelections { get; set; } = new List<IrModelFieldsSelection>();

    public virtual ICollection<IrModel> IrModels { get; set; } = new List<IrModel>();

    public virtual ICollection<IrProperty> IrProperties { get; set; } = new List<IrProperty>();

    public virtual ICollection<IrServerObjectLine> IrServerObjectLines { get; set; } = new List<IrServerObjectLine>();

    public virtual ICollection<MailTrackingValue> MailTrackingValues { get; set; } = new List<MailTrackingValue>();

    public virtual IrModel ModelNavigation { get; set; } = null!;

    public virtual IrModelField? RelatedField { get; set; }

    public virtual IrModelField? RelationFieldNavigation { get; set; }

    public virtual ICollection<WebsiteSaleExtraField> WebsiteSaleExtraFields { get; set; } = new List<WebsiteSaleExtraField>();

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ResGroup> Groups { get; set; } = new List<ResGroup>();
}
