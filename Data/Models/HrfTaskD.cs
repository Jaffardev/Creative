using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hrf_task_d")]
public partial class HrfTaskD
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

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("day_no", TypeName = "decimal(18, 3)")]
    public decimal? DayNo { get; set; }

    [Column("cost", TypeName = "decimal(18, 3)")]
    public decimal? Cost { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("resp_emp_id", TypeName = "decimal(18, 0)")]
    public decimal? RespEmpId { get; set; }

    [Column("mandatory")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Mandatory { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("need_date", TypeName = "datetime")]
    public DateTime? NeedDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("rate", TypeName = "decimal(18, 3)")]
    public decimal? Rate { get; set; }

    [Column("notes_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes1 { get; set; }

    [Column("notes_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes2 { get; set; }

    [Column("notes_3")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes3 { get; set; }

    [Column("notes_4")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes4 { get; set; }

    [Column("notes_5")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes5 { get; set; }

    [Column("notes_6")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes6 { get; set; }

    [Column("notes_7")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes7 { get; set; }

    [Column("notes_8")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes8 { get; set; }

    [Column("notes_9")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes9 { get; set; }

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
