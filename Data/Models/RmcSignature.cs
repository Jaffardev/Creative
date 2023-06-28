using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rmc_signature")]
public partial class RmcSignature
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

    [Column("authorized_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AuthorizedName { get; set; }

    [Column("id_no")]
    [StringLength(15)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("nationality_id", TypeName = "decimal(18, 0)")]
    public decimal? NationalityId { get; set; }

    [Column("authorized_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? AuthorizedNo { get; set; }

    [Column("legal_desc")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LegalDesc { get; set; }

    [Column("file_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FileNo { get; set; }

    [Column("requst_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RequstNo { get; set; }

    [Column("license_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LicenseNo { get; set; }

    [Column("commercial_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CommercialName { get; set; }

    [Column("org_issuer_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OrgIssuerNo { get; set; }

    [Column("license_purpose")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LicensePurpose { get; set; }

    [Column("comp_pleace")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CompPleace { get; set; }

    [Column("valid_date")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ValidDate { get; set; }

    [Column("internal_file_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? InternalFileNo { get; set; }

    [Column("pobox_number")]
    [StringLength(20)]
    [Unicode(false)]
    public string? PoboxNumber { get; set; }

    [Column("mailbox")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Mailbox { get; set; }

    [Column("refrence_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? RefrenceNo { get; set; }

    [Column("unified_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? UnifiedNo { get; set; }

    [Column("nationality_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? NationalityNo { get; set; }

    [Column("naturalization_date", TypeName = "datetime")]
    public DateTime? NaturalizationDate { get; set; }

    [Column("legal_age_date", TypeName = "datetime")]
    public DateTime? LegalAgeDate { get; set; }

    [Column("rank_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RankNo { get; set; }

    [Column("bounc_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? BouncNo { get; set; }

    [Column("children_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ChildrenNo { get; set; }

    [Column("reason_termination")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ReasonTermination { get; set; }

    [Column("strat_date_last_salary", TypeName = "datetime")]
    public DateTime? StratDateLastSalary { get; set; }

    [Column("interruption_days_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InterruptionDaysNo { get; set; }

    [Column("legal_status")]
    [StringLength(20)]
    [Unicode(false)]
    public string? LegalStatus { get; set; }

    [Column("passport_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? PassportNo { get; set; }

    [Column("alow1_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Alow1No { get; set; }

    [Column("alow2_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Alow2No { get; set; }

    [Column("tel_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("fax")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("position")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Position { get; set; }
}
