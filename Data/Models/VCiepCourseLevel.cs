using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
public partial class VCiepCourseLevel
{
    [Column("course_id", TypeName = "decimal(18, 0)")]
    public decimal CourseId { get; set; }

    [Column("course_code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CourseCode { get; set; }

    [Column("course_name_1")]
    [StringLength(8000)]
    [Unicode(false)]
    public string? CourseName1 { get; set; }

    [Column("course_name_2")]
    [StringLength(8000)]
    [Unicode(false)]
    public string? CourseName2 { get; set; }

    [Column("cat_id", TypeName = "decimal(18, 0)")]
    public decimal CatId { get; set; }

    [Column("cat_code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? CatCode { get; set; }

    [Column("cat_name_1")]
    [StringLength(8000)]
    [Unicode(false)]
    public string? CatName1 { get; set; }

    [Column("cat_name_2")]
    [StringLength(8000)]
    [Unicode(false)]
    public string? CatName2 { get; set; }

    [Column("sub_cat_id", TypeName = "decimal(18, 0)")]
    public decimal SubCatId { get; set; }

    [Column("sub_cat_code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? SubCatCode { get; set; }

    [Column("sub_cat_name_1")]
    [StringLength(8000)]
    [Unicode(false)]
    public string? SubCatName1 { get; set; }

    [Column("sub_cat_name_2")]
    [StringLength(8000)]
    [Unicode(false)]
    public string? SubCatName2 { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal ItemId { get; set; }

    [Column("item_code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? ItemCode { get; set; }

    [Column("item_name_1")]
    [StringLength(8000)]
    [Unicode(false)]
    public string? ItemName1 { get; set; }

    [Column("item_name_2")]
    [StringLength(8000)]
    [Unicode(false)]
    public string? ItemName2 { get; set; }

    [Column("stu_id", TypeName = "decimal(18, 0)")]
    public decimal StuId { get; set; }

    [Column("stu_code")]
    [StringLength(20)]
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
}
