using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("low_import")]
public partial class LowImport
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

    [Column("ref_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RefNo { get; set; }

    [Column("batch_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? BatchNo { get; set; }

    [Column("plaintiff_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PlaintiffName { get; set; }

    [Column("plaintiff_national")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PlaintiffNational { get; set; }

    [Column("plaintiff_id_no")]
    [StringLength(15)]
    [Unicode(false)]
    public string? PlaintiffIdNo { get; set; }

    [Column("disendant_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DisendantName { get; set; }

    [Column("disendant_national")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DisendantNational { get; set; }

    [Column("disendant_id_no")]
    [StringLength(15)]
    [Unicode(false)]
    public string? DisendantIdNo { get; set; }

    [Column("disendant_address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? DisendantAddress { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("r_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RNo { get; set; }

    [Column("r_date", TypeName = "datetime")]
    public DateTime? RDate { get; set; }

    [Column("trans_year")]
    public int? TransYear { get; set; }

    [Column("req_date", TypeName = "datetime")]
    public DateTime? ReqDate { get; set; }

    [Column("line_no_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LineNo1 { get; set; }

    [Column("line_no_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LineNo2 { get; set; }

    [Column("line_no_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LineNo3 { get; set; }

    [Column("line_no_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LineNo4 { get; set; }

    [Column("line_no_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? LineNo5 { get; set; }

    [Column("contract_no_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ContractNo1 { get; set; }

    [Column("contract_no_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ContractNo2 { get; set; }

    [Column("contract_no_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ContractNo3 { get; set; }

    [Column("contract_no_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ContractNo4 { get; set; }

    [Column("contract_no_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ContractNo5 { get; set; }

    [Column("cut_date", TypeName = "datetime")]
    public DateTime? CutDate { get; set; }

    [Column("page_no")]
    public int? PageNo { get; set; }

    [Column("lower_name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LowerName1 { get; set; }

    [Column("lower_name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LowerName2 { get; set; }

    [Column("lower_name_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LowerName3 { get; set; }

    [Column("lower_name_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? LowerName4 { get; set; }

    [Column("exe_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExeNo { get; set; }

    [Column("row_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowStatus { get; set; }

    [Column("row_choose")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowChoose { get; set; }

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
