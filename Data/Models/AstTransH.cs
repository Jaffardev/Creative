using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("ast_trans_h")]
public partial class AstTransH
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("trans_type_id", TypeName = "decimal(18, 0)")]
    public decimal? TransTypeId { get; set; }

    [Column("trans_id", TypeName = "decimal(18, 0)")]
    public decimal? TransId { get; set; }

    [Column("allocat_h_id", TypeName = "decimal(18, 0)")]
    public decimal? AllocatHId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("more_whs")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MoreWhs { get; set; }

    [Column("from_whs_id", TypeName = "decimal(18, 0)")]
    public decimal? FromWhsId { get; set; }

    [Column("to_whs_id", TypeName = "decimal(18, 0)")]
    public decimal? ToWhsId { get; set; }

    [Column("from_whs_code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? FromWhsCode { get; set; }

    [Column("to_whs_code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ToWhsCode { get; set; }

    [Column("rec_isu")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RecIsu { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("department_id", TypeName = "decimal(18, 0)")]
    public decimal? DepartmentId { get; set; }

    [Column("location_id", TypeName = "decimal(18, 0)")]
    public decimal? LocationId { get; set; }

    [Column("reson_id", TypeName = "decimal(18, 0)")]
    public decimal? ResonId { get; set; }

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

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

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("acc_trans_id", TypeName = "decimal(18, 0)")]
    public decimal? AccTransId { get; set; }
}
