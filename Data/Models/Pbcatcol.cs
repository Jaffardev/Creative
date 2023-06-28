using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("pbcatcol")]
[Index("PbcTnam", "PbcOwnr", "PbcCnam", Name = "pbcatc_x", IsUnique = true)]
public partial class Pbcatcol
{
    [Column("pbc_tnam")]
    [StringLength(129)]
    [Unicode(false)]
    public string PbcTnam { get; set; } = null!;

    [Column("pbc_tid")]
    public int? PbcTid { get; set; }

    [Column("pbc_ownr")]
    [StringLength(129)]
    [Unicode(false)]
    public string PbcOwnr { get; set; } = null!;

    [Column("pbc_cnam")]
    [StringLength(129)]
    [Unicode(false)]
    public string PbcCnam { get; set; } = null!;

    [Column("pbc_cid")]
    public short? PbcCid { get; set; }

    [Column("pbc_labl")]
    [StringLength(254)]
    [Unicode(false)]
    public string? PbcLabl { get; set; }

    [Column("pbc_lpos")]
    public short? PbcLpos { get; set; }

    [Column("pbc_hdr")]
    [StringLength(254)]
    [Unicode(false)]
    public string? PbcHdr { get; set; }

    [Column("pbc_hpos")]
    public short? PbcHpos { get; set; }

    [Column("pbc_jtfy")]
    public short? PbcJtfy { get; set; }

    [Column("pbc_mask")]
    [StringLength(31)]
    [Unicode(false)]
    public string? PbcMask { get; set; }

    [Column("pbc_case")]
    public short? PbcCase { get; set; }

    [Column("pbc_hght")]
    public short? PbcHght { get; set; }

    [Column("pbc_wdth")]
    public short? PbcWdth { get; set; }

    [Column("pbc_ptrn")]
    [StringLength(31)]
    [Unicode(false)]
    public string? PbcPtrn { get; set; }

    [Column("pbc_bmap")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PbcBmap { get; set; }

    [Column("pbc_init")]
    [StringLength(254)]
    [Unicode(false)]
    public string? PbcInit { get; set; }

    [Column("pbc_cmnt")]
    [StringLength(254)]
    [Unicode(false)]
    public string? PbcCmnt { get; set; }

    [Column("pbc_edit")]
    [StringLength(31)]
    [Unicode(false)]
    public string? PbcEdit { get; set; }

    [Column("pbc_tag")]
    [StringLength(254)]
    [Unicode(false)]
    public string? PbcTag { get; set; }
}
