using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("lib_trans")]
public partial class LibTran
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("trans_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? TransType { get; set; }

    [Column("org_id", TypeName = "decimal(18, 0)")]
    public decimal? OrgId { get; set; }

    [Column("items_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemsId { get; set; }

    [Column("library_id", TypeName = "decimal(18, 0)")]
    public decimal? LibraryId { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("allocat_date", TypeName = "datetime")]
    public DateTime? AllocatDate { get; set; }

    [Column("rent_date", TypeName = "datetime")]
    public DateTime? RentDate { get; set; }

    [Column("rent_by")]
    [StringLength(10)]
    [Unicode(false)]
    public string? RentBy { get; set; }

    [Column("return_date_1", TypeName = "datetime")]
    public DateTime? ReturnDate1 { get; set; }

    [Column("return_date_2", TypeName = "datetime")]
    public DateTime? ReturnDate2 { get; set; }

    [Column("return_date_3", TypeName = "datetime")]
    public DateTime? ReturnDate3 { get; set; }

    [Column("return_date_actual", TypeName = "datetime")]
    public DateTime? ReturnDateActual { get; set; }

    [Column("reson_id", TypeName = "decimal(18, 0)")]
    public decimal? ResonId { get; set; }

    [Column("status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

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
}
