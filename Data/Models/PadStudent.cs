using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pad_student")]
public partial class PadStudent
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

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("address_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [Column("address_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("birth_place")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BirthPlace { get; set; }

    [Column("birth_doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BirthDocNo { get; set; }

    [Column("birth_doc_place")]
    [StringLength(100)]
    [Unicode(false)]
    public string? BirthDocPlace { get; set; }

    [Column("id_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("id_end_date", TypeName = "datetime")]
    public DateTime? IdEndDate { get; set; }

    [Column("stu_sex")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StuSex { get; set; }

    [Column("school_id", TypeName = "decimal(18, 0)")]
    public decimal? SchoolId { get; set; }

    [Column("national_id", TypeName = "decimal(18, 0)")]
    public decimal? NationalId { get; set; }

    [Column("responsibile_id", TypeName = "decimal(18, 0)")]
    public decimal? ResponsibileId { get; set; }

    [Column("mother_id_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? MotherIdNo { get; set; }

    [Column("gover_id", TypeName = "decimal(18, 0)")]
    public decimal? GoverId { get; set; }

    [Column("area_id", TypeName = "decimal(18, 0)")]
    public decimal? AreaId { get; set; }

    [Column("reg_date", TypeName = "datetime")]
    public DateTime? RegDate { get; set; }

    [Column("join_date", TypeName = "datetime")]
    public DateTime? JoinDate { get; set; }

    [Column("registed_end_date", TypeName = "datetime")]
    public DateTime? RegistedEndDate { get; set; }

    [Column("come_gread_id", TypeName = "decimal(18, 0)")]
    public decimal? ComeGreadId { get; set; }

    [Column("year_id", TypeName = "decimal(18, 0)")]
    public decimal? YearId { get; set; }

    [Column("gread_id", TypeName = "decimal(18, 0)")]
    public decimal? GreadId { get; set; }

    [Column("photo_1")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Photo1 { get; set; }

    [Column("educational_decision")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EducationalDecision { get; set; }

    [Column("re_evaluation")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ReEvaluation { get; set; }

    [Column("disable_id", TypeName = "decimal(18, 0)")]
    public decimal? DisableId { get; set; }

    [Column("disable_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DisableNo { get; set; }

    [Column("disable_date", TypeName = "datetime")]
    public DateTime? DisableDate { get; set; }

    [Column("disable_end_date", TypeName = "datetime")]
    public DateTime? DisableEndDate { get; set; }

    [Column("next_visit_date", TypeName = "datetime")]
    public DateTime? NextVisitDate { get; set; }

    [Column("intellegent_ratio", TypeName = "decimal(18, 3)")]
    public decimal? IntellegentRatio { get; set; }

    [Column("disable_certif_id", TypeName = "decimal(18, 0)")]
    public decimal? DisableCertifId { get; set; }

    [Column("disable_certif_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DisableCertifNo { get; set; }

    [Column("disable_certif_date", TypeName = "datetime")]
    public DateTime? DisableCertifDate { get; set; }

    [Column("disable_certif_end_date", TypeName = "datetime")]
    public DateTime? DisableCertifEndDate { get; set; }

    [Column("absent_date", TypeName = "datetime")]
    public DateTime? AbsentDate { get; set; }

    [Column("return_date", TypeName = "datetime")]
    public DateTime? ReturnDate { get; set; }

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

    [Column("notes_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Notes1 { get; set; }

    [Column("next_visit_year")]
    public int? NextVisitYear { get; set; }

    [Column("stu_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StuType { get; set; }
}
