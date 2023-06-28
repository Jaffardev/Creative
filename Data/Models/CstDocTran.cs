using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("cst_doc_trans")]
public partial class CstDocTran
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

    [Column("issue_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IssueCode { get; set; }

    [Column("issue_date", TypeName = "datetime")]
    public DateTime? IssueDate { get; set; }

    [Column("rec_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RecCode { get; set; }

    [Column("rec_date", TypeName = "datetime")]
    public DateTime? RecDate { get; set; }

    [Column("org_id", TypeName = "decimal(18, 0)")]
    public decimal? OrgId { get; set; }

    [Column("org_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? OrgName { get; set; }

    [Column("org_to")]
    [StringLength(100)]
    [Unicode(false)]
    public string? OrgTo { get; set; }

    [Column("p_from")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PFrom { get; set; }

    [Column("p_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PName { get; set; }

    [Column("p_tel_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PTel1 { get; set; }

    [Column("p_tel_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PTel2 { get; set; }

    [Column("p_id_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PIdNo { get; set; }

    [Column("p_job")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PJob { get; set; }

    [Column("p_address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? PAddress { get; set; }

    [Column("subject")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Subject { get; set; }

    [Column("result")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Result { get; set; }

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
}
