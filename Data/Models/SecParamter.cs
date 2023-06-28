using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("sec_paramter")]
public partial class SecParamter
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(5)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("educat_name_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EducatName1 { get; set; }

    [Column("educat_name_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? EducatName2 { get; set; }

    [Column("educat_address")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EducatAddress { get; set; }

    [Column("educat_address_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? EducatAddress2 { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("tel_3")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel3 { get; set; }

    [Column("fax_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Fax1 { get; set; }

    [Column("fax_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Fax2 { get; set; }

    [Column("mobile_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Mobile1 { get; set; }

    [Column("mobile_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Mobile2 { get; set; }

    [Column("win_boutton")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WinBoutton { get; set; }

    [Column("open_day", TypeName = "datetime")]
    public DateTime? OpenDay { get; set; }
}
