using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("shf_report")]
public partial class ShfReport
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

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("item_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item1 { get; set; }

    [Column("no_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? No1 { get; set; }

    [Column("sign_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Sign1 { get; set; }

    [Column("count_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Count1 { get; set; }

    [Column("type_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Type1 { get; set; }

    [Column("shad_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Shad1 { get; set; }

    [Column("unit_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Unit1 { get; set; }

    [Column("source_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Source1 { get; set; }

    [Column("item_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item2 { get; set; }

    [Column("no_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? No2 { get; set; }

    [Column("sign_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Sign2 { get; set; }

    [Column("count_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Count2 { get; set; }

    [Column("type_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Type2 { get; set; }

    [Column("shad_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Shad2 { get; set; }

    [Column("unit_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Unit2 { get; set; }

    [Column("source_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Source2 { get; set; }

    [Column("item_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item3 { get; set; }

    [Column("no_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? No3 { get; set; }

    [Column("sign_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Sign3 { get; set; }

    [Column("count_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Count3 { get; set; }

    [Column("type_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Type3 { get; set; }

    [Column("shad_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Shad3 { get; set; }

    [Column("unit_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Unit3 { get; set; }

    [Column("source_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Source3 { get; set; }

    [Column("item_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item4 { get; set; }

    [Column("no_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? No4 { get; set; }

    [Column("sign_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Sign4 { get; set; }

    [Column("count_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Count4 { get; set; }

    [Column("type_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Type4 { get; set; }

    [Column("shad_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Shad4 { get; set; }

    [Column("unit_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Unit4 { get; set; }

    [Column("source_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Source4 { get; set; }

    [Column("item_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Item5 { get; set; }

    [Column("no_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? No5 { get; set; }

    [Column("sign_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Sign5 { get; set; }

    [Column("count_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Count5 { get; set; }

    [Column("type_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Type5 { get; set; }

    [Column("shad_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Shad5 { get; set; }

    [Column("unit_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Unit5 { get; set; }

    [Column("source_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Source5 { get; set; }

    [Column("file_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FileNo { get; set; }

    [Column("incom_dep")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IncomDep { get; set; }

    [Column("import_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ImportName { get; set; }

    [Column("import_address")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ImportAddress { get; set; }

    [Column("office_tel")]
    [StringLength(15)]
    [Unicode(false)]
    public string? OfficeTel { get; set; }

    [Column("whs")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Whs { get; set; }

    [Column("invoice_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InvoiceNo { get; set; }

    [Column("invoice_date", TypeName = "datetime")]
    public DateTime? InvoiceDate { get; set; }

    [Column("total_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? TotalNo { get; set; }

    [Column("contact")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Contact { get; set; }

    [Column("contact_tel")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ContactTel { get; set; }

    [Column("contact_id")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ContactId { get; set; }

    [Column("waith_all", TypeName = "decimal(18, 0)")]
    public decimal? WaithAll { get; set; }

    [Column("waith_net", TypeName = "decimal(18, 0)")]
    public decimal? WaithNet { get; set; }

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
}
