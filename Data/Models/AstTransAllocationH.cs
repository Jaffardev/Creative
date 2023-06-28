using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("ast_trans_allocation_h")]
public partial class AstTransAllocationH
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("trans_id", TypeName = "decimal(18, 0)")]
    public decimal? TransId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_no", TypeName = "datetime")]
    public DateTime? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("more_whs")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MoreWhs { get; set; }

    [Column("from_whs_id", TypeName = "decimal(18, 0)")]
    public decimal? FromWhsId { get; set; }

    [Column("from_whs_code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? FromWhsCode { get; set; }

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

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

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

    [Column("trans_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransType { get; set; }

    [Column("rent_date", TypeName = "datetime")]
    public DateTime? RentDate { get; set; }

    [Column("return_date_1", TypeName = "datetime")]
    public DateTime? ReturnDate1 { get; set; }

    [Column("return_date_2", TypeName = "datetime")]
    public DateTime? ReturnDate2 { get; set; }

    [Column("return_date_3", TypeName = "datetime")]
    public DateTime? ReturnDate3 { get; set; }
}
