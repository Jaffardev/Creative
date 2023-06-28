using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("sch_clb_members")]
public partial class SchClbMember
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

    [Column("father_work_tel")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FatherWorkTel { get; set; }

    [Column("father_mobile")]
    [StringLength(15)]
    [Unicode(false)]
    public string? FatherMobile { get; set; }

    [Column("mother_work_tel")]
    [StringLength(15)]
    [Unicode(false)]
    public string? MotherWorkTel { get; set; }

    [Column("mohter_mobile")]
    [StringLength(15)]
    [Unicode(false)]
    public string? MohterMobile { get; set; }

    [Column("home")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Home { get; set; }

    [Column("reg_area_id", TypeName = "decimal(18, 0)")]
    public decimal? RegAreaId { get; set; }

    [Column("reg_national_id", TypeName = "decimal(18, 0)")]
    public decimal? RegNationalId { get; set; }

    [Column("street")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Street { get; set; }

    [Column("block")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Block { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("gender")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column("id_no")]
    [StringLength(15)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

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

    [Column("blood_group")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BloodGroup { get; set; }

    [Column("photo_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Photo1 { get; set; }

    [Column("photo_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Photo2 { get; set; }
}
