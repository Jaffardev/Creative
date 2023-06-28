using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hrf_doc_trans")]
public partial class HrfDocTran
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo { get; set; }

    [Column("doc_date", TypeName = "datetime")]
    public DateTime? DocDate { get; set; }

    [Column("cust_id", TypeName = "decimal(18, 0)")]
    public decimal? CustId { get; set; }

    [Column("con_id", TypeName = "decimal(18, 0)")]
    public decimal? ConId { get; set; }

    [Column("team_id", TypeName = "decimal(18, 0)")]
    public decimal? TeamId { get; set; }

    [Column("emp_id", TypeName = "decimal(18, 0)")]
    public decimal? EmpId { get; set; }

    [Column("persson_id", TypeName = "decimal(18, 0)")]
    public decimal? PerssonId { get; set; }

    [Column("doc_type_id_1", TypeName = "decimal(18, 0)")]
    public decimal? DocTypeId1 { get; set; }

    [Column("photo_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo1 { get; set; }

    [Column("doc_no_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo1 { get; set; }

    [Column("doc_date_1", TypeName = "datetime")]
    public DateTime? DocDate1 { get; set; }

    [Column("note_1")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Note1 { get; set; }

    [Column("doc_type_id_2", TypeName = "decimal(18, 0)")]
    public decimal? DocTypeId2 { get; set; }

    [Column("photo_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo2 { get; set; }

    [Column("doc_no_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo2 { get; set; }

    [Column("doc_date_2", TypeName = "datetime")]
    public DateTime? DocDate2 { get; set; }

    [Column("note_2")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Note2 { get; set; }

    [Column("doc_type_id_3", TypeName = "decimal(18, 0)")]
    public decimal? DocTypeId3 { get; set; }

    [Column("photo_3")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo3 { get; set; }

    [Column("doc_no_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo3 { get; set; }

    [Column("doc_date_3", TypeName = "datetime")]
    public DateTime? DocDate3 { get; set; }

    [Column("note_3")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Note3 { get; set; }

    [Column("doc_type_id_4", TypeName = "decimal(18, 0)")]
    public decimal? DocTypeId4 { get; set; }

    [Column("photo_4")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo4 { get; set; }

    [Column("doc_no_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo4 { get; set; }

    [Column("doc_date_4", TypeName = "datetime")]
    public DateTime? DocDate4 { get; set; }

    [Column("note_4")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Note4 { get; set; }

    [Column("doc_type_id_5", TypeName = "decimal(18, 0)")]
    public decimal? DocTypeId5 { get; set; }

    [Column("photo_5")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo5 { get; set; }

    [Column("doc_no_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo5 { get; set; }

    [Column("doc_date_5", TypeName = "datetime")]
    public DateTime? DocDate5 { get; set; }

    [Column("note_5")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Note5 { get; set; }

    [Column("doc_type_id_6", TypeName = "decimal(18, 0)")]
    public decimal? DocTypeId6 { get; set; }

    [Column("photo_6")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo6 { get; set; }

    [Column("doc_no_6")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo6 { get; set; }

    [Column("doc_date_6", TypeName = "datetime")]
    public DateTime? DocDate6 { get; set; }

    [Column("note_6")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Note6 { get; set; }

    [Column("doc_type_id_7", TypeName = "decimal(18, 0)")]
    public decimal? DocTypeId7 { get; set; }

    [Column("photo_7")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo7 { get; set; }

    [Column("doc_no_7")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo7 { get; set; }

    [Column("doc_date_7", TypeName = "datetime")]
    public DateTime? DocDate7 { get; set; }

    [Column("note_7")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Note7 { get; set; }

    [Column("doc_type_id_8", TypeName = "decimal(18, 0)")]
    public decimal? DocTypeId8 { get; set; }

    [Column("photo_8")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo8 { get; set; }

    [Column("doc_no_8")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo8 { get; set; }

    [Column("doc_date_8", TypeName = "datetime")]
    public DateTime? DocDate8 { get; set; }

    [Column("note_8")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Note8 { get; set; }

    [Column("doc_type_id_9", TypeName = "decimal(18, 0)")]
    public decimal? DocTypeId9 { get; set; }

    [Column("photo_9")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Photo9 { get; set; }

    [Column("doc_no_9")]
    [StringLength(50)]
    [Unicode(false)]
    public string? DocNo9 { get; set; }

    [Column("doc_date_9", TypeName = "datetime")]
    public DateTime? DocDate9 { get; set; }

    [Column("note_9")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Note9 { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("notes")]
    [StringLength(1000)]
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
