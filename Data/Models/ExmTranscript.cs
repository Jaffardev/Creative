using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("exm_transcript")]
public partial class ExmTranscript
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("stu_id", TypeName = "decimal(18, 0)")]
    public decimal? StuId { get; set; }

    [Column("stu_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? StuCode { get; set; }

    [Column("stu_name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? StuName1 { get; set; }

    [Column("stu_name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? StuName2 { get; set; }

    [Column("year_no")]
    [StringLength(1)]
    [Unicode(false)]
    public string? YearNo { get; set; }

    [Column("year_id", TypeName = "decimal(18, 0)")]
    public decimal? YearId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("gread_id", TypeName = "decimal(18, 0)")]
    public decimal? GreadId { get; set; }

    [Column("class_id", TypeName = "decimal(18, 0)")]
    public decimal? ClassId { get; set; }

    [Column("course_code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? CourseCode { get; set; }

    [Column("course_name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CourseName1 { get; set; }

    [Column("course_name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CourseName2 { get; set; }

    [Column("course_id", TypeName = "decimal(18, 0)")]
    public decimal? CourseId { get; set; }

    [Column("skille_id", TypeName = "decimal(18, 0)")]
    public decimal? SkilleId { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("degree", TypeName = "decimal(18, 3)")]
    public decimal? Degree { get; set; }

    [Column("grade")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Grade { get; set; }

    [Column("gpa", TypeName = "decimal(18, 3)")]
    public decimal? Gpa { get; set; }

    [Column("credit", TypeName = "decimal(18, 3)")]
    public decimal? Credit { get; set; }

    [Column("ratio", TypeName = "decimal(18, 3)")]
    public decimal? Ratio { get; set; }

    [Column("degree_1", TypeName = "decimal(18, 3)")]
    public decimal? Degree1 { get; set; }

    [Column("ratio_1", TypeName = "decimal(18, 3)")]
    public decimal? Ratio1 { get; set; }

    [Column("degree_2", TypeName = "decimal(18, 3)")]
    public decimal? Degree2 { get; set; }

    [Column("ratio_2", TypeName = "decimal(18, 3)")]
    public decimal? Ratio2 { get; set; }

    [Column("degree_3", TypeName = "decimal(18, 3)")]
    public decimal? Degree3 { get; set; }

    [Column("ratio_3", TypeName = "decimal(18, 3)")]
    public decimal? Ratio3 { get; set; }

    [Column("degree_4", TypeName = "decimal(18, 3)")]
    public decimal? Degree4 { get; set; }

    [Column("ratio_4", TypeName = "decimal(18, 3)")]
    public decimal? Ratio4 { get; set; }

    [Column("degree_5", TypeName = "decimal(18, 3)")]
    public decimal? Degree5 { get; set; }

    [Column("ratio_5", TypeName = "decimal(18, 3)")]
    public decimal? Ratio5 { get; set; }

    [Column("degree_6", TypeName = "decimal(18, 3)")]
    public decimal? Degree6 { get; set; }

    [Column("ratio_6", TypeName = "decimal(18, 3)")]
    public decimal? Ratio6 { get; set; }

    [Column("degree_7", TypeName = "decimal(18, 3)")]
    public decimal? Degree7 { get; set; }

    [Column("ratio_7", TypeName = "decimal(18, 3)")]
    public decimal? Ratio7 { get; set; }

    [Column("degree_8", TypeName = "decimal(18, 3)")]
    public decimal? Degree8 { get; set; }

    [Column("ratio_8", TypeName = "decimal(18, 3)")]
    public decimal? Ratio8 { get; set; }

    [Column("degree_9", TypeName = "decimal(18, 3)")]
    public decimal? Degree9 { get; set; }

    [Column("ratio_9", TypeName = "decimal(18, 3)")]
    public decimal? Ratio9 { get; set; }

    [Column("degree_10", TypeName = "decimal(18, 3)")]
    public decimal? Degree10 { get; set; }

    [Column("ratio_10", TypeName = "decimal(18, 3)")]
    public decimal? Ratio10 { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

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

    [Column("row_sort", TypeName = "decimal(18, 0)")]
    public decimal? RowSort { get; set; }
}
