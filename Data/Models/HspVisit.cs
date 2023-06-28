using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hsp_visit")]
public partial class HspVisit
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

    [Column("clinic_id", TypeName = "decimal(18, 0)")]
    public decimal? ClinicId { get; set; }

    [Column("doctor_id", TypeName = "decimal(18, 0)")]
    public decimal? DoctorId { get; set; }

    [Column("patient_id", TypeName = "decimal(18, 0)")]
    public decimal? PatientId { get; set; }

    [Column("nurse_id", TypeName = "decimal(18, 0)")]
    public decimal? NurseId { get; set; }

    [Column("user_id", TypeName = "decimal(18, 0)")]
    public decimal? UserId { get; set; }

    [Column("row_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowStatus { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("app_date", TypeName = "datetime")]
    public DateTime? AppDate { get; set; }

    [Column("app_time", TypeName = "datetime")]
    public DateTime? AppTime { get; set; }

    [Column("visit_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? VisitNo { get; set; }

    [Column("dis_y_n")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DisYN { get; set; }

    [Column("refferring")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Refferring { get; set; }

    [Column("refferring_other")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RefferringOther { get; set; }

    [Column("complaints")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Complaints { get; set; }

    [Column("add_date", TypeName = "datetime")]
    public DateTime? AddDate { get; set; }

    [Column("dis_date", TypeName = "datetime")]
    public DateTime? DisDate { get; set; }

    [Column("dis_wt", TypeName = "decimal(18, 0)")]
    public decimal? DisWt { get; set; }

    [Column("dis_length", TypeName = "decimal(18, 0)")]
    public decimal? DisLength { get; set; }

    [Column("dis_h_c", TypeName = "decimal(18, 0)")]
    public decimal? DisHC { get; set; }

    [Column("diagnosis_description")]
    [StringLength(500)]
    [Unicode(false)]
    public string? DiagnosisDescription { get; set; }

    [Column("history_description")]
    [StringLength(500)]
    [Unicode(false)]
    public string? HistoryDescription { get; set; }

    [Column("treatment_description")]
    [StringLength(500)]
    [Unicode(false)]
    public string? TreatmentDescription { get; set; }

    [Column("impression_description")]
    [StringLength(500)]
    [Unicode(false)]
    public string? ImpressionDescription { get; set; }

    [Column("follow_up_date", TypeName = "datetime")]
    public DateTime? FollowUpDate { get; set; }

    [Column("follow_up_notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? FollowUpNotes { get; set; }

    [Column("doctor_description")]
    [StringLength(500)]
    [Unicode(false)]
    public string? DoctorDescription { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("notes_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes2 { get; set; }

    [Column("notes_3")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes3 { get; set; }

    [Column("photo_path")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("price_list_id", TypeName = "decimal(18, 0)")]
    public decimal? PriceListId { get; set; }
}
