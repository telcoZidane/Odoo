using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Transfer
/// </summary>
public partial class StockPicking
{
    public int Id { get; set; }

    /// <summary>
    /// Main Attachment
    /// </summary>
    public int? MessageMainAttachmentId { get; set; }

    /// <summary>
    /// Back Order of
    /// </summary>
    public int? BackorderId { get; set; }

    /// <summary>
    /// Procurement Group
    /// </summary>
    public int? GroupId { get; set; }

    /// <summary>
    /// Source Location
    /// </summary>
    public int LocationId { get; set; }

    /// <summary>
    /// Destination Location
    /// </summary>
    public int LocationDestId { get; set; }

    /// <summary>
    /// Operation Type
    /// </summary>
    public int PickingTypeId { get; set; }

    /// <summary>
    /// Contact
    /// </summary>
    public int? PartnerId { get; set; }

    /// <summary>
    /// Company
    /// </summary>
    public int? CompanyId { get; set; }

    /// <summary>
    /// Responsible
    /// </summary>
    public int? UserId { get; set; }

    /// <summary>
    /// Assign Owner
    /// </summary>
    public int? OwnerId { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Reference
    /// </summary>
    public string? Name { get; set; }

    /// <summary>
    /// Source Document
    /// </summary>
    public string? Origin { get; set; }

    /// <summary>
    /// Shipping Policy
    /// </summary>
    public string MoveType { get; set; } = null!;

    /// <summary>
    /// Status
    /// </summary>
    public string? State { get; set; }

    /// <summary>
    /// Priority
    /// </summary>
    public string? Priority { get; set; }

    /// <summary>
    /// Notes
    /// </summary>
    public string? Note { get; set; }

    /// <summary>
    /// Is late
    /// </summary>
    public bool? HasDeadlineIssue { get; set; }

    /// <summary>
    /// Printed
    /// </summary>
    public bool? Printed { get; set; }

    /// <summary>
    /// Is Locked
    /// </summary>
    public bool? IsLocked { get; set; }

    /// <summary>
    /// Immediate Transfer
    /// </summary>
    public bool? ImmediateTransfer { get; set; }

    /// <summary>
    /// Scheduled Date
    /// </summary>
    public DateTime? ScheduledDate { get; set; }

    /// <summary>
    /// Deadline
    /// </summary>
    public DateTime? DateDeadline { get; set; }

    /// <summary>
    /// Creation Date
    /// </summary>
    public DateTime? Date { get; set; }

    /// <summary>
    /// Date of Transfer
    /// </summary>
    public DateTime? DateDone { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    public int? SaleId { get; set; }

    /// <summary>
    /// Pos Session
    /// </summary>
    public int? PosSessionId { get; set; }

    /// <summary>
    /// Pos Order
    /// </summary>
    public int? PosOrderId { get; set; }

    /// <summary>
    /// Website
    /// </summary>
    public int? WebsiteId { get; set; }

    public virtual StockPicking? Backorder { get; set; }

    public virtual ResCompany? Company { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual ProcurementGroup? Group { get; set; }

    public virtual ICollection<StockPicking> InverseBackorder { get; set; } = new List<StockPicking>();

    public virtual StockLocation Location { get; set; } = null!;

    public virtual StockLocation LocationDest { get; set; } = null!;

    public virtual IrAttachment? MessageMainAttachment { get; set; }

    public virtual ResPartner? Owner { get; set; }

    public virtual ResPartner? Partner { get; set; }

    public virtual StockPickingType PickingType { get; set; } = null!;

    public virtual PosOrder? PosOrder { get; set; }

    public virtual PosSession? PosSession { get; set; }

    public virtual ICollection<RepairOrder> RepairOrders { get; set; } = new List<RepairOrder>();

    public virtual SaleOrder? Sale { get; set; }

    public virtual ICollection<StockBackorderConfirmationLine> StockBackorderConfirmationLines { get; set; } = new List<StockBackorderConfirmationLine>();

    public virtual ICollection<StockImmediateTransferLine> StockImmediateTransferLines { get; set; } = new List<StockImmediateTransferLine>();

    public virtual ICollection<StockMoveLine> StockMoveLines { get; set; } = new List<StockMoveLine>();

    public virtual ICollection<StockMove> StockMoves { get; set; } = new List<StockMove>();

    public virtual ICollection<StockPackageDestination> StockPackageDestinations { get; set; } = new List<StockPackageDestination>();

    public virtual ICollection<StockPackageLevel> StockPackageLevels { get; set; } = new List<StockPackageLevel>();

    public virtual ICollection<StockReturnPicking> StockReturnPickings { get; set; } = new List<StockReturnPicking>();

    public virtual ICollection<StockScrap> StockScraps { get; set; } = new List<StockScrap>();

    public virtual ResUser? User { get; set; }

    public virtual Website? Website { get; set; }

    public virtual ResUser? WriteU { get; set; }

    public virtual ICollection<ConfirmStockSm> ConfirmStockSms { get; set; } = new List<ConfirmStockSm>();

    public virtual ICollection<LotLabelLayout> LotLabelLayouts { get; set; } = new List<LotLabelLayout>();

    public virtual ICollection<PickingLabelType> PickingLabelTypes { get; set; } = new List<PickingLabelType>();

    public virtual ICollection<PurchaseOrder> PurchaseOrders { get; set; } = new List<PurchaseOrder>();

    public virtual ICollection<StockBackorderConfirmation> StockBackorderConfirmations { get; set; } = new List<StockBackorderConfirmation>();

    public virtual ICollection<StockImmediateTransfer> StockImmediateTransfers { get; set; } = new List<StockImmediateTransfer>();
}
