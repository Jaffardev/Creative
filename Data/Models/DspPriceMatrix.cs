using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("dsp_price_matrix")]
public partial class DspPriceMatrix
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("loading_scale_id", TypeName = "decimal(18, 0)")]
    public decimal? LoadingScaleId { get; set; }

    [Column("dish_id", TypeName = "decimal(18, 0)")]
    public decimal? DishId { get; set; }

    [Column("dish_recipe_id", TypeName = "decimal(18, 0)")]
    public decimal? DishRecipeId { get; set; }

    [Column("order_number")]
    [StringLength(100)]
    [Unicode(false)]
    public string? OrderNumber { get; set; }

    [Column("dish_dtl_id", TypeName = "decimal(18, 5)")]
    public decimal? DishDtlId { get; set; }

    [Column("dish_reipe_name")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? DishReipeName { get; set; }

    [Column("sacle")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Sacle { get; set; }

    [Column("pax001")]
    public int? Pax001 { get; set; }

    [Column("pax002")]
    public int? Pax002 { get; set; }

    [Column("pax003")]
    public int? Pax003 { get; set; }

    [Column("pax004")]
    public int? Pax004 { get; set; }

    [Column("pax005")]
    public int? Pax005 { get; set; }

    [Column("pax006")]
    public int? Pax006 { get; set; }

    [Column("pax007")]
    public int? Pax007 { get; set; }

    [Column("pax008")]
    public int? Pax008 { get; set; }

    [Column("pax009")]
    public int? Pax009 { get; set; }

    [Column("pax010")]
    public int? Pax010 { get; set; }

    [Column("pax011")]
    public int? Pax011 { get; set; }

    [Column("pax012")]
    public int? Pax012 { get; set; }

    [Column("pax013")]
    public int? Pax013 { get; set; }

    [Column("pax014")]
    public int? Pax014 { get; set; }

    [Column("pax015")]
    public int? Pax015 { get; set; }

    [Column("pax016")]
    public int? Pax016 { get; set; }

    [Column("pax017")]
    public int? Pax017 { get; set; }

    [Column("pax018")]
    public int? Pax018 { get; set; }

    [Column("pax019")]
    public int? Pax019 { get; set; }

    [Column("pax020")]
    public int? Pax020 { get; set; }

    [Column("pax021")]
    public int? Pax021 { get; set; }

    [Column("pax022")]
    public int? Pax022 { get; set; }

    [Column("pax023")]
    public int? Pax023 { get; set; }

    [Column("pax024")]
    public int? Pax024 { get; set; }

    [Column("pax025")]
    public int? Pax025 { get; set; }

    [Column("pax026")]
    public int? Pax026 { get; set; }

    [Column("pax027")]
    public int? Pax027 { get; set; }

    [Column("pax028")]
    public int? Pax028 { get; set; }

    [Column("pax029")]
    public int? Pax029 { get; set; }

    [Column("pax030")]
    public int? Pax030 { get; set; }

    [Column("pax031")]
    public int? Pax031 { get; set; }

    [Column("pax032")]
    public int? Pax032 { get; set; }

    [Column("pax033")]
    public int? Pax033 { get; set; }

    [Column("pax034")]
    public int? Pax034 { get; set; }

    [Column("pax035")]
    public int? Pax035 { get; set; }

    [Column("pax036")]
    public int? Pax036 { get; set; }

    [Column("pax037")]
    public int? Pax037 { get; set; }

    [Column("pax038")]
    public int? Pax038 { get; set; }

    [Column("pax039")]
    public int? Pax039 { get; set; }

    [Column("pax040")]
    public int? Pax040 { get; set; }

    [Column("pax041")]
    public int? Pax041 { get; set; }

    [Column("pax042")]
    public int? Pax042 { get; set; }

    [Column("pax043")]
    public int? Pax043 { get; set; }

    [Column("pax044")]
    public int? Pax044 { get; set; }

    [Column("pax045")]
    public int? Pax045 { get; set; }

    [Column("pax046")]
    public int? Pax046 { get; set; }

    [Column("pax047")]
    public int? Pax047 { get; set; }

    [Column("pax048")]
    public int? Pax048 { get; set; }

    [Column("pax049")]
    public int? Pax049 { get; set; }

    [Column("pax050")]
    public int? Pax050 { get; set; }

    [Column("pax051")]
    public int? Pax051 { get; set; }

    [Column("pax052")]
    public int? Pax052 { get; set; }

    [Column("pax053")]
    public int? Pax053 { get; set; }

    [Column("pax054")]
    public int? Pax054 { get; set; }

    [Column("pax055")]
    public int? Pax055 { get; set; }

    [Column("pax056")]
    public int? Pax056 { get; set; }

    [Column("pax057")]
    public int? Pax057 { get; set; }

    [Column("pax058")]
    public int? Pax058 { get; set; }

    [Column("pax059")]
    public int? Pax059 { get; set; }

    [Column("pax060")]
    public int? Pax060 { get; set; }

    [Column("pax061")]
    public int? Pax061 { get; set; }

    [Column("pax062")]
    public int? Pax062 { get; set; }

    [Column("pax063")]
    public int? Pax063 { get; set; }

    [Column("pax064")]
    public int? Pax064 { get; set; }

    [Column("pax065")]
    public int? Pax065 { get; set; }

    [Column("pax066")]
    public int? Pax066 { get; set; }

    [Column("pax067")]
    public int? Pax067 { get; set; }

    [Column("pax068")]
    public int? Pax068 { get; set; }

    [Column("pax069")]
    public int? Pax069 { get; set; }

    [Column("pax070")]
    public int? Pax070 { get; set; }

    [Column("pax071")]
    public int? Pax071 { get; set; }

    [Column("pax072")]
    public int? Pax072 { get; set; }

    [Column("pax073")]
    public int? Pax073 { get; set; }

    [Column("pax074")]
    public int? Pax074 { get; set; }

    [Column("pax075")]
    public int? Pax075 { get; set; }

    [Column("pax076")]
    public int? Pax076 { get; set; }

    [Column("pax077")]
    public int? Pax077 { get; set; }

    [Column("pax078")]
    public int? Pax078 { get; set; }

    [Column("pax079")]
    public int? Pax079 { get; set; }

    [Column("pax080")]
    public int? Pax080 { get; set; }

    [Column("pax081")]
    public int? Pax081 { get; set; }

    [Column("pax082")]
    public int? Pax082 { get; set; }

    [Column("pax083")]
    public int? Pax083 { get; set; }

    [Column("pax084")]
    public int? Pax084 { get; set; }

    [Column("pax085")]
    public int? Pax085 { get; set; }

    [Column("pax086")]
    public int? Pax086 { get; set; }

    [Column("pax087")]
    public int? Pax087 { get; set; }

    [Column("pax088")]
    public int? Pax088 { get; set; }

    [Column("pax089")]
    public int? Pax089 { get; set; }

    [Column("pax090")]
    public int? Pax090 { get; set; }

    [Column("pax091")]
    public int? Pax091 { get; set; }

    [Column("pax092")]
    public int? Pax092 { get; set; }

    [Column("pax093")]
    public int? Pax093 { get; set; }

    [Column("pax094")]
    public int? Pax094 { get; set; }

    [Column("pax095")]
    public int? Pax095 { get; set; }

    [Column("pax096")]
    public int? Pax096 { get; set; }

    [Column("pax097")]
    public int? Pax097 { get; set; }

    [Column("pax098")]
    public int? Pax098 { get; set; }

    [Column("pax099")]
    public int? Pax099 { get; set; }

    [Column("pax100")]
    public int? Pax100 { get; set; }

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

    [Column("menu_id", TypeName = "decimal(18, 0)")]
    public decimal? MenuId { get; set; }

    [Column("sal_cust_id", TypeName = "decimal(18, 0)")]
    public decimal? SalCustId { get; set; }

    [Column("amount", TypeName = "decimal(18, 5)")]
    public decimal? Amount { get; set; }

    [Column("ratio", TypeName = "decimal(18, 5)")]
    public decimal? Ratio { get; set; }
}
