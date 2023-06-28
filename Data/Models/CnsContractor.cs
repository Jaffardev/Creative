using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("cns_contractor")]
public partial class CnsContractor
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

    [Column("cont_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ContType { get; set; }

    [Column("group_id", TypeName = "decimal(18, 0)")]
    public decimal? GroupId { get; set; }

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

    [Column("mobile")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [Column("fax")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("address_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [Column("address_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [Column("address_3")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address3 { get; set; }

    [Column("address_4")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address4 { get; set; }

    [Column("web_site")]
    [StringLength(200)]
    [Unicode(false)]
    public string? WebSite { get; set; }

    [Column("email_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email1 { get; set; }

    [Column("email_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email2 { get; set; }

    [Column("manger")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Manger { get; set; }

    [Column("manger_tel")]
    [StringLength(15)]
    [Unicode(false)]
    public string? MangerTel { get; set; }

    [Column("condact_person")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CondactPerson { get; set; }

    [Column("contact_tel")]
    [StringLength(15)]
    [Unicode(false)]
    public string? ContactTel { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("responser_id", TypeName = "decimal(18, 0)")]
    public decimal? ResponserId { get; set; }

    [Column("country_id", TypeName = "decimal(18, 0)")]
    public decimal? CountryId { get; set; }

    [Column("state_id", TypeName = "decimal(18, 0)")]
    public decimal? StateId { get; set; }

    [Column("area_id", TypeName = "decimal(18, 0)")]
    public decimal? AreaId { get; set; }

    [Column("spatia_discount", TypeName = "decimal(18, 4)")]
    public decimal? SpatiaDiscount { get; set; }

    [Column("credit_limit", TypeName = "decimal(18, 4)")]
    public decimal? CreditLimit { get; set; }

    [Column("credit_day", TypeName = "decimal(18, 0)")]
    public decimal? CreditDay { get; set; }

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("currency_id", TypeName = "decimal(18, 0)")]
    public decimal? CurrencyId { get; set; }

    [Column("price_list_id", TypeName = "decimal(18, 0)")]
    public decimal? PriceListId { get; set; }

    [Column("doc_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Doc1 { get; set; }

    [Column("doc_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Doc2 { get; set; }

    [Column("doc_3")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Doc3 { get; set; }

    [Column("doc_4")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Doc4 { get; set; }

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
