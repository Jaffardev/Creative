using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("pbcattbl")]
[Index("PbtTnam", "PbtOwnr", Name = "pbcatt_x", IsUnique = true)]
public partial class Pbcattbl
{
    [Column("pbt_tnam")]
    [StringLength(129)]
    [Unicode(false)]
    public string PbtTnam { get; set; } = null!;

    [Column("pbt_tid")]
    public int? PbtTid { get; set; }

    [Column("pbt_ownr")]
    [StringLength(129)]
    [Unicode(false)]
    public string PbtOwnr { get; set; } = null!;

    [Column("pbd_fhgt")]
    public short? PbdFhgt { get; set; }

    [Column("pbd_fwgt")]
    public short? PbdFwgt { get; set; }

    [Column("pbd_fitl")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PbdFitl { get; set; }

    [Column("pbd_funl")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PbdFunl { get; set; }

    [Column("pbd_fchr")]
    public short? PbdFchr { get; set; }

    [Column("pbd_fptc")]
    public short? PbdFptc { get; set; }

    [Column("pbd_ffce")]
    [StringLength(18)]
    [Unicode(false)]
    public string? PbdFfce { get; set; }

    [Column("pbh_fhgt")]
    public short? PbhFhgt { get; set; }

    [Column("pbh_fwgt")]
    public short? PbhFwgt { get; set; }

    [Column("pbh_fitl")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PbhFitl { get; set; }

    [Column("pbh_funl")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PbhFunl { get; set; }

    [Column("pbh_fchr")]
    public short? PbhFchr { get; set; }

    [Column("pbh_fptc")]
    public short? PbhFptc { get; set; }

    [Column("pbh_ffce")]
    [StringLength(18)]
    [Unicode(false)]
    public string? PbhFfce { get; set; }

    [Column("pbl_fhgt")]
    public short? PblFhgt { get; set; }

    [Column("pbl_fwgt")]
    public short? PblFwgt { get; set; }

    [Column("pbl_fitl")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PblFitl { get; set; }

    [Column("pbl_funl")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PblFunl { get; set; }

    [Column("pbl_fchr")]
    public short? PblFchr { get; set; }

    [Column("pbl_fptc")]
    public short? PblFptc { get; set; }

    [Column("pbl_ffce")]
    [StringLength(18)]
    [Unicode(false)]
    public string? PblFfce { get; set; }

    [Column("pbt_cmnt")]
    [StringLength(254)]
    [Unicode(false)]
    public string? PbtCmnt { get; set; }
}
