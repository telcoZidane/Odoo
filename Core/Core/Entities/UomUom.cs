using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Product Unit of Measure
/// </summary>
public partial class UomUom
{
    public int Id { get; set; }

    /// <summary>
    /// Category
    /// </summary>
    public int CategoryId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Type
    /// </summary>
    public string UomType { get; set; } = null!;

    /// <summary>
    /// Unit of Measure
    /// </summary>
    public string Name { get; set; } = null!;

    /// <summary>
    /// Ratio
    /// </summary>
    public decimal Factor { get; set; }

    /// <summary>
    /// Rounding Precision
    /// </summary>
    public decimal Rounding { get; set; }

    /// <summary>
    /// Active
    /// </summary>
    public bool? Active { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public virtual ICollection<AccountAnalyticLine> AccountAnalyticLines { get; set; } = new List<AccountAnalyticLine>();

    public virtual ICollection<AccountMoveLine> AccountMoveLines { get; set; } = new List<AccountMoveLine>();

    public virtual ICollection<BarcodeRule> BarcodeRules { get; set; } = new List<BarcodeRule>();

    public virtual UomCategory Category { get; set; } = null!;

    public virtual ResUser? CreateU { get; set; }

    public virtual ICollection<HrExpense> HrExpenses { get; set; } = new List<HrExpense>();

    public virtual ICollection<MrpBomByproduct> MrpBomByproducts { get; set; } = new List<MrpBomByproduct>();

    public virtual ICollection<MrpBomLine> MrpBomLines { get; set; } = new List<MrpBomLine>();

    public virtual ICollection<MrpBom> MrpBoms { get; set; } = new List<MrpBom>();

    public virtual ICollection<MrpProduction> MrpProductions { get; set; } = new List<MrpProduction>();

    public virtual ICollection<MrpUnbuild> MrpUnbuilds { get; set; } = new List<MrpUnbuild>();

    public virtual ICollection<MrpWorkorder> MrpWorkorders { get; set; } = new List<MrpWorkorder>();

    public virtual ICollection<ProductReplenish> ProductReplenishes { get; set; } = new List<ProductReplenish>();

    public virtual ICollection<ProductTemplate> ProductTemplateUomPos { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<ProductTemplate> ProductTemplateUoms { get; set; } = new List<ProductTemplate>();

    public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; set; } = new List<PurchaseOrderLine>();

    public virtual ICollection<RepairFee> RepairFees { get; set; } = new List<RepairFee>();

    public virtual ICollection<RepairLine> RepairLines { get; set; } = new List<RepairLine>();

    public virtual ICollection<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();

    public virtual ICollection<SaleOrderLine> SaleOrderLines { get; set; } = new List<SaleOrderLine>();

    public virtual ICollection<SaleOrderOption> SaleOrderOptions { get; set; } = new List<SaleOrderOption>();

    public virtual ICollection<SaleOrderTemplateLine> SaleOrderTemplateLines { get; set; } = new List<SaleOrderTemplateLine>();

    public virtual ICollection<SaleOrderTemplateOption> SaleOrderTemplateOptions { get; set; } = new List<SaleOrderTemplateOption>();

    public virtual ICollection<StockLot> StockLots { get; set; } = new List<StockLot>();

    public virtual ICollection<StockMoveLine> StockMoveLines { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockScrap> StockScraps { get; set; } = new List<StockScrap>();

    public virtual ResUser? WriteU { get; set; }
}
