using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("pbcatvld")]
[Index("PbvName", Name = "pbcatv_x", IsUnique = true)]
public partial class Pbcatvld
{
    [Column("pbv_name")]
    [StringLength(30)]
    [Unicode(false)]
    public string PbvName { get; set; } = null!;

    [Column("pbv_vald")]
    [StringLength(254)]
    [Unicode(false)]
    public string? PbvVald { get; set; }

    [Column("pbv_type")]
    public short? PbvType { get; set; }

    [Column("pbv_cntr")]
    public int? PbvCntr { get; set; }

    [Column("pbv_msg")]
    [StringLength(254)]
    [Unicode(false)]
    public string? PbvMsg { get; set; }
}
