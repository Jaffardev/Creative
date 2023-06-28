using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("posr_driver")]
public partial class PosrDriver
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

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("section_id", TypeName = "decimal(18, 0)")]
    public decimal? SectionId { get; set; }

    [Column("user_id", TypeName = "decimal(18, 0)")]
    public decimal? UserId { get; set; }

    [Column("car_id", TypeName = "decimal(18, 0)")]
    public decimal? CarId { get; set; }

    [Column("car_info")]
    [StringLength(500)]
    [Unicode(false)]
    public string? CarInfo { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("sec_mange")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SecMange { get; set; }

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

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("email")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("titel")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Titel { get; set; }

    [Column("id_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("commission_rate", TypeName = "decimal(18, 4)")]
    public decimal? CommissionRate { get; set; }

    [Column("commission_amount", TypeName = "decimal(18, 4)")]
    public decimal? CommissionAmount { get; set; }

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? AnalysisId { get; set; }

    [Column("commission_acc_id", TypeName = "decimal(18, 0)")]
    public decimal? CommissionAccId { get; set; }

    [Column("commission_cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CommissionCostId { get; set; }

    [Column("commission_exp_id", TypeName = "decimal(18, 0)")]
    public decimal? CommissionExpId { get; set; }

    [Column("commission_analysis_id", TypeName = "decimal(18, 0)")]
    public decimal? CommissionAnalysisId { get; set; }

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
