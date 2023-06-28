using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("equ_tmaintanance_h")]
public partial class EquTmaintananceH
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("row_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowStatus { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("depart_id", TypeName = "decimal(18, 0)")]
    public decimal? DepartId { get; set; }

    [Column("car_id", TypeName = "decimal(18, 0)")]
    public decimal? CarId { get; set; }

    [Column("emp_driver_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpDriverId { get; set; }

    [Column("emp_manger_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpMangerId { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("from_time", TypeName = "datetime")]
    public DateTime? FromTime { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("to_time", TypeName = "datetime")]
    public DateTime? ToTime { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("driver_amount", TypeName = "decimal(18, 3)")]
    public decimal? DriverAmount { get; set; }

    [Column("service_amount", TypeName = "decimal(18, 3)")]
    public decimal? ServiceAmount { get; set; }

    [Column("penalty_amount", TypeName = "decimal(18, 3)")]
    public decimal? PenaltyAmount { get; set; }

    [Column("other_amount", TypeName = "decimal(18, 3)")]
    public decimal? OtherAmount { get; set; }

    [Column("discount_rate", TypeName = "decimal(18, 5)")]
    public decimal? DiscountRate { get; set; }

    [Column("discount", TypeName = "decimal(18, 3)")]
    public decimal? Discount { get; set; }

    [Column("project_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ProjectName { get; set; }

    [Column("project_desc")]
    [StringLength(500)]
    [Unicode(false)]
    public string? ProjectDesc { get; set; }

    [Column("location")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Location { get; set; }

    [Column("from_km", TypeName = "decimal(18, 3)")]
    public decimal? FromKm { get; set; }

    [Column("to_km", TypeName = "decimal(18, 0)")]
    public decimal? ToKm { get; set; }

    [Column("from_hours", TypeName = "decimal(18, 3)")]
    public decimal? FromHours { get; set; }

    [Column("to_hours", TypeName = "decimal(18, 0)")]
    public decimal? ToHours { get; set; }

    [Column("radio")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Radio { get; set; }

    [Column("jack")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Jack { get; set; }

    [Column("cigarette_lighter")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CigaretteLighter { get; set; }

    [Column("floor_mats")]
    [StringLength(1)]
    [Unicode(false)]
    public string? FloorMats { get; set; }

    [Column("wheel_cover")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WheelCover { get; set; }

    [Column("wheel_kit")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WheelKit { get; set; }

    [Column("spare_wheel")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SpareWheel { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("sal_invoice_id", TypeName = "decimal(18, 0)")]
    public decimal? SalInvoiceId { get; set; }

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
    public virtual ICollection<EquTmaintananceD> EquTmaintananceDs { get; set; } = new List<EquTmaintananceD>();
}
