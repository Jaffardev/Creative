using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("acp_exm_schedule")]
public partial class AcpExmSchedule
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

    [Column("examiner_id_1", TypeName = "decimal(18, 0)")]
    public decimal? ExaminerId1 { get; set; }

    [Column("examiner_id_2", TypeName = "decimal(18, 0)")]
    public decimal? ExaminerId2 { get; set; }

    [Column("examiner_id_3", TypeName = "decimal(18, 0)")]
    public decimal? ExaminerId3 { get; set; }

    [Column("exm_id", TypeName = "decimal(18, 0)")]
    public decimal? ExmId { get; set; }

    [Column("room_id", TypeName = "decimal(18, 0)")]
    public decimal? RoomId { get; set; }

    [Column("exm_date", TypeName = "datetime")]
    public DateTime? ExmDate { get; set; }

    [Column("exm_start_time", TypeName = "datetime")]
    public DateTime? ExmStartTime { get; set; }

    [Column("exm_end_time", TypeName = "datetime")]
    public DateTime? ExmEndTime { get; set; }

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
