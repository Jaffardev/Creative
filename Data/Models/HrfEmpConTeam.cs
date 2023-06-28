using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hrf_emp_con_team")]
public partial class HrfEmpConTeam
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

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("team_id", TypeName = "decimal(18, 0)")]
    public decimal? TeamId { get; set; }

    [Column("con_id", TypeName = "decimal(18, 0)")]
    public decimal? ConId { get; set; }

    [Column("con_period", TypeName = "decimal(18, 3)")]
    public decimal? ConPeriod { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

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

    [Column("client_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ClientStatus { get; set; }

    [Column("acc_client_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AccClientStatus { get; set; }

    [Column("kafel_code", TypeName = "decimal(18, 0)")]
    public decimal? KafelCode { get; set; }

    [Column("team_code", TypeName = "decimal(18, 0)")]
    public decimal? TeamCode { get; set; }

    [Column("license_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? LicenseNo { get; set; }

    [Column("permission")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Permission { get; set; }

    [Column("note_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Note1 { get; set; }

    [Column("work_permit_issue_date", TypeName = "datetime")]
    public DateTime? WorkPermitIssueDate { get; set; }

    [Column("first_resid_issue_date", TypeName = "datetime")]
    public DateTime? FirstResidIssueDate { get; set; }

    [Column("end_rec_criminal_date", TypeName = "datetime")]
    public DateTime? EndRecCriminalDate { get; set; }

    [Column("end_work_visa_date", TypeName = "datetime")]
    public DateTime? EndWorkVisaDate { get; set; }

    [Column("end_comm_visa_date", TypeName = "datetime")]
    public DateTime? EndCommVisaDate { get; set; }

    [Column("end_tourist_visa_date", TypeName = "datetime")]
    public DateTime? EndTouristVisaDate { get; set; }

    [Column("end_license_date", TypeName = "datetime")]
    public DateTime? EndLicenseDate { get; set; }

    [Column("cancel_date", TypeName = "datetime")]
    public DateTime? CancelDate { get; set; }

    [Column("req_cancel_date", TypeName = "datetime")]
    public DateTime? ReqCancelDate { get; set; }

    [Column("end_ins_int_license_date", TypeName = "datetime")]
    public DateTime? EndInsIntLicenseDate { get; set; }

    [Column("emp_cust_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? EmpCustStatus { get; set; }

    [Column("work_permit_issue_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? WorkPermitIssueNo { get; set; }

    [Column("residence_ref_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ResidenceRefNo { get; set; }

    [Column("intl_license_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IntlLicenseNo { get; set; }

    [Column("intl_license_date", TypeName = "datetime")]
    public DateTime? IntlLicenseDate { get; set; }

    [Column("license_type")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LicenseType { get; set; }

    [Column("license_issue_place")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LicenseIssuePlace { get; set; }

    [Column("residence_cancel_type")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ResidenceCancelType { get; set; }

    [Column("residence_temp_end_date", TypeName = "datetime")]
    public DateTime? ResidenceTempEndDate { get; set; }

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

    [Column("term_10")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Term10 { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("tel_3")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel3 { get; set; }
}
