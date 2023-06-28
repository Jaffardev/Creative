using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pafn_certificate_h")]
public partial class PafnCertificateH
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("gover_name")]
    [StringLength(200)]
    [Unicode(false)]
    public string? GoverName { get; set; }

    [Column("gover_id", TypeName = "decimal(18, 0)")]
    public decimal? GoverId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("sender_date", TypeName = "datetime")]
    public DateTime? SenderDate { get; set; }

    [Column("sender_no")]
    [StringLength(200)]
    [Unicode(false)]
    public string? SenderNo { get; set; }

    [Column("importer_address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ImporterAddress { get; set; }

    [Column("importer_date", TypeName = "datetime")]
    public DateTime? ImporterDate { get; set; }

    [Column("source_address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? SourceAddress { get; set; }

    [Column("country")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Country { get; set; }

    [Column("country_id", TypeName = "decimal(18, 0)")]
    public decimal? CountryId { get; set; }

    [Column("shipped_on")]
    [StringLength(200)]
    [Unicode(false)]
    public string? ShippedOn { get; set; }

    [Column("transportation")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Transportation { get; set; }

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

    [Column("user_post_id", TypeName = "decimal(18, 0)")]
    public decimal? UserPostId { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }
}
