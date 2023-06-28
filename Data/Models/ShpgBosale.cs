using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("shpg_bosale")]
public partial class ShpgBosale
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("refer_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReferNo { get; set; }

    [Column("call_sign")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CallSign { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("whether_ship")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WhetherShip { get; set; }

    [Column("length", TypeName = "decimal(18, 0)")]
    public decimal? Length { get; set; }

    [Column("breadth", TypeName = "decimal(18, 0)")]
    public decimal? Breadth { get; set; }

    [Column("depth", TypeName = "decimal(18, 0)")]
    public decimal? Depth { get; set; }

    [Column("tones_no", TypeName = "decimal(18, 0)")]
    public decimal? TonesNo { get; set; }

    [Column("gross_tonnge", TypeName = "decimal(18, 0)")]
    public decimal? GrossTonnge { get; set; }

    [Column("registered_tonnge", TypeName = "decimal(18, 0)")]
    public decimal? RegisteredTonnge { get; set; }

    [Column("person_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Person1 { get; set; }

    [Column("person_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Person2 { get; set; }

    [Column("witness_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? WitnessName { get; set; }

    [Column("paid_to")]
    [StringLength(100)]
    [Unicode(false)]
    public string? PaidTo { get; set; }

    [Column("to_person")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ToPerson { get; set; }

    [Column("amount", TypeName = "decimal(18, 0)")]
    public decimal? Amount { get; set; }

    [Column("transfer_amount", TypeName = "decimal(18, 0)")]
    public decimal? TransferAmount { get; set; }

    [Column("register_ship")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RegisterShip { get; set; }

    [Column("year_no")]
    [StringLength(1)]
    [Unicode(false)]
    public string? YearNo { get; set; }

    [Column("month_no")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MonthNo { get; set; }

    [Column("day_name")]
    [StringLength(1)]
    [Unicode(false)]
    public string? DayName { get; set; }

    [Column("registry_date", TypeName = "datetime")]
    public DateTime? RegistryDate { get; set; }

    [Column("hourse_power")]
    [StringLength(50)]
    [Unicode(false)]
    public string? HoursePower { get; set; }

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
