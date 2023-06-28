using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("gov_trans_h")]
public partial class GovTransH
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

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("org_id_1", TypeName = "decimal(18, 0)")]
    public decimal? OrgId1 { get; set; }

    [Column("org_id_2", TypeName = "decimal(18, 0)")]
    public decimal? OrgId2 { get; set; }

    [Column("org_id_3", TypeName = "decimal(18, 0)")]
    public decimal? OrgId3 { get; set; }

    [Column("gover_id", TypeName = "decimal(18, 0)")]
    public decimal? GoverId { get; set; }

    [Column("area_id", TypeName = "decimal(18, 0)")]
    public decimal? AreaId { get; set; }

    [Column("persson_id_1", TypeName = "decimal(18, 0)")]
    public decimal? PerssonId1 { get; set; }

    [Column("persson_id_2", TypeName = "decimal(18, 0)")]
    public decimal? PerssonId2 { get; set; }

    [Column("persson_id_3", TypeName = "decimal(18, 0)")]
    public decimal? PerssonId3 { get; set; }

    [Column("type_id_1", TypeName = "decimal(18, 0)")]
    public decimal? TypeId1 { get; set; }

    [Column("type_id_2", TypeName = "decimal(18, 0)")]
    public decimal? TypeId2 { get; set; }

    [Column("type_id_3", TypeName = "decimal(18, 0)")]
    public decimal? TypeId3 { get; set; }

    [Column("type_id_4", TypeName = "decimal(18, 0)")]
    public decimal? TypeId4 { get; set; }

    [Column("photo_1")]
    [StringLength(5000)]
    [Unicode(false)]
    public string? Photo1 { get; set; }

    [Column("photo_2")]
    [StringLength(5000)]
    [Unicode(false)]
    public string? Photo2 { get; set; }

    [Column("photo_3")]
    [StringLength(5000)]
    [Unicode(false)]
    public string? Photo3 { get; set; }

    [Column("photo_4")]
    [StringLength(5000)]
    [Unicode(false)]
    public string? Photo4 { get; set; }

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

    [Column("sector_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SectorName { get; set; }

    [Column("contract_type")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ContractType { get; set; }

    [Column("old_file_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? OldFileNo { get; set; }

    [Column("file_date", TypeName = "datetime")]
    public DateTime? FileDate { get; set; }

    [Column("goverment_entity")]
    [StringLength(100)]
    [Unicode(false)]
    public string? GovermentEntity { get; set; }

    [Column("complainant_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ComplainantName { get; set; }

    [Column("complainant_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ComplainantNo { get; set; }

    [Column("name_of_complainant")]
    [StringLength(100)]
    [Unicode(false)]
    public string? NameOfComplainant { get; set; }

    [Column("ge_issues_decision")]
    [StringLength(100)]
    [Unicode(false)]
    public string? GeIssuesDecision { get; set; }

    [Column("csc_doc_received_date", TypeName = "datetime")]
    public DateTime? CscDocReceivedDate { get; set; }

    [Column("main_category")]
    [StringLength(100)]
    [Unicode(false)]
    public string? MainCategory { get; set; }

    [Column("sub_category")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SubCategory { get; set; }

    [Column("case_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CaseNo { get; set; }

    [Column("supreme_court_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SupremeCourtNo { get; set; }

    [Column("supreme_court_file")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SupremeCourtFile { get; set; }

    [Column("supreme_scan_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SupremeScan1 { get; set; }

    [Column("supreme_scan_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SupremeScan2 { get; set; }

    [Column("supreme_scan_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SupremeScan3 { get; set; }

    [Column("supreme_scan_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SupremeScan4 { get; set; }

    [Column("supreme_scan_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SupremeScan5 { get; set; }

    [Column("supreme_scan_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SupremeScan6 { get; set; }

    [Column("supreme_scan_7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SupremeScan7 { get; set; }

    [Column("supreme_scan_8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SupremeScan8 { get; set; }

    [Column("supreme_scan_9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SupremeScan9 { get; set; }

    [Column("supreme_scan_10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SupremeScan10 { get; set; }

    [Column("apellate_court_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ApellateCourtNo { get; set; }

    [Column("apellate_court_file")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ApellateCourtFile { get; set; }

    [Column("apellate_scan_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ApellateScan1 { get; set; }

    [Column("apellate_scan_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ApellateScan2 { get; set; }

    [Column("apellate_scan_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ApellateScan3 { get; set; }

    [Column("apellate_scan_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ApellateScan4 { get; set; }

    [Column("apellate_scan_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ApellateScan5 { get; set; }

    [Column("apellate_scan_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ApellateScan6 { get; set; }

    [Column("apellate_scan_7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ApellateScan7 { get; set; }

    [Column("apellate_scan_8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ApellateScan8 { get; set; }

    [Column("apellate_scan_9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ApellateScan9 { get; set; }

    [Column("apellate_scan_10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ApellateScan10 { get; set; }

    [Column("court_cassation_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CourtCassationNo { get; set; }

    [Column("court_cassation_file")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CourtCassationFile { get; set; }

    [Column("cassation_scan_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CassationScan1 { get; set; }

    [Column("cassation_scan_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CassationScan2 { get; set; }

    [Column("cassation_scan_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CassationScan3 { get; set; }

    [Column("cassation_scan_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CassationScan4 { get; set; }

    [Column("cassation_scan_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CassationScan5 { get; set; }

    [Column("cassation_scan_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CassationScan6 { get; set; }

    [Column("cassation_scan_7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CassationScan7 { get; set; }

    [Column("cassation_scan_8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CassationScan8 { get; set; }

    [Column("cassation_scan_9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CassationScan9 { get; set; }

    [Column("cassation_scan_10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CassationScan10 { get; set; }
}
