using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("lwr_doc")]
public partial class LwrDoc
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

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("description", TypeName = "decimal(18, 0)")]
    public decimal? Description { get; set; }

    [Column("case_id", TypeName = "decimal(18, 0)")]
    public decimal? CaseId { get; set; }

    [Column("case_type_id", TypeName = "decimal(18, 0)")]
    public decimal? CaseTypeId { get; set; }

    [Column("doc_type_id", TypeName = "decimal(18, 0)")]
    public decimal? DocTypeId { get; set; }

    [Column("lawyer_id", TypeName = "decimal(18, 0)")]
    public decimal? LawyerId { get; set; }

    [Column("org_id", TypeName = "decimal(18, 0)")]
    public decimal? OrgId { get; set; }

    [Column("subject_id", TypeName = "decimal(18, 0)")]
    public decimal? SubjectId { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("doc_path")]
    [StringLength(2000)]
    [Unicode(false)]
    public string? DocPath { get; set; }

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
