using System;
using System.Collections.Generic;

namespace Core.Core.Entities;

/// <summary>
/// Web Editor Converter Test
/// </summary>
public partial class WebEditorConverterTest
{
    public int Id { get; set; }

    /// <summary>
    /// Integer
    /// </summary>
    public int? Integer { get; set; }

    /// <summary>
    /// Many2One
    /// </summary>
    public int? Many2one { get; set; }

    /// <summary>
    /// Created by
    /// </summary>
    public int? CreateUid { get; set; }

    /// <summary>
    /// Last Updated by
    /// </summary>
    public int? WriteUid { get; set; }

    /// <summary>
    /// Char
    /// </summary>
    public string? Char { get; set; }

    /// <summary>
    /// Lorsqu&apos;un pancake prend l&apos;avion à destination de Toronto et qu&apos;il fait une escale technique à St Claude, on dit:
    /// </summary>
    public string? SelectionStr { get; set; }

    /// <summary>
    /// Date
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// Html
    /// </summary>
    public string? Html { get; set; }

    /// <summary>
    /// Text
    /// </summary>
    public string? Text { get; set; }

    /// <summary>
    /// Numeric
    /// </summary>
    public decimal? Numeric { get; set; }

    /// <summary>
    /// Datetime
    /// </summary>
    public DateTime? Datetime { get; set; }

    /// <summary>
    /// Created on
    /// </summary>
    public DateTime? CreateDate { get; set; }

    /// <summary>
    /// Last Updated on
    /// </summary>
    public DateTime? WriteDate { get; set; }

    /// <summary>
    /// Float
    /// </summary>
    public double? Float { get; set; }

    /// <summary>
    /// Binary
    /// </summary>
    public byte[]? Binary { get; set; }

    public virtual ResUser? CreateU { get; set; }

    public virtual WebEditorConverterTestSub? Many2oneNavigation { get; set; }

    public virtual ResUser? WriteU { get; set; }
}
