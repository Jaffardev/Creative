using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("gen_rep_hr_emp_rep$")]
public partial class GenRepHrEmpRep1
{
    [Column("id")]
    public double? Id { get; set; }

    [Column("code")]
    [StringLength(255)]
    public string? Code { get; set; }

    [Column("name_1")]
    [StringLength(255)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(255)]
    public string? Name2 { get; set; }

    [Column("icon")]
    [StringLength(255)]
    public string? Icon { get; set; }

    [Column("rep_Sort")]
    public double? RepSort { get; set; }

    [Column("active")]
    [StringLength(255)]
    public string? Active { get; set; }

    [Column("notes")]
    [StringLength(255)]
    public string? Notes { get; set; }

    [Column("creation_by")]
    public double? CreationBy { get; set; }

    [Column("creation_date", TypeName = "smalldatetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by")]
    public double? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "smalldatetime")]
    public DateTime? ModifyDate { get; set; }

    [StringLength(255)]
    public string? F13 { get; set; }

    [StringLength(255)]
    public string? F14 { get; set; }

    [StringLength(255)]
    public string? F15 { get; set; }
}
