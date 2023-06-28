using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hsp_req_type_h")]
public partial class HspReqTypeH
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("row_type")]
    [StringLength(3)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("row_other")]
    [StringLength(100)]
    [Unicode(false)]
    public string? RowOther { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("sample_type")]
    [StringLength(2)]
    [Unicode(false)]
    public string? SampleType { get; set; }

    [Column("sample_text")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SampleText { get; set; }

    [Column("organism")]
    [StringLength(2)]
    [Unicode(false)]
    public string? Organism { get; set; }

    [Column("organism_other")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? OrganismOther { get; set; }

    [Column("label_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Label1 { get; set; }

    [Column("label_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Label2 { get; set; }

    [Column("normal_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Normal1 { get; set; }

    [Column("normal_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Normal2 { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("notes_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes1 { get; set; }

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

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

    [Column("vip_amount", TypeName = "decimal(18, 3)")]
    public decimal? VipAmount { get; set; }

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

    [Column("mandatory")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Mandatory { get; set; }
}
