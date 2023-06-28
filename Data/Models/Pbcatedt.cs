using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("pbcatedt")]
[Index("PbeName", "PbeSeqn", Name = "pbcate_x", IsUnique = true)]
public partial class Pbcatedt
{
    [Column("pbe_name")]
    [StringLength(30)]
    [Unicode(false)]
    public string PbeName { get; set; } = null!;

    [Column("pbe_edit")]
    [StringLength(254)]
    [Unicode(false)]
    public string? PbeEdit { get; set; }

    [Column("pbe_type")]
    public short? PbeType { get; set; }

    [Column("pbe_cntr")]
    public int? PbeCntr { get; set; }

    [Column("pbe_seqn")]
    public short PbeSeqn { get; set; }

    [Column("pbe_flag")]
    public int? PbeFlag { get; set; }

    [Column("pbe_work")]
    [StringLength(32)]
    [Unicode(false)]
    public string? PbeWork { get; set; }
}
