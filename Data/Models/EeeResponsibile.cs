using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("eee_responsibile")]
public partial class EeeResponsibile
{
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("id_o", TypeName = "decimal(18, 0)")]
    public decimal? IdO { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name_1_1")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name11 { get; set; }

    [Column("name_1_2")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name12 { get; set; }

    [Column("name_1_3")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name13 { get; set; }

    [Column("name_1_4")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name14 { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2_1")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name21 { get; set; }

    [Column("name_2_2")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name22 { get; set; }

    [Column("name_2_3")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name23 { get; set; }

    [Column("name_2_4")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name24 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("tel_3")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel3 { get; set; }

    [Column("fax")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("address_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [Column("address_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [Column("email")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("resedence_no")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ResedenceNo { get; set; }

    [Column("xxxresedence_date", TypeName = "datetime")]
    public DateTime? XxxresedenceDate { get; set; }

    [Column("resedence_end_date", TypeName = "datetime")]
    public DateTime? ResedenceEndDate { get; set; }

    [Column("id_type_id", TypeName = "decimal(18, 0)")]
    public decimal? IdTypeId { get; set; }

    [Column("id_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("xxxxid_date", TypeName = "datetime")]
    public DateTime? XxxxidDate { get; set; }

    [Column("id_end_date", TypeName = "datetime")]
    public DateTime? IdEndDate { get; set; }

    [Column("job_id", TypeName = "decimal(18, 0)")]
    public decimal? JobId { get; set; }

    [Column("national_id", TypeName = "decimal(18, 0)")]
    public decimal? NationalId { get; set; }

    [Column("passport_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? PassportNo { get; set; }

    [Column("passport_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PassportType { get; set; }

    [Column("passport_date", TypeName = "datetime")]
    public DateTime? PassportDate { get; set; }

    [Column("passport_end_date", TypeName = "datetime")]
    public DateTime? PassportEndDate { get; set; }

    [Column("xxxxres_life")]
    [StringLength(1)]
    [Unicode(false)]
    public string? XxxxresLife { get; set; }

    [Column("res_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ResType { get; set; }

    [Column("xxxxres_y_n")]
    [StringLength(1)]
    [Unicode(false)]
    public string? XxxxresYN { get; set; }

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

    [Column("brith_date", TypeName = "datetime")]
    public DateTime? BrithDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("exp_notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? ExpNotes { get; set; }
}
