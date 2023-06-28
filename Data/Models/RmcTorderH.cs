using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rmc_torder_h")]
public partial class RmcTorderH
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

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("portfolio_id", TypeName = "decimal(18, 0)")]
    public decimal? PortfolioId { get; set; }

    [Column("real_id", TypeName = "decimal(18, 0)")]
    public decimal? RealId { get; set; }

    [Column("unit_id", TypeName = "decimal(18, 0)")]
    public decimal? UnitId { get; set; }

    [Column("rent_id", TypeName = "decimal(18, 0)")]
    public decimal? RentId { get; set; }

    [Column("rcon_id", TypeName = "decimal(18, 0)")]
    public decimal? RconId { get; set; }

    [Column("tcon_id", TypeName = "decimal(18, 0)")]
    public decimal? TconId { get; set; }

    [Column("caller_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CallerName { get; set; }

    [Column("caller_tel")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CallerTel { get; set; }

    [Column("call_date", TypeName = "datetime")]
    public DateTime? CallDate { get; set; }

    [Column("call_time", TypeName = "datetime")]
    public DateTime? CallTime { get; set; }

    [Column("visit_date", TypeName = "datetime")]
    public DateTime? VisitDate { get; set; }

    [Column("visit_time", TypeName = "datetime")]
    public DateTime? VisitTime { get; set; }

    [Column("problem")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Problem { get; set; }

    [Column("manger_id", TypeName = "decimal(18, 0)")]
    public decimal? MangerId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("dept_id", TypeName = "decimal(18, 0)")]
    public decimal? DeptId { get; set; }

    [Column("team_id", TypeName = "decimal(18, 0)")]
    public decimal? TeamId { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("assign_date", TypeName = "datetime")]
    public DateTime? AssignDate { get; set; }

    [Column("assign_time", TypeName = "datetime")]
    public DateTime? AssignTime { get; set; }

    [Column("assign_by_id", TypeName = "decimal(18, 0)")]
    public decimal? AssignById { get; set; }

    [Column("actual_vist_date", TypeName = "datetime")]
    public DateTime? ActualVistDate { get; set; }

    [Column("actual_vist_time", TypeName = "datetime")]
    public DateTime? ActualVistTime { get; set; }

    [Column("done_date", TypeName = "datetime")]
    public DateTime? DoneDate { get; set; }

    [Column("done_time", TypeName = "datetime")]
    public DateTime? DoneTime { get; set; }

    [Column("total_cost", TypeName = "decimal(18, 3)")]
    public decimal? TotalCost { get; set; }

    [Column("other_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Other1 { get; set; }

    [Column("other_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Other2 { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

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
