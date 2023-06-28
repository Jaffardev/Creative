using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_inspection")]
public partial class PafnInspection
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("gover_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? GoverName { get; set; }

    [Column("gover_id", TypeName = "decimal(18, 0)")]
    public decimal? GoverId { get; set; }

    [Column("company_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CompanyName { get; set; }

    [Column("company_address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? CompanyAddress { get; set; }

    [Column("area_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? AreaNo { get; set; }

    [Column("area_staus")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AreaStaus { get; set; }

    [Column("ground_no")]
    [StringLength(1)]
    [Unicode(false)]
    public string? GroundNo { get; set; }

    [Column("ligth_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LigthStatus { get; set; }

    [Column("bathrooms_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BathroomsStatus { get; set; }

    [Column("ground_food_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? GroundFoodStatus { get; set; }

    [Column("food_cleanliness_staus")]
    [StringLength(1)]
    [Unicode(false)]
    public string? FoodCleanlinessStaus { get; set; }

    [Column("safe_tools_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SafeToolsStatus { get; set; }

    [Column("tools_cleanliness_stuatus")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ToolsCleanlinessStuatus { get; set; }

    [Column("roof_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RoofStatus { get; set; }

    [Column("emp_name_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpName1 { get; set; }

    [Column("emp_name_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpName2 { get; set; }

    [Column("emp_name_3")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpName3 { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("user_post_id", TypeName = "decimal(18, 0)")]
    public decimal? UserPostId { get; set; }

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
