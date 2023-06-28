using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("pbcatfmt")]
[Index("PbfName", Name = "pbcatf_x", IsUnique = true)]
public partial class Pbcatfmt
{
    [Column("pbf_name")]
    [StringLength(30)]
    [Unicode(false)]
    public string PbfName { get; set; } = null!;

    [Column("pbf_frmt")]
    [StringLength(254)]
    [Unicode(false)]
    public string? PbfFrmt { get; set; }

    [Column("pbf_type")]
    public short? PbfType { get; set; }

    [Column("pbf_cntr")]
    public int? PbfCntr { get; set; }
}
