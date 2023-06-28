using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("ast_asset_component")]
public partial class AstAssetComponent
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("asset_id", TypeName = "decimal(18, 0)")]
    public decimal? AssetId { get; set; }

    [Column("location_id", TypeName = "decimal(18, 0)")]
    public decimal? LocationId { get; set; }

    [Column("description")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Description { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("pur_date", TypeName = "datetime")]
    public DateTime? PurDate { get; set; }

    [Column("pur_doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PurDocNo { get; set; }

    [Column("vendor_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? VendorName { get; set; }

    [Column("model")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Model { get; set; }

    [Column("serial_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SerialNo { get; set; }

    [Column("made_year", TypeName = "decimal(18, 0)")]
    public decimal? MadeYear { get; set; }

    [Column("color")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Color { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("other_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Other1 { get; set; }

    [Column("other_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Other2 { get; set; }

    [Column("other_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Other3 { get; set; }

    [Column("other_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Other4 { get; set; }

    [Column("other_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Other5 { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("company_insurance_id", TypeName = "decimal(18, 0)")]
    public decimal? CompanyInsuranceId { get; set; }

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("ins_amount", TypeName = "decimal(18, 3)")]
    public decimal? InsAmount { get; set; }

    [Column("min_qty", TypeName = "decimal(18, 3)")]
    public decimal? MinQty { get; set; }
}
