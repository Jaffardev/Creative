using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("equ_employ")]
public partial class EquEmploy
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

    [Column("work_status")]
    [StringLength(50)]
    [Unicode(false)]
    public string? WorkStatus { get; set; }

    [Column("sal_branch_id", TypeName = "decimal(18, 0)")]
    public decimal? SalBranchId { get; set; }

    [Column("deprt_id", TypeName = "decimal(18, 0)")]
    public decimal? DeprtId { get; set; }

    [Column("hr_emply_id", TypeName = "decimal(18, 0)")]
    public decimal? HrEmplyId { get; set; }

    [Column("hr_nationalty_id", TypeName = "decimal(18, 0)")]
    public decimal? HrNationaltyId { get; set; }

    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("passport_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PassportNo { get; set; }

    [Column("passport_end_date", TypeName = "datetime")]
    public DateTime? PassportEndDate { get; set; }

    [Column("id_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("id_end_date", TypeName = "datetime")]
    public DateTime? IdEndDate { get; set; }

    [Column("radiance_end_date", TypeName = "datetime")]
    public DateTime? RadianceEndDate { get; set; }

    [Column("lessen_end_date", TypeName = "datetime")]
    public DateTime? LessenEndDate { get; set; }

    [Column("work_start_date", TypeName = "datetime")]
    public DateTime? WorkStartDate { get; set; }

    [Column("work_end_date", TypeName = "datetime")]
    public DateTime? WorkEndDate { get; set; }

    [Column("radiance_company")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RadianceCompany { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("mobile")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("address_out_kw")]
    [StringLength(200)]
    [Unicode(false)]
    public string? AddressOutKw { get; set; }

    [Column("email")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("titel")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Titel { get; set; }

    [Column("salary", TypeName = "decimal(18, 3)")]
    public decimal? Salary { get; set; }

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

    [InverseProperty("Emp")]
    public virtual ICollection<EquTmaintananceD> EquTmaintananceDs { get; set; } = new List<EquTmaintananceD>();
}
