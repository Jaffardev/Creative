using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rcon_rent")]
[Index("Code", Name = "ix_rcon_rent", IsUnique = true)]
public partial class RconRent
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

    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("social_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SocialStatus { get; set; }

    [Column("sex")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Sex { get; set; }

    [Column("rent_group_id", TypeName = "decimal(18, 0)")]
    public decimal? RentGroupId { get; set; }

    [Column("id_no")]
    [StringLength(12)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("nationality_id", TypeName = "decimal(18, 0)")]
    public decimal? NationalityId { get; set; }

    [Column("pasport_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PasportNo { get; set; }

    [Column("wife_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? WifeName { get; set; }

    [Column("wife_id_no")]
    [StringLength(12)]
    [Unicode(false)]
    public string? WifeIdNo { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("area_id", TypeName = "decimal(18, 0)")]
    public decimal? AreaId { get; set; }

    [Column("part_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PartNo { get; set; }

    [Column("street")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Street { get; set; }

    [Column("kasema")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Kasema { get; set; }

    [Column("house")]
    [StringLength(50)]
    [Unicode(false)]
    public string? House { get; set; }

    [Column("email")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("web_site")]
    [StringLength(200)]
    [Unicode(false)]
    public string? WebSite { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("mobile")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [Column("fax")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("work_tel")]
    [StringLength(15)]
    [Unicode(false)]
    public string? WorkTel { get; set; }

    [Column("work_address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? WorkAddress { get; set; }

    [Column("lisen_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LisenNo { get; set; }

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

    [Column("bank_id", TypeName = "decimal(18, 0)")]
    public decimal? BankId { get; set; }

    [Column("bank_branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BankBranchId { get; set; }

    [Column("bank_acc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BankAccNo { get; set; }

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

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisId { get; set; }

    [Column("authorization_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AuthorizationName { get; set; }

    [Column("authorization_position")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AuthorizationPosition { get; set; }

    [Column("authorization_id_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? AuthorizationIdNo { get; set; }

    [Column("cust_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CustType { get; set; }
}
