using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rprt_owner")]
public partial class RprtOwner
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

    [Column("owner_group_id", TypeName = "decimal(18, 0)")]
    public decimal? OwnerGroupId { get; set; }

    [Column("owner_type_id", TypeName = "decimal(18, 0)")]
    public decimal? OwnerTypeId { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("email")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("web_sit")]
    [StringLength(200)]
    [Unicode(false)]
    public string? WebSit { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("fax")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("bank_id", TypeName = "decimal(18, 0)")]
    public decimal? BankId { get; set; }

    [Column("bank_branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BankBranchId { get; set; }

    [Column("bank_acc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BankAccNo { get; set; }

    [Column("agent_sign")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AgentSign { get; set; }

    [Column("agent_id_no")]
    [StringLength(15)]
    [Unicode(false)]
    public string? AgentIdNo { get; set; }

    [Column("authorization_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AuthorizationNo { get; set; }

    [Column("authorization_date", TypeName = "datetime")]
    public DateTime? AuthorizationDate { get; set; }

    [Column("gald_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? GaldNo { get; set; }

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

    [Column("owner_id_no")]
    [StringLength(15)]
    [Unicode(false)]
    public string? OwnerIdNo { get; set; }

    [Column("owner_nationality_id", TypeName = "decimal(18, 0)")]
    public decimal? OwnerNationalityId { get; set; }
}
