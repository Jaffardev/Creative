using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hsp_price_list_d")]
public partial class HspPriceListD
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("h_id", TypeName = "decimal(18, 0)")]
    public decimal? HId { get; set; }

    [Column("req_type_id", TypeName = "decimal(18, 0)")]
    public decimal? ReqTypeId { get; set; }

    [Column("amount", TypeName = "decimal(18, 3)")]
    public decimal? Amount { get; set; }

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

    [Column("patient_ratio", TypeName = "decimal(18, 3)")]
    public decimal? PatientRatio { get; set; }

    [Column("comp_ratio", TypeName = "decimal(18, 3)")]
    public decimal? CompRatio { get; set; }

    [Column("vip_comp_ration", TypeName = "decimal(18, 3)")]
    public decimal? VipCompRation { get; set; }

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
