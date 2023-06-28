using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_vehicle_license")]
public partial class PafnVehicleLicense
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("license_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? LicenseName { get; set; }

    [Column("gover_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? GoverName { get; set; }

    [Column("gover_id", TypeName = "decimal(18, 0)")]
    public decimal? GoverId { get; set; }

    [Column("license_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? LicenseNo { get; set; }

    [Column("material_type")]
    [StringLength(200)]
    [Unicode(false)]
    public string? MaterialType { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("issue_date", TypeName = "datetime")]
    public DateTime? IssueDate { get; set; }

    [Column("manager_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ManagerName { get; set; }

    [Column("vehicle_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? VehicleNo { get; set; }

    [Column("vehicle_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? VehicleName { get; set; }

    [Column("marka")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Marka { get; set; }

    [Column("mobile_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Mobile1 { get; set; }

    [Column("mobile_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Mobile2 { get; set; }

    [Column("type")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Type { get; set; }

    [Column("model")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Model { get; set; }

    [Column("owner_vehicle_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? OwnerVehicleName { get; set; }

    [Column("address_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address1 { get; set; }

    [Column("other_data")]
    [StringLength(200)]
    [Unicode(false)]
    public string? OtherData { get; set; }

    [Column("national_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? National1 { get; set; }

    [Column("from_date_1", TypeName = "datetime")]
    public DateTime? FromDate1 { get; set; }

    [Column("to_date_1", TypeName = "datetime")]
    public DateTime? ToDate1 { get; set; }

    [Column("issue_date_1", TypeName = "datetime")]
    public DateTime? IssueDate1 { get; set; }

    [Column("emp_name_1")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpName1 { get; set; }

    [Column("from_date_2", TypeName = "datetime")]
    public DateTime? FromDate2 { get; set; }

    [Column("to_date_2", TypeName = "datetime")]
    public DateTime? ToDate2 { get; set; }

    [Column("issue_date_2", TypeName = "datetime")]
    public DateTime? IssueDate2 { get; set; }

    [Column("emp_name_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpName2 { get; set; }

    [Column("from_date_3", TypeName = "datetime")]
    public DateTime? FromDate3 { get; set; }

    [Column("to_date_3", TypeName = "datetime")]
    public DateTime? ToDate3 { get; set; }

    [Column("issue_date_3", TypeName = "datetime")]
    public DateTime? IssueDate3 { get; set; }

    [Column("emp_name_3")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpName3 { get; set; }

    [Column("from_date_4", TypeName = "datetime")]
    public DateTime? FromDate4 { get; set; }

    [Column("to_date_4", TypeName = "datetime")]
    public DateTime? ToDate4 { get; set; }

    [Column("issue_date_4", TypeName = "datetime")]
    public DateTime? IssueDate4 { get; set; }

    [Column("emp_name_4")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpName4 { get; set; }

    [Column("transfer_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? TransferName { get; set; }

    [Column("national_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? National2 { get; set; }

    [Column("national_id", TypeName = "decimal(18, 0)")]
    public decimal? NationalId { get; set; }

    [Column("address_2")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address2 { get; set; }

    [Column("valid_to_date", TypeName = "datetime")]
    public DateTime? ValidToDate { get; set; }

    [Column("issue_date_5", TypeName = "datetime")]
    public DateTime? IssueDate5 { get; set; }

    [Column("emp_name_5")]
    [StringLength(200)]
    [Unicode(false)]
    public string? EmpName5 { get; set; }

    [Column("photo_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Photo1 { get; set; }

    [Column("sales_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? SalesName { get; set; }

    [Column("goods_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? GoodsNo { get; set; }

    [Column("goods_expire_date", TypeName = "datetime")]
    public DateTime? GoodsExpireDate { get; set; }

    [Column("work_area")]
    [StringLength(200)]
    [Unicode(false)]
    public string? WorkArea { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

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

    [Column("user_post_id", TypeName = "decimal(18, 0)")]
    public decimal? UserPostId { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }
}
