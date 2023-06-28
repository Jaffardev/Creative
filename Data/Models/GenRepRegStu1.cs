using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("gen_rep_reg_stu$")]
public partial class GenRepRegStu1
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
    [StringLength(255)]
    public string? CreationBy { get; set; }

    [Column("creation_date")]
    [StringLength(255)]
    public string? CreationDate { get; set; }

    [Column("modify_by")]
    [StringLength(255)]
    public string? ModifyBy { get; set; }

    [Column("modify_date")]
    [StringLength(255)]
    public string? ModifyDate { get; set; }
}
