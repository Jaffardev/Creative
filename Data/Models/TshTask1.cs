using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("tsh_tasks")]
public partial class TshTask1
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

    [Column("task_type_id", TypeName = "decimal(18, 0)")]
    public decimal? TaskTypeId { get; set; }

    [Column("task_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TaskType { get; set; }

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("con_id", TypeName = "decimal(18, 0)")]
    public decimal? ConId { get; set; }

    [Column("from_task_id", TypeName = "decimal(18, 0)")]
    public decimal? FromTaskId { get; set; }

    [Column("to_task_id", TypeName = "decimal(18, 0)")]
    public decimal? ToTaskId { get; set; }

    [Column("team_id", TypeName = "decimal(18, 0)")]
    public decimal? TeamId { get; set; }

    [Column("emp_no", TypeName = "decimal(18, 0)")]
    public decimal? EmpNo { get; set; }

    [Column("emp_foreman_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpForemanId { get; set; }

    [Column("emp_instructor_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpInstructorId { get; set; }

    [Column("emp_id_1", TypeName = "decimal(18, 0)")]
    public decimal? EmpId1 { get; set; }

    [Column("emp_id_2", TypeName = "decimal(18, 0)")]
    public decimal? EmpId2 { get; set; }

    [Column("emp_id_3", TypeName = "decimal(18, 0)")]
    public decimal? EmpId3 { get; set; }

    [Column("emp_id_4", TypeName = "decimal(18, 0)")]
    public decimal? EmpId4 { get; set; }

    [Column("doc_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("entery_date", TypeName = "datetime")]
    public DateTime? EnteryDate { get; set; }

    [Column("next_date", TypeName = "datetime")]
    public DateTime? NextDate { get; set; }

    [Column("description_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Description1 { get; set; }

    [Column("description_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Description2 { get; set; }

    [Column("description_3")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Description3 { get; set; }

    [Column("description_4")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Description4 { get; set; }

    [Column("photo_path_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath1 { get; set; }

    [Column("photo_path_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath2 { get; set; }

    [Column("photo_path_3")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath3 { get; set; }

    [Column("photo_path_4")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? PhotoPath4 { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("discount", TypeName = "decimal(18, 3)")]
    public decimal? Discount { get; set; }

    [Column("commission", TypeName = "decimal(18, 3)")]
    public decimal? Commission { get; set; }

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
