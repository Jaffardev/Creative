using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hrf_car_trans")]
public partial class HrfCarTran
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("id_old", TypeName = "decimal(18, 0)")]
    public decimal? IdOld { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("row_status")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RowStatus { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("car_id", TypeName = "decimal(18, 0)")]
    public decimal? CarId { get; set; }

    [Column("ven_id", TypeName = "decimal(18, 0)")]
    public decimal? VenId { get; set; }

    [Column("con_id", TypeName = "decimal(18, 0)")]
    public decimal? ConId { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("team_id", TypeName = "decimal(18, 0)")]
    public decimal? TeamId { get; set; }

    [Column("drive_by")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DriveBy { get; set; }

    [Column("accident_type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AccidentType { get; set; }

    [Column("case_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CaseNo { get; set; }

    [Column("case_info")]
    [StringLength(500)]
    [Unicode(false)]
    public string? CaseInfo { get; set; }

    [Column("trans_desc")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? TransDesc { get; set; }

    [Column("damage")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Damage { get; set; }

    [Column("trans_cost", TypeName = "decimal(18, 3)")]
    public decimal? TransCost { get; set; }

    [Column("trans_price", TypeName = "decimal(18, 0)")]
    public decimal? TransPrice { get; set; }

    [Column("calling_date", TypeName = "datetime")]
    public DateTime? CallingDate { get; set; }

    [Column("calling_time", TypeName = "datetime")]
    public DateTime? CallingTime { get; set; }

    [Column("reaching_date", TypeName = "datetime")]
    public DateTime? ReachingDate { get; set; }

    [Column("reaching_time", TypeName = "datetime")]
    public DateTime? ReachingTime { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("end_time", TypeName = "datetime")]
    public DateTime? EndTime { get; set; }

    [Column("delivery_date", TypeName = "datetime")]
    public DateTime? DeliveryDate { get; set; }

    [Column("delivery_time", TypeName = "datetime")]
    public DateTime? DeliveryTime { get; set; }

    [Column("car_counter", TypeName = "decimal(18, 0)")]
    public decimal? CarCounter { get; set; }

    [Column("maintenance_all")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MaintenanceAll { get; set; }

    [Column("maintenance_next_date", TypeName = "datetime")]
    public DateTime? MaintenanceNextDate { get; set; }

    [Column("maintenance_place")]
    [StringLength(100)]
    [Unicode(false)]
    public string? MaintenancePlace { get; set; }

    [Column("access_card")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AccessCard { get; set; }

    [Column("term_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term1 { get; set; }

    [Column("term_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term2 { get; set; }

    [Column("term_3")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term3 { get; set; }

    [Column("term_4")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term4 { get; set; }

    [Column("term_5")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term5 { get; set; }

    [Column("term_6")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term6 { get; set; }

    [Column("term_7")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term7 { get; set; }

    [Column("term_8")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term8 { get; set; }

    [Column("term_9")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term9 { get; set; }

    [Column("photo_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo1 { get; set; }

    [Column("photo_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo2 { get; set; }

    [Column("photo_3")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo3 { get; set; }

    [Column("photo_4")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo4 { get; set; }

    [Column("photo_5")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo5 { get; set; }

    [Column("photo_6")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo6 { get; set; }

    [Column("photo_7")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo7 { get; set; }

    [Column("photo_8")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo8 { get; set; }

    [Column("photo_9")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo9 { get; set; }

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
