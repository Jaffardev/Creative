using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("mmb_trans")]
public partial class MmbTran
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

    [Column("members_id", TypeName = "decimal(18, 0)")]
    public decimal? MembersId { get; set; }

    [Column("service_id", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId { get; set; }

    [Column("trainers_id", TypeName = "decimal(18, 0)")]
    public decimal? TrainersId { get; set; }

    [Column("discount_id", TypeName = "decimal(18, 0)")]
    public decimal? DiscountId { get; set; }

    [Column("pay_amount", TypeName = "decimal(18, 3)")]
    public decimal? PayAmount { get; set; }

    [Column("pay_amount_1", TypeName = "decimal(18, 3)")]
    public decimal? PayAmount1 { get; set; }

    [Column("pay_amount_2", TypeName = "decimal(18, 3)")]
    public decimal? PayAmount2 { get; set; }

    [Column("pay_amount_3", TypeName = "decimal(18, 3)")]
    public decimal? PayAmount3 { get; set; }

    [Column("pay_amount_4", TypeName = "decimal(18, 3)")]
    public decimal? PayAmount4 { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("approve")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

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

    [Column("trans_from_date", TypeName = "datetime")]
    public DateTime? TransFromDate { get; set; }

    [Column("trans_to_date", TypeName = "datetime")]
    public DateTime? TransToDate { get; set; }

    [Column("trans_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransType { get; set; }

    [Column("payment_type_id", TypeName = "decimal(18, 0)")]
    public decimal? PaymentTypeId { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("treasury_id", TypeName = "decimal(18, 0)")]
    public decimal? TreasuryId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("amount_paied", TypeName = "decimal(18, 3)")]
    public decimal? AmountPaied { get; set; }

    [Column("pos_item_id", TypeName = "decimal(18, 0)")]
    public decimal? PosItemId { get; set; }

    [Column("pos_cust_id", TypeName = "decimal(18, 0)")]
    public decimal? PosCustId { get; set; }
}
