﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("c_car_tpayment")]
public partial class CCarTpayment
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

    [Column("treasury_id", TypeName = "decimal(18, 0)")]
    public decimal? TreasuryId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("con_id", TypeName = "decimal(18, 0)")]
    public decimal? ConId { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("cash_cheq")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CashCheq { get; set; }

    [Column("being_for")]
    [StringLength(500)]
    [Unicode(false)]
    public string? BeingFor { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("amount", TypeName = "decimal(18, 4)")]
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

    [Column("Ticket_amount", TypeName = "decimal(18, 3)")]
    public decimal? TicketAmount { get; set; }

    [Column("from_Ticket", TypeName = "decimal(18, 0)")]
    public decimal? FromTicket { get; set; }

    [Column("to_Ticket", TypeName = "decimal(18, 0)")]
    public decimal? ToTicket { get; set; }
}
