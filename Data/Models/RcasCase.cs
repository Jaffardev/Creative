using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("rcas_cases")]
public partial class RcasCase
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("court_id", TypeName = "decimal(18, 0)")]
    public decimal? CourtId { get; set; }

    [Column("contract_id", TypeName = "decimal(18, 0)")]
    public decimal? ContractId { get; set; }

    [Column("portf_id", TypeName = "decimal(18, 0)")]
    public decimal? PortfId { get; set; }

    [Column("real_id", TypeName = "decimal(18, 0)")]
    public decimal? RealId { get; set; }

    [Column("unit_id", TypeName = "decimal(18, 0)")]
    public decimal? UnitId { get; set; }

    [Column("rent_id", TypeName = "decimal(18, 0)")]
    public decimal? RentId { get; set; }

    [Column("commend")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Commend { get; set; }

    [Column("holed_rent")]
    [StringLength(1)]
    [Unicode(false)]
    public string? HoledRent { get; set; }

    [Column("from_year")]
    public int? FromYear { get; set; }

    [Column("from_month")]
    public int? FromMonth { get; set; }

    [Column("to_year")]
    public int? ToYear { get; set; }

    [Column("to_month")]
    public int? ToMonth { get; set; }

    [Column("rent_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RentStatus { get; set; }

    [Column("lower_id", TypeName = "decimal(18, 0)")]
    public decimal? LowerId { get; set; }

    [Column("requst_month_no")]
    public int? RequstMonthNo { get; set; }

    [Column("requst_amount", TypeName = "decimal(18, 3)")]
    public decimal? RequstAmount { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("chang_by", TypeName = "decimal(18, 0)")]
    public decimal? ChangBy { get; set; }

    [Column("chang_date", TypeName = "datetime")]
    public DateTime? ChangDate { get; set; }

    [Column("notes")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes { get; set; }
}
