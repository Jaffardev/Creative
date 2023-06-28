using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hsp_clinic")]
public partial class HspClinic
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

    [Column("room_id", TypeName = "decimal(18, 0)")]
    public decimal? RoomId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("doctor_id", TypeName = "decimal(18, 0)")]
    public decimal? DoctorId { get; set; }

    [Column("nurse_id", TypeName = "decimal(18, 0)")]
    public decimal? NurseId { get; set; }

    [Column("user_id", TypeName = "decimal(18, 0)")]
    public decimal? UserId { get; set; }

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

    [Column("address")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("email")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("web_site")]
    [StringLength(100)]
    [Unicode(false)]
    public string? WebSite { get; set; }

    [Column("manager")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Manager { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("patient_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PatientNo { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("from_time", TypeName = "datetime")]
    public DateTime? FromTime { get; set; }

    [Column("to_time", TypeName = "datetime")]
    public DateTime? ToTime { get; set; }

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

    [Column("photo_path")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PhotoPath { get; set; }

    [Column("day_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Day1 { get; set; }

    [Column("day_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Day2 { get; set; }

    [Column("day_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Day3 { get; set; }

    [Column("day_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Day4 { get; set; }

    [Column("day_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Day5 { get; set; }

    [Column("day_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Day6 { get; set; }

    [Column("day_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Day7 { get; set; }

    [Column("from_time_1", TypeName = "datetime")]
    public DateTime? FromTime1 { get; set; }

    [Column("to_time_1", TypeName = "datetime")]
    public DateTime? ToTime1 { get; set; }

    [Column("from_time_2", TypeName = "datetime")]
    public DateTime? FromTime2 { get; set; }

    [Column("to_time_2", TypeName = "datetime")]
    public DateTime? ToTime2 { get; set; }

    [Column("from_time_23", TypeName = "datetime")]
    public DateTime? FromTime23 { get; set; }

    [Column("to_time_3", TypeName = "datetime")]
    public DateTime? ToTime3 { get; set; }

    [Column("from_time_4", TypeName = "datetime")]
    public DateTime? FromTime4 { get; set; }

    [Column("to_time_4", TypeName = "datetime")]
    public DateTime? ToTime4 { get; set; }

    [Column("from_time_5", TypeName = "datetime")]
    public DateTime? FromTime5 { get; set; }

    [Column("to_time_5", TypeName = "datetime")]
    public DateTime? ToTime5 { get; set; }

    [Column("from_time_6", TypeName = "datetime")]
    public DateTime? FromTime6 { get; set; }

    [Column("to_time_6", TypeName = "datetime")]
    public DateTime? ToTime6 { get; set; }

    [Column("from_time_7", TypeName = "datetime")]
    public DateTime? FromTime7 { get; set; }

    [Column("to_time_7", TypeName = "datetime")]
    public DateTime? ToTime7 { get; set; }

    [Column("patient_ratio", TypeName = "decimal(18, 3)")]
    public decimal? PatientRatio { get; set; }

    [Column("comp_ratio", TypeName = "decimal(18, 3)")]
    public decimal? CompRatio { get; set; }

    [Column("vip_comp_ratio", TypeName = "decimal(18, 3)")]
    public decimal? VipCompRatio { get; set; }

    [Column("vip_pat_ratio", TypeName = "decimal(18, 3)")]
    public decimal? VipPatRatio { get; set; }

    [Column("patient_discount", TypeName = "decimal(18, 3)")]
    public decimal? PatientDiscount { get; set; }

    [Column("comp_discount", TypeName = "decimal(18, 3)")]
    public decimal? CompDiscount { get; set; }

    [Column("vip_pat_discount", TypeName = "decimal(18, 3)")]
    public decimal? VipPatDiscount { get; set; }

    [Column("vip_com_discount", TypeName = "decimal(18, 3)")]
    public decimal? VipComDiscount { get; set; }

    [Column("patient_amount", TypeName = "decimal(18, 3)")]
    public decimal? PatientAmount { get; set; }

    [Column("company_amount", TypeName = "decimal(18, 3)")]
    public decimal? CompanyAmount { get; set; }

    [Column("vip_comp_amount", TypeName = "decimal(18, 3)")]
    public decimal? VipCompAmount { get; set; }

    [Column("vip_pat_amount", TypeName = "decimal(18, 3)")]
    public decimal? VipPatAmount { get; set; }
}
