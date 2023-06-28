using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("mbr_trans_h")]
public partial class MbrTransH
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

    [Column("requst_date", TypeName = "datetime")]
    public DateTime? RequstDate { get; set; }

    [Column("recived_date", TypeName = "datetime")]
    public DateTime? RecivedDate { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("telmarket_id", TypeName = "decimal(18, 0)")]
    public decimal? TelmarketId { get; set; }

    [Column("driver_id", TypeName = "decimal(18, 0)")]
    public decimal? DriverId { get; set; }

    [Column("row_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowStatus { get; set; }

    [Column("start_date", TypeName = "datetime")]
    public DateTime? StartDate { get; set; }

    [Column("end_date", TypeName = "datetime")]
    public DateTime? EndDate { get; set; }

    [Column("id_no")]
    [StringLength(12)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("pay_code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? PayCode { get; set; }

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

    [Column("pro_16")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro16 { get; set; }

    [Column("pro_name_16")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName16 { get; set; }

    [Column("pro_id_16", TypeName = "decimal(18, 0)")]
    public decimal? ProId16 { get; set; }

    [Column("pro_amount_16", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount16 { get; set; }

    [Column("pro_17")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro17 { get; set; }

    [Column("pro_name_17")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName17 { get; set; }

    [Column("pro_id_17", TypeName = "decimal(18, 0)")]
    public decimal? ProId17 { get; set; }

    [Column("pro_amount_17", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount17 { get; set; }

    [Column("pro_18")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro18 { get; set; }

    [Column("pro_name_18")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName18 { get; set; }

    [Column("pro_id_18", TypeName = "decimal(18, 0)")]
    public decimal? ProId18 { get; set; }

    [Column("pro_amount_18", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount18 { get; set; }

    [Column("pro_19")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro19 { get; set; }

    [Column("pro_name_19")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName19 { get; set; }

    [Column("pro_id_19", TypeName = "decimal(18, 0)")]
    public decimal? ProId19 { get; set; }

    [Column("pro_amount_19", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount19 { get; set; }

    [Column("pro_20")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro20 { get; set; }

    [Column("pro_name_20")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName20 { get; set; }

    [Column("pro_id_20", TypeName = "decimal(18, 0)")]
    public decimal? ProId20 { get; set; }

    [Column("pro_amount_20", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount20 { get; set; }

    [Column("pro_21")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro21 { get; set; }

    [Column("pro_name_21")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName21 { get; set; }

    [Column("pro_id_21", TypeName = "decimal(18, 0)")]
    public decimal? ProId21 { get; set; }

    [Column("pro_amount_21", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount21 { get; set; }

    [Column("pro_22")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro22 { get; set; }

    [Column("pro_name_22")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName22 { get; set; }

    [Column("pro_id_22", TypeName = "decimal(18, 0)")]
    public decimal? ProId22 { get; set; }

    [Column("pro_amount_22", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount22 { get; set; }

    [Column("pro_23")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro23 { get; set; }

    [Column("pro_name_23")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName23 { get; set; }

    [Column("pro_id_23", TypeName = "decimal(18, 0)")]
    public decimal? ProId23 { get; set; }

    [Column("pro_amount_23", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount23 { get; set; }

    [Column("pro_24")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro24 { get; set; }

    [Column("pro_name_24")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName24 { get; set; }

    [Column("pro_id_24", TypeName = "decimal(18, 0)")]
    public decimal? ProId24 { get; set; }

    [Column("pro_amount_24", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount24 { get; set; }

    [Column("pro_25")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro25 { get; set; }

    [Column("pro_name_25")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName25 { get; set; }

    [Column("pro_id_25", TypeName = "decimal(18, 0)")]
    public decimal? ProId25 { get; set; }

    [Column("pro_amount_25", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount25 { get; set; }

    [Column("pro_26")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro26 { get; set; }

    [Column("pro_name_26")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName26 { get; set; }

    [Column("pro_id_26", TypeName = "decimal(18, 0)")]
    public decimal? ProId26 { get; set; }

    [Column("pro_amount_26", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount26 { get; set; }

    [Column("pro_27")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro27 { get; set; }

    [Column("pro_name_27")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName27 { get; set; }

    [Column("pro_id_27", TypeName = "decimal(18, 0)")]
    public decimal? ProId27 { get; set; }

    [Column("pro_amount_27", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount27 { get; set; }

    [Column("pro_28")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro28 { get; set; }

    [Column("pro_name_28")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName28 { get; set; }

    [Column("pro_id_28", TypeName = "decimal(18, 0)")]
    public decimal? ProId28 { get; set; }

    [Column("pro_amount_28", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount28 { get; set; }

    [Column("pro_29")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro29 { get; set; }

    [Column("pro_name_29")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName29 { get; set; }

    [Column("pro_id_29", TypeName = "decimal(18, 0)")]
    public decimal? ProId29 { get; set; }

    [Column("pro_amount_29", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount29 { get; set; }

    [Column("pro_30")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro30 { get; set; }

    [Column("pro_name_30")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName30 { get; set; }

    [Column("pro_id_30", TypeName = "decimal(18, 0)")]
    public decimal? ProId30 { get; set; }

    [Column("pro_amount_30", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount30 { get; set; }

    [Column("pro_31")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro31 { get; set; }

    [Column("pro_name_31")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName31 { get; set; }

    [Column("pro_id_31", TypeName = "decimal(18, 0)")]
    public decimal? ProId31 { get; set; }

    [Column("pro_amount_31", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount31 { get; set; }

    [Column("pro_32")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro32 { get; set; }

    [Column("pro_name_32")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName32 { get; set; }

    [Column("pro_id_32", TypeName = "decimal(18, 0)")]
    public decimal? ProId32 { get; set; }

    [Column("pro_amount_32", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount32 { get; set; }

    [Column("pro_33")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro33 { get; set; }

    [Column("pro_name_33")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName33 { get; set; }

    [Column("pro_id_33", TypeName = "decimal(18, 0)")]
    public decimal? ProId33 { get; set; }

    [Column("pro_amount_33", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount33 { get; set; }

    [Column("pro_34")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro34 { get; set; }

    [Column("pro_name_34")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName34 { get; set; }

    [Column("pro_id_34", TypeName = "decimal(18, 0)")]
    public decimal? ProId34 { get; set; }

    [Column("pro_amount_34", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount34 { get; set; }

    [Column("pro_35")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro35 { get; set; }

    [Column("pro_name_35")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName35 { get; set; }

    [Column("pro_id_35", TypeName = "decimal(18, 0)")]
    public decimal? ProId35 { get; set; }

    [Column("pro_amount_35", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount35 { get; set; }

    [Column("pro_36")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro36 { get; set; }

    [Column("pro_name_36")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName36 { get; set; }

    [Column("pro_id_36", TypeName = "decimal(18, 0)")]
    public decimal? ProId36 { get; set; }

    [Column("pro_amount_36", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount36 { get; set; }

    [Column("pro_37")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro37 { get; set; }

    [Column("pro_name_37")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName37 { get; set; }

    [Column("pro_id_37", TypeName = "decimal(18, 0)")]
    public decimal? ProId37 { get; set; }

    [Column("pro_amount_37", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount37 { get; set; }

    [Column("pro_38")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro38 { get; set; }

    [Column("pro_name_38")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName38 { get; set; }

    [Column("pro_id_38", TypeName = "decimal(18, 0)")]
    public decimal? ProId38 { get; set; }

    [Column("pro_amount_38", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount38 { get; set; }

    [Column("pro_39")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro39 { get; set; }

    [Column("pro_name_39")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName39 { get; set; }

    [Column("pro_id_39", TypeName = "decimal(18, 0)")]
    public decimal? ProId39 { get; set; }

    [Column("pro_amount_39", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount39 { get; set; }

    [Column("pro_40")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro40 { get; set; }

    [Column("pro_name_40")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName40 { get; set; }

    [Column("pro_id_40", TypeName = "decimal(18, 0)")]
    public decimal? ProId40 { get; set; }

    [Column("pro_amount_40", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount40 { get; set; }

    [Column("pro_41")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro41 { get; set; }

    [Column("pro_name_41")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName41 { get; set; }

    [Column("pro_id_41", TypeName = "decimal(18, 0)")]
    public decimal? ProId41 { get; set; }

    [Column("pro_amount_41", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount41 { get; set; }

    [Column("pro_42")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro42 { get; set; }

    [Column("pro_name_42")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName42 { get; set; }

    [Column("pro_id_42", TypeName = "decimal(18, 0)")]
    public decimal? ProId42 { get; set; }

    [Column("pro_amount_42", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount42 { get; set; }

    [Column("pro_43")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro43 { get; set; }

    [Column("pro_name_43")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName43 { get; set; }

    [Column("pro_id_43", TypeName = "decimal(18, 0)")]
    public decimal? ProId43 { get; set; }

    [Column("pro_amount_43", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount43 { get; set; }

    [Column("pro_44")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro44 { get; set; }

    [Column("pro_name_44")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName44 { get; set; }

    [Column("pro_id_44", TypeName = "decimal(18, 0)")]
    public decimal? ProId44 { get; set; }

    [Column("pro_amount_44", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount44 { get; set; }

    [Column("pro_45")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro45 { get; set; }

    [Column("pro_name_45")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName45 { get; set; }

    [Column("pro_id_45", TypeName = "decimal(18, 0)")]
    public decimal? ProId45 { get; set; }

    [Column("pro_amount_45", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount45 { get; set; }

    [Column("pro_46")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro46 { get; set; }

    [Column("pro_name_46")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName46 { get; set; }

    [Column("pro_id_46", TypeName = "decimal(18, 0)")]
    public decimal? ProId46 { get; set; }

    [Column("pro_amount_46", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount46 { get; set; }

    [Column("pro_47")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro47 { get; set; }

    [Column("pro_name_47")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName47 { get; set; }

    [Column("pro_id_47", TypeName = "decimal(18, 0)")]
    public decimal? ProId47 { get; set; }

    [Column("pro_amount_47", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount47 { get; set; }

    [Column("pro_48")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro48 { get; set; }

    [Column("pro_name_48")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName48 { get; set; }

    [Column("pro_id_48", TypeName = "decimal(18, 0)")]
    public decimal? ProId48 { get; set; }

    [Column("pro_amount_48", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount48 { get; set; }

    [Column("pro_49")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro49 { get; set; }

    [Column("pro_name_49")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName49 { get; set; }

    [Column("pro_id_49", TypeName = "decimal(18, 0)")]
    public decimal? ProId49 { get; set; }

    [Column("pro_amount_49", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount49 { get; set; }

    [Column("pro_50")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Pro50 { get; set; }

    [Column("pro_name_50")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ProName50 { get; set; }

    [Column("pro_id_50", TypeName = "decimal(18, 0)")]
    public decimal? ProId50 { get; set; }

    [Column("pro_amount_50", TypeName = "decimal(18, 3)")]
    public decimal? ProAmount50 { get; set; }
}
