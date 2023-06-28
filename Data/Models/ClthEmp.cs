using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("clth_emp")]
public partial class ClthEmp
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

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("emp_address")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EmpAddress { get; set; }

    [Column("nationalty")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Nationalty { get; set; }

    [Column("job")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Job { get; set; }

    [Column("id_no")]
    [StringLength(12)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("pasport_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PasportNo { get; set; }

    [Column("stay_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? StayType { get; set; }

    [Column("saty_date", TypeName = "datetime")]
    public DateTime? SatyDate { get; set; }

    [Column("stay_data")]
    [StringLength(100)]
    [Unicode(false)]
    public string? StayData { get; set; }

    [Column("stay_end_date", TypeName = "datetime")]
    public DateTime? StayEndDate { get; set; }

    [Column("start_work", TypeName = "datetime")]
    public DateTime? StartWork { get; set; }

    [Column("salary", TypeName = "decimal(18, 4)")]
    public decimal? Salary { get; set; }

    [Column("allowen", TypeName = "decimal(18, 4)")]
    public decimal? Allowen { get; set; }

    [Column("other_salary", TypeName = "decimal(18, 4)")]
    public decimal? OtherSalary { get; set; }

    [Column("discount", TypeName = "decimal(18, 4)")]
    public decimal? Discount { get; set; }

    [Column("leave", TypeName = "decimal(18, 4)")]
    public decimal? Leave { get; set; }

    [Column("work_day", TypeName = "decimal(18, 0)")]
    public decimal? WorkDay { get; set; }

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
