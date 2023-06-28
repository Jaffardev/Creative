using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hsp_req_trans_h")]
public partial class HspReqTransH
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("visit_id", TypeName = "decimal(18, 0)")]
    public decimal? VisitId { get; set; }

    [Column("follow_id", TypeName = "decimal(18, 0)")]
    public decimal? FollowId { get; set; }

    [Column("request_type")]
    [StringLength(3)]
    [Unicode(false)]
    public string? RequestType { get; set; }

    [Column("request_permission", TypeName = "decimal(18, 0)")]
    public decimal? RequestPermission { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("request_date", TypeName = "datetime")]
    public DateTime? RequestDate { get; set; }

    [Column("required_date", TypeName = "datetime")]
    public DateTime? RequiredDate { get; set; }

    [Column("request_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RequestStatus { get; set; }

    [Column("consultation")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Consultation { get; set; }

    [Column("request_from")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? RequestFrom { get; set; }

    [Column("request_notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? RequestNotes { get; set; }

    [Column("request_reply")]
    [StringLength(500)]
    [Unicode(false)]
    public string? RequestReply { get; set; }

    [Column("request_other")]
    [StringLength(500)]
    [Unicode(false)]
    public string? RequestOther { get; set; }

    [Column("notes")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("notes_1")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes1 { get; set; }

    [Column("notes_2")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes2 { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("req_type_h_id", TypeName = "decimal(18, 0)")]
    public decimal? ReqTypeHId { get; set; }

    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("doctor_id", TypeName = "decimal(18, 0)")]
    public decimal? DoctorId { get; set; }

    [Column("nurse_id", TypeName = "decimal(18, 0)")]
    public decimal? NurseId { get; set; }

    [Column("phot_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Phot1 { get; set; }

    [Column("phot_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Phot2 { get; set; }

    [Column("phot_3")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Phot3 { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

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

    [Column("req_group_id", TypeName = "decimal(18, 0)")]
    public decimal? ReqGroupId { get; set; }

    [Column("price_list_id", TypeName = "decimal(18, 0)")]
    public decimal? PriceListId { get; set; }
}
