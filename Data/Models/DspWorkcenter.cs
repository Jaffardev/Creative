using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("dsp_workcenter")]
public partial class DspWorkcenter
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("dept_id", TypeName = "decimal(18, 0)")]
    public decimal? DeptId { get; set; }

    [Column("work_day", TypeName = "decimal(18, 0)")]
    public decimal? WorkDay { get; set; }

    [Column("work_time", TypeName = "decimal(18, 2)")]
    public decimal? WorkTime { get; set; }

    [Column("labor_no", TypeName = "decimal(18, 0)")]
    public decimal? LaborNo { get; set; }

    [Column("total_avrg_cost", TypeName = "decimal(18, 0)")]
    public decimal? TotalAvrgCost { get; set; }

    [Column("labor_cost", TypeName = "decimal(18, 4)")]
    public decimal? LaborCost { get; set; }

    [Column("setup_cost", TypeName = "decimal(18, 4)")]
    public decimal? SetupCost { get; set; }

    [Column("work_cost", TypeName = "decimal(18, 4)")]
    public decimal? WorkCost { get; set; }

    [Column("admin_cost", TypeName = "decimal(18, 4)")]
    public decimal? AdminCost { get; set; }

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
}
