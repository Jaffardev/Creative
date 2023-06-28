using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("mmb_appot_trans")]
public partial class MmbAppotTran
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("trans_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransStatus { get; set; }

    [Column("trans_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransType { get; set; }

    [Column("trans_approve")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransApprove { get; set; }

    [Column("members_id", TypeName = "decimal(18, 0)")]
    public decimal? MembersId { get; set; }

    [Column("hall_id", TypeName = "decimal(18, 0)")]
    public decimal? HallId { get; set; }

    [Column("service_id", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId { get; set; }

    [Column("trainers_id", TypeName = "decimal(18, 0)")]
    public decimal? TrainersId { get; set; }

    [Column("team_id", TypeName = "decimal(18, 0)")]
    public decimal? TeamId { get; set; }

    [Column("reserve_by_id", TypeName = "decimal(18, 0)")]
    public decimal? ReserveById { get; set; }

    [Column("reserve_date", TypeName = "datetime")]
    public DateTime? ReserveDate { get; set; }

    [Column("from_time")]
    public int? FromTime { get; set; }

    [Column("to_time")]
    public int? ToTime { get; set; }

    [Column("pay_types_id", TypeName = "decimal(18, 0)")]
    public decimal? PayTypesId { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("bank_name")]
    [StringLength(255)]
    [Unicode(false)]
    public string? BankName { get; set; }

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

    [Column("trans_time", TypeName = "datetime")]
    public DateTime? TransTime { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("from_period")]
    [StringLength(2)]
    [Unicode(false)]
    public string? FromPeriod { get; set; }

    [Column("to_period")]
    [StringLength(2)]
    [Unicode(false)]
    public string? ToPeriod { get; set; }
}
