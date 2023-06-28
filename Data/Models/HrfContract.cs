using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hrf_contract")]
public partial class HrfContract
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

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("con_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ConNo { get; set; }

    [Column("ref_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("cost", TypeName = "decimal(18, 3)")]
    public decimal? Cost { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("insu_amount", TypeName = "decimal(18, 3)")]
    public decimal? InsuAmount { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("default_team_id", TypeName = "decimal(18, 0)")]
    public decimal? DefaultTeamId { get; set; }

    [Column("team_id", TypeName = "decimal(18, 0)")]
    public decimal? TeamId { get; set; }

    [Column("org_issue")]
    [StringLength(100)]
    [Unicode(false)]
    public string? OrgIssue { get; set; }

    [Column("gover_file_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? GoverFileNo { get; set; }

    [Column("location")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Location { get; set; }

    [Column("con_desc")]
    [StringLength(500)]
    [Unicode(false)]
    public string? ConDesc { get; set; }

    [Column("con_subject")]
    [StringLength(500)]
    [Unicode(false)]
    public string? ConSubject { get; set; }

    [Column("renwal_date_1", TypeName = "datetime")]
    public DateTime? RenwalDate1 { get; set; }

    [Column("renwal_date_2", TypeName = "datetime")]
    public DateTime? RenwalDate2 { get; set; }

    [Column("renwal_date_3", TypeName = "datetime")]
    public DateTime? RenwalDate3 { get; set; }

    [Column("renwal_date_4", TypeName = "datetime")]
    public DateTime? RenwalDate4 { get; set; }

    [Column("renwal_date_5", TypeName = "datetime")]
    public DateTime? RenwalDate5 { get; set; }

    [Column("labor_total", TypeName = "decimal(18, 0)")]
    public decimal? LaborTotal { get; set; }

    [Column("labor_local", TypeName = "decimal(18, 0)")]
    public decimal? LaborLocal { get; set; }

    [Column("labor_external", TypeName = "decimal(18, 0)")]
    public decimal? LaborExternal { get; set; }

    [Column("lablor_actual", TypeName = "decimal(18, 0)")]
    public decimal? LablorActual { get; set; }

    [Column("project_resp")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ProjectResp { get; set; }

    [Column("project_manger")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ProjectManger { get; set; }

    [Column("project_manger_asst")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ProjectMangerAsst { get; set; }

    [Column("po_source")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PoSource { get; set; }

    [Column("po_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PoNo { get; set; }

    [Column("po_no_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PoNo1 { get; set; }

    [Column("po_no_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PoNo2 { get; set; }

    [Column("po_no_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PoNo3 { get; set; }

    [Column("po_no_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PoNo4 { get; set; }

    [Column("po_no_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PoNo5 { get; set; }

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

    [Column("bank_name")]
    [StringLength(500)]
    [Unicode(false)]
    public string? BankName { get; set; }

    [Column("bank_guarantee_end_date", TypeName = "datetime")]
    public DateTime? BankGuaranteeEndDate { get; set; }

    [Column("job_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Job1 { get; set; }

    [Column("job_degree_1", TypeName = "decimal(18, 0)")]
    public decimal? JobDegree1 { get; set; }

    [Column("job_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Job2 { get; set; }

    [Column("job_degree_2", TypeName = "decimal(18, 0)")]
    public decimal? JobDegree2 { get; set; }

    [Column("job_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Job3 { get; set; }

    [Column("job_degree_3", TypeName = "decimal(18, 0)")]
    public decimal? JobDegree3 { get; set; }

    [Column("job_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Job4 { get; set; }

    [Column("job_degree_4", TypeName = "decimal(18, 0)")]
    public decimal? JobDegree4 { get; set; }

    [Column("job_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Job5 { get; set; }

    [Column("job_degree_5", TypeName = "decimal(18, 0)")]
    public decimal? JobDegree5 { get; set; }
}
