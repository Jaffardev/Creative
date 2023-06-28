using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("equ_tmaintanance_d")]
public partial class EquTmaintananceD
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("row_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowStatus { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("car_id", TypeName = "decimal(18, 0)")]
    public decimal? CarId { get; set; }

    [Column("man_item_id", TypeName = "decimal(18, 0)")]
    public decimal? ManItemId { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("equipment_id", TypeName = "decimal(18, 0)")]
    public decimal? EquipmentId { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

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

    [ForeignKey("CarId")]
    [InverseProperty("EquTmaintananceDs")]
    public virtual EquCar? Car { get; set; }

    [ForeignKey("EmpId")]
    [InverseProperty("EquTmaintananceDs")]
    public virtual EquEmploy? Emp { get; set; }

    [ForeignKey("EquipmentId")]
    [InverseProperty("EquTmaintananceDs")]
    public virtual EquMaintananceItem? Equipment { get; set; }

    [ForeignKey("HId")]
    [InverseProperty("EquTmaintananceDs")]
    public virtual EquTmaintananceH? HIdNavigation { get; set; }
}
