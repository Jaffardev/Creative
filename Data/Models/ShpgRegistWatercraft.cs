using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("shpg_regist_watercraft")]
public partial class ShpgRegistWatercraft
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

    [Column("owner_name_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OwnerName1 { get; set; }

    [Column("owner_name_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OwnerName2 { get; set; }

    [Column("owner_address")]
    [StringLength(50)]
    [Unicode(false)]
    public string? OwnerAddress { get; set; }

    [Column("position")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Position { get; set; }

    [Column("nationality")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nationality { get; set; }

    [Column("insurance_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InsuranceNo { get; set; }

    [Column("ins_type")]
    [StringLength(50)]
    [Unicode(false)]
    public string? InsType { get; set; }

    [Column("max_speed")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MaxSpeed { get; set; }

    [Column("chassis_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ChassisNo { get; set; }

    [Column("manufactor_place")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ManufactorPlace { get; set; }

    [Column("manufactor_date", TypeName = "datetime")]
    public DateTime? ManufactorDate { get; set; }

    [Column("supplier_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SupplierName { get; set; }

    [Column("emp_name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmpName1 { get; set; }

    [Column("emp_name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmpName2 { get; set; }

    [Column("emp_name_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmpName3 { get; set; }

    [Column("emp_name_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EmpName4 { get; set; }

    [Column("refer_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReferNo { get; set; }

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
