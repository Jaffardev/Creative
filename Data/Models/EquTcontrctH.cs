using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("equ_tcontrct_h")]
public partial class EquTcontrctH
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("sal_branch_id", TypeName = "decimal(18, 0)")]
    public decimal? SalBranchId { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("con_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ConStatus { get; set; }

    [Column("deprt_id", TypeName = "decimal(18, 0)")]
    public decimal? DeprtId { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("emp_manger_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpMangerId { get; set; }

    [Column("project_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ProjectName { get; set; }

    [Column("project_desc")]
    [StringLength(500)]
    [Unicode(false)]
    public string? ProjectDesc { get; set; }

    [Column("location")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Location { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("start_time", TypeName = "datetime")]
    public DateTime? StartTime { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("end_time", TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    [Column("discount_rate", TypeName = "decimal(18, 5)")]
    public decimal? DiscountRate { get; set; }

    [Column("discount", TypeName = "decimal(18, 4)")]
    public decimal? Discount { get; set; }

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

    [InverseProperty("HIdNavigation")]
    public virtual ICollection<EquTcontractD> EquTcontractDs { get; set; } = new List<EquTcontractD>();

    [InverseProperty("HIdNavigation")]
    public virtual ICollection<EquTcontrctCar> EquTcontrctCars { get; set; } = new List<EquTcontrctCar>();

    [ForeignKey("SalBranchId")]
    [InverseProperty("EquTcontrctHs")]
    public virtual SalBranch? SalBranch { get; set; }
}
