using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("posr_order_h")]
public partial class PosrOrderH
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("order_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? OrderStatus { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("trans_time", TypeName = "datetime")]
    public DateTime? TransTime { get; set; }

    [Column("reserve_id", TypeName = "decimal(18, 0)")]
    public decimal? ReserveId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("table_id", TypeName = "decimal(18, 0)")]
    public decimal? TableId { get; set; }

    [Column("day_id", TypeName = "decimal(18, 0)")]
    public decimal? DayId { get; set; }

    [Column("group_id", TypeName = "decimal(18, 0)")]
    public decimal? GroupId { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("no_cust", TypeName = "decimal(18, 0)")]
    public decimal? NoCust { get; set; }

    [Column("card_code")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CardCode { get; set; }

    [Column("card_expire_date", TypeName = "datetime")]
    public DateTime? CardExpireDate { get; set; }

    [Column("card_comp")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CardComp { get; set; }

    [Column("shift_id", TypeName = "decimal(18, 0)")]
    public decimal? ShiftId { get; set; }

    [Column("govr_id", TypeName = "decimal(18, 0)")]
    public decimal? GovrId { get; set; }

    [Column("area_id", TypeName = "decimal(18, 0)")]
    public decimal? AreaId { get; set; }

    [Column("price_id", TypeName = "decimal(18, 0)")]
    public decimal? PriceId { get; set; }

    [Column("manger_id", TypeName = "decimal(18, 0)")]
    public decimal? MangerId { get; set; }

    [Column("cashier_id", TypeName = "decimal(18, 0)")]
    public decimal? CashierId { get; set; }

    [Column("sales_man_id", TypeName = "decimal(18, 0)")]
    public decimal? SalesManId { get; set; }

    [Column("driver_id", TypeName = "decimal(18, 0)")]
    public decimal? DriverId { get; set; }

    [Column("total_amount", TypeName = "decimal(18, 3)")]
    public decimal? TotalAmount { get; set; }

    [Column("disc_retio", TypeName = "decimal(18, 3)")]
    public decimal? DiscRetio { get; set; }

    [Column("disc_amount", TypeName = "decimal(18, 3)")]
    public decimal? DiscAmount { get; set; }

    [Column("tax_ratio", TypeName = "decimal(18, 3)")]
    public decimal? TaxRatio { get; set; }

    [Column("tax_amount", TypeName = "decimal(18, 3)")]
    public decimal? TaxAmount { get; set; }

    [Column("tips_amount", TypeName = "decimal(18, 3)")]
    public decimal? TipsAmount { get; set; }

    [Column("serv_ratio", TypeName = "decimal(18, 3)")]
    public decimal? ServRatio { get; set; }

    [Column("serv_amount", TypeName = "decimal(18, 3)")]
    public decimal? ServAmount { get; set; }

    [Column("reason_id", TypeName = "decimal(18, 0)")]
    public decimal? ReasonId { get; set; }

    [Column("disc_reason")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DiscReason { get; set; }

    [Column("reason_desc")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ReasonDesc { get; set; }

    [Column("suspend_command")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SuspendCommand { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

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

    [Column("seat_no")]
    public int? SeatNo { get; set; }

    [Column("delivery_cost", TypeName = "decimal(18, 3)")]
    public decimal? DeliveryCost { get; set; }

    [Column("source_id", TypeName = "decimal(18, 0)")]
    public decimal? SourceId { get; set; }

    [Column("trans_type_id", TypeName = "decimal(18, 0)")]
    public decimal? TransTypeId { get; set; }

    [Column("reserve_date", TypeName = "datetime")]
    public DateTime? ReserveDate { get; set; }

    [Column("reserve_time", TypeName = "datetime")]
    public DateTime? ReserveTime { get; set; }

    [Column("kitchen_start_date", TypeName = "datetime")]
    public DateTime? KitchenStartDate { get; set; }

    [Column("kitchen_end_date", TypeName = "datetime")]
    public DateTime? KitchenEndDate { get; set; }

    [Column("kitchen_start_time", TypeName = "datetime")]
    public DateTime? KitchenStartTime { get; set; }

    [Column("kitchen_end_time", TypeName = "datetime")]
    public DateTime? KitchenEndTime { get; set; }

    [Column("print_date", TypeName = "datetime")]
    public DateTime? PrintDate { get; set; }

    [Column("print_time", TypeName = "datetime")]
    public DateTime? PrintTime { get; set; }

    [Column("driver_date", TypeName = "datetime")]
    public DateTime? DriverDate { get; set; }

    [Column("driver_time", TypeName = "datetime")]
    public DateTime? DriverTime { get; set; }

    [Column("delivery_date", TypeName = "datetime")]
    public DateTime? DeliveryDate { get; set; }

    [Column("delivery_time", TypeName = "datetime")]
    public DateTime? DeliveryTime { get; set; }

    [Column("close_date", TypeName = "datetime")]
    public DateTime? CloseDate { get; set; }

    [Column("close_time", TypeName = "datetime")]
    public DateTime? CloseTime { get; set; }

    [Column("cust_area_id", TypeName = "decimal(18, 0)")]
    public decimal? CustAreaId { get; set; }

    [Column("cust_gover_id", TypeName = "decimal(18, 0)")]
    public decimal? CustGoverId { get; set; }

    [Column("cust_block")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CustBlock { get; set; }

    [Column("cust_street")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CustStreet { get; set; }

    [Column("cust_avenue")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CustAvenue { get; set; }

    [Column("cust_build")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CustBuild { get; set; }

    [Column("cust_floor")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CustFloor { get; set; }

    [Column("cust_flat")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CustFlat { get; set; }

    [Column("cust_adderes")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CustAdderes { get; set; }

    [Column("cust_branch_id", TypeName = "decimal(18, 0)")]
    public decimal? CustBranchId { get; set; }

    [Column("complaint")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Complaint { get; set; }

    [Column("treasury_id", TypeName = "decimal(18, 0)")]
    public decimal? TreasuryId { get; set; }

    [Column("pay_cash", TypeName = "decimal(18, 3)")]
    public decimal? PayCash { get; set; }

    [Column("pay_knet", TypeName = "decimal(18, 3)")]
    public decimal? PayKnet { get; set; }

    [Column("pay_visa", TypeName = "decimal(18, 3)")]
    public decimal? PayVisa { get; set; }

    [Column("pay_master", TypeName = "decimal(18, 3)")]
    public decimal? PayMaster { get; set; }

    [Column("pay_atm", TypeName = "decimal(18, 3)")]
    public decimal? PayAtm { get; set; }

    [Column("pay_other", TypeName = "decimal(18, 3)")]
    public decimal? PayOther { get; set; }

    [Column("total_pay", TypeName = "decimal(18, 3)")]
    public decimal? TotalPay { get; set; }
}
