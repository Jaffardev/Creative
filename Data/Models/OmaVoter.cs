using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("oma_voters")]
public partial class OmaVoter
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("area_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? AreaNo { get; set; }

    [Column("area_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? AreaName { get; set; }

    [Column("table_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? TableNo { get; set; }

    [Column("table_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? TableName { get; set; }

    [Column("table_type")]
    [StringLength(200)]
    [Unicode(false)]
    public string? TableType { get; set; }

    [Column("voucher_leter")]
    [StringLength(200)]
    [Unicode(false)]
    public string? VoucherLeter { get; set; }

    [Column("voucher_later_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? VoucherLaterNo { get; set; }

    [Column("voucher_later_date")]
    [StringLength(200)]
    [Unicode(false)]
    public string? VoucherLaterDate { get; set; }

    [Column("ref_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [Column("area_no_balady")]
    [StringLength(200)]
    [Unicode(false)]
    public string? AreaNoBalady { get; set; }

    [Column("area_name_balady")]
    [StringLength(200)]
    [Unicode(false)]
    public string? AreaNameBalady { get; set; }

    [Column("table_no_balady")]
    [StringLength(200)]
    [Unicode(false)]
    public string? TableNoBalady { get; set; }

    [Column("table_name_balady")]
    [StringLength(200)]
    [Unicode(false)]
    public string? TableNameBalady { get; set; }

    [Column("full_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? FullName { get; set; }

    [Column("name_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("name_3")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Name3 { get; set; }

    [Column("name_4")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Name4 { get; set; }

    [Column("name_5")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Name5 { get; set; }

    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("job")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Job { get; set; }

    [Column("voucher_status")]
    [StringLength(200)]
    [Unicode(false)]
    public string? VoucherStatus { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("sex")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Sex { get; set; }

    [Column("notes_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Notes1 { get; set; }

    [Column("notes_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Notes2 { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("r_name_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? RName1 { get; set; }

    [Column("r_name_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? RName2 { get; set; }
}
