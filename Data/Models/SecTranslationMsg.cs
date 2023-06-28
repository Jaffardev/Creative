using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("sec_translation_msg")]
[Index("Code", Name = "ix_sec_translation_msg", IsUnique = true)]
[Index("Code", Name = "ix_sec_translation_msg_1", IsUnique = true)]
public partial class SecTranslationMsg
{
    [Key]
    [Column("id", TypeName = "numeric(18, 0)")]
    public decimal Id { get; set; }

    [Column("lang_id", TypeName = "numeric(18, 0)")]
    public decimal? LangId { get; set; }

    [Column("code")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("title_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Title1 { get; set; }

    [Column("title_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Title2 { get; set; }

    [Column("path_photo")]
    [StringLength(500)]
    [Unicode(false)]
    public string? PathPhoto { get; set; }

    [Column("button")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Button { get; set; }

    [Column("name_old")]
    [StringLength(500)]
    [Unicode(false)]
    public string? NameOld { get; set; }

    [Column("title_old")]
    [StringLength(500)]
    [Unicode(false)]
    public string? TitleOld { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("creation_by", TypeName = "numeric(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "numeric(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }
}
