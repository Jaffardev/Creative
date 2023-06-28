using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("crg_employee")]
public partial class CrgEmployee
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

    [Column("emp_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? EmpType { get; set; }

    [Column("nationality_id", TypeName = "decimal(18, 0)")]
    public decimal? NationalityId { get; set; }

    [Column("passport_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? PassportNo { get; set; }

    [Column("passport_from_date", TypeName = "datetime")]
    public DateTime? PassportFromDate { get; set; }

    [Column("passportto_date", TypeName = "datetime")]
    public DateTime? PassporttoDate { get; set; }

    [Column("id_no")]
    [StringLength(15)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("id_from_date", TypeName = "datetime")]
    public DateTime? IdFromDate { get; set; }

    [Column("id_to_date", TypeName = "datetime")]
    public DateTime? IdToDate { get; set; }

    [Column("work_start_date", TypeName = "datetime")]
    public DateTime? WorkStartDate { get; set; }

    [Column("work_end_date", TypeName = "datetime")]
    public DateTime? WorkEndDate { get; set; }

    [Column("salary", TypeName = "decimal(18, 3)")]
    public decimal? Salary { get; set; }

    [Column("tel_1")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("adress")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Adress { get; set; }

    [Column("photo_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo1 { get; set; }

    [Column("photo_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo2 { get; set; }

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

    [Column("hr_emp_id", TypeName = "decimal(18, 0)")]
    public decimal? HrEmpId { get; set; }

    [Column("team_id", TypeName = "decimal(18, 0)")]
    public decimal? TeamId { get; set; }

    [Column("user_id", TypeName = "decimal(18, 0)")]
    public decimal? UserId { get; set; }
}
