using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("curr_checklist")]
public partial class CurrChecklist
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name_1")]
    [StringLength(8000)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(8000)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("course_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CourseType { get; set; }

    [Column("default_degree", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree { get; set; }

    [Column("min_degree", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree { get; set; }

    [Column("max_degree", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree { get; set; }

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

    [Column("parent_id", TypeName = "decimal(18, 0)")]
    public decimal? ParentId { get; set; }

    [Column("last_level")]
    [StringLength(1)]
    [Unicode(false)]
    public string? LastLevel { get; set; }

    [Column("level_no")]
    public int? LevelNo { get; set; }

    [Column("long_code")]
    [StringLength(255)]
    [Unicode(false)]
    public string? LongCode { get; set; }

    [Column("row_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RowType { get; set; }

    [Column("item_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ItemType { get; set; }

    [Column("exm_name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExmName1 { get; set; }

    [Column("alow_degree_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree1 { get; set; }

    [Column("default_degree_1", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree1 { get; set; }

    [Column("min_degree_1", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree1 { get; set; }

    [Column("max_degree_1", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree1 { get; set; }

    [Column("exam_ratio_1", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio1 { get; set; }

    [Column("open_date_1", TypeName = "datetime")]
    public DateTime? OpenDate1 { get; set; }

    [Column("exam_date_1", TypeName = "datetime")]
    public DateTime? ExamDate1 { get; set; }

    [Column("trans_date_1", TypeName = "datetime")]
    public DateTime? TransDate1 { get; set; }

    [Column("approve_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve1 { get; set; }

    [Column("posted_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted1 { get; set; }

    [Column("printed_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Printed1 { get; set; }

    [Column("exm_name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExmName2 { get; set; }

    [Column("alow_degree_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree2 { get; set; }

    [Column("default_degree_2", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree2 { get; set; }

    [Column("min_degree_2", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree2 { get; set; }

    [Column("max_degree_2", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree2 { get; set; }

    [Column("exam_ratio_2", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio2 { get; set; }

    [Column("open_date_2", TypeName = "datetime")]
    public DateTime? OpenDate2 { get; set; }

    [Column("exam_date_2", TypeName = "datetime")]
    public DateTime? ExamDate2 { get; set; }

    [Column("trans_date_2", TypeName = "datetime")]
    public DateTime? TransDate2 { get; set; }

    [Column("approve_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve2 { get; set; }

    [Column("posted_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted2 { get; set; }

    [Column("printed_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Printed2 { get; set; }

    [Column("exm_name_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExmName3 { get; set; }

    [Column("alow_degree_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree3 { get; set; }

    [Column("default_degree_3", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree3 { get; set; }

    [Column("min_degree_3", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree3 { get; set; }

    [Column("max_degree_3", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree3 { get; set; }

    [Column("exam_ratio_3", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio3 { get; set; }

    [Column("open_date_3", TypeName = "datetime")]
    public DateTime? OpenDate3 { get; set; }

    [Column("exam_date_3", TypeName = "datetime")]
    public DateTime? ExamDate3 { get; set; }

    [Column("trans_date_3", TypeName = "datetime")]
    public DateTime? TransDate3 { get; set; }

    [Column("approve_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve3 { get; set; }

    [Column("posted_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted3 { get; set; }

    [Column("printed_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Printed3 { get; set; }

    [Column("exm_name_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExmName4 { get; set; }

    [Column("alow_degree_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree4 { get; set; }

    [Column("default_degree_4", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree4 { get; set; }

    [Column("min_degree_4", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree4 { get; set; }

    [Column("max_degree_4", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree4 { get; set; }

    [Column("exam_ratio_4", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio4 { get; set; }

    [Column("open_date_4", TypeName = "datetime")]
    public DateTime? OpenDate4 { get; set; }

    [Column("exam_date_4", TypeName = "datetime")]
    public DateTime? ExamDate4 { get; set; }

    [Column("trans_date_4", TypeName = "datetime")]
    public DateTime? TransDate4 { get; set; }

    [Column("approve_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve4 { get; set; }

    [Column("posted_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted4 { get; set; }

    [Column("printed_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Printed4 { get; set; }

    [Column("exm_name_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExmName5 { get; set; }

    [Column("alow_degree_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree5 { get; set; }

    [Column("default_degree_5", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree5 { get; set; }

    [Column("min_degree_5", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree5 { get; set; }

    [Column("max_degree_5", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree5 { get; set; }

    [Column("exam_ratio_5", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio5 { get; set; }

    [Column("open_date_5", TypeName = "datetime")]
    public DateTime? OpenDate5 { get; set; }

    [Column("exam_date_5", TypeName = "datetime")]
    public DateTime? ExamDate5 { get; set; }

    [Column("trans_date_5", TypeName = "datetime")]
    public DateTime? TransDate5 { get; set; }

    [Column("approve_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve5 { get; set; }

    [Column("posted_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted5 { get; set; }

    [Column("printed_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Printed5 { get; set; }

    [Column("exm_name_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExmName6 { get; set; }

    [Column("alow_degree_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree6 { get; set; }

    [Column("default_degree_6", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree6 { get; set; }

    [Column("min_degree_6", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree6 { get; set; }

    [Column("max_degree_6", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree6 { get; set; }

    [Column("exam_ratio_6", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio6 { get; set; }

    [Column("open_date_6", TypeName = "datetime")]
    public DateTime? OpenDate6 { get; set; }

    [Column("exam_date_6", TypeName = "datetime")]
    public DateTime? ExamDate6 { get; set; }

    [Column("trans_date_6", TypeName = "datetime")]
    public DateTime? TransDate6 { get; set; }

    [Column("approve_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve6 { get; set; }

    [Column("posted_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted6 { get; set; }

    [Column("printed_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Printed6 { get; set; }

    [Column("exm_name_7")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExmName7 { get; set; }

    [Column("alow_degree_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree7 { get; set; }

    [Column("default_degree_7", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree7 { get; set; }

    [Column("min_degree_7", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree7 { get; set; }

    [Column("max_degree_7", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree7 { get; set; }

    [Column("exam_ratio_7", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio7 { get; set; }

    [Column("open_date_7", TypeName = "datetime")]
    public DateTime? OpenDate7 { get; set; }

    [Column("exam_date_7", TypeName = "datetime")]
    public DateTime? ExamDate7 { get; set; }

    [Column("trans_date_7", TypeName = "datetime")]
    public DateTime? TransDate7 { get; set; }

    [Column("approve_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve7 { get; set; }

    [Column("posted_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted7 { get; set; }

    [Column("printed_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Printed7 { get; set; }

    [Column("exm_name_8")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExmName8 { get; set; }

    [Column("alow_degree_8")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree8 { get; set; }

    [Column("default_degree_8", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree8 { get; set; }

    [Column("min_degree_8", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree8 { get; set; }

    [Column("max_degree_8", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree8 { get; set; }

    [Column("exam_ratio_8", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio8 { get; set; }

    [Column("open_date_8", TypeName = "datetime")]
    public DateTime? OpenDate8 { get; set; }

    [Column("exam_date_8", TypeName = "datetime")]
    public DateTime? ExamDate8 { get; set; }

    [Column("trans_date_8", TypeName = "datetime")]
    public DateTime? TransDate8 { get; set; }

    [Column("approve_8")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve8 { get; set; }

    [Column("posted_8")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted8 { get; set; }

    [Column("printed_8")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Printed8 { get; set; }

    [Column("exm_name_9")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExmName9 { get; set; }

    [Column("alow_degree_9")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree9 { get; set; }

    [Column("default_degree_9", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree9 { get; set; }

    [Column("min_degree_9", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree9 { get; set; }

    [Column("max_degree_9", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree9 { get; set; }

    [Column("exam_ratio_9", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio9 { get; set; }

    [Column("open_date_9", TypeName = "datetime")]
    public DateTime? OpenDate9 { get; set; }

    [Column("exam_date_9", TypeName = "datetime")]
    public DateTime? ExamDate9 { get; set; }

    [Column("trans_date_9", TypeName = "datetime")]
    public DateTime? TransDate9 { get; set; }

    [Column("approve_9")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve9 { get; set; }

    [Column("posted_9")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted9 { get; set; }

    [Column("printed_9")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Printed9 { get; set; }

    [Column("exm_name_10")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExmName10 { get; set; }

    [Column("alow_degree_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree10 { get; set; }

    [Column("default_degree_10", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree10 { get; set; }

    [Column("min_degree_10", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree10 { get; set; }

    [Column("max_degree_10", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree10 { get; set; }

    [Column("exam_ratio_10", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio10 { get; set; }

    [Column("open_date_10", TypeName = "datetime")]
    public DateTime? OpenDate10 { get; set; }

    [Column("exam_date_10", TypeName = "datetime")]
    public DateTime? ExamDate10 { get; set; }

    [Column("trans_date_10", TypeName = "datetime")]
    public DateTime? TransDate10 { get; set; }

    [Column("approve_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve10 { get; set; }

    [Column("posted_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted10 { get; set; }

    [Column("printed_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Printed10 { get; set; }

    [Column("exm_name_11")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExmName11 { get; set; }

    [Column("alow_degree_11")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree11 { get; set; }

    [Column("default_degree_11", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree11 { get; set; }

    [Column("min_degree_11", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree11 { get; set; }

    [Column("max_degree_11", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree11 { get; set; }

    [Column("exam_ratio_11", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio11 { get; set; }

    [Column("open_date_11", TypeName = "datetime")]
    public DateTime? OpenDate11 { get; set; }

    [Column("exam_date_11", TypeName = "datetime")]
    public DateTime? ExamDate11 { get; set; }

    [Column("trans_date_11", TypeName = "datetime")]
    public DateTime? TransDate11 { get; set; }

    [Column("approve_11")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve11 { get; set; }

    [Column("posted_11")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted11 { get; set; }

    [Column("printed_11")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Printed11 { get; set; }

    [Column("exm_name_12")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExmName12 { get; set; }

    [Column("alow_degree_12")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree12 { get; set; }

    [Column("default_degree_12", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree12 { get; set; }

    [Column("min_degree_12", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree12 { get; set; }

    [Column("max_degree_12", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree12 { get; set; }

    [Column("exam_ratio_12", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio12 { get; set; }

    [Column("open_date_12", TypeName = "datetime")]
    public DateTime? OpenDate12 { get; set; }

    [Column("exam_date_12", TypeName = "datetime")]
    public DateTime? ExamDate12 { get; set; }

    [Column("trans_date_12", TypeName = "datetime")]
    public DateTime? TransDate12 { get; set; }

    [Column("approve_12")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve12 { get; set; }

    [Column("posted_12")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted12 { get; set; }

    [Column("printed_12")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Printed12 { get; set; }

    [Column("exm_name_13")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExmName13 { get; set; }

    [Column("alow_degree_13")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree13 { get; set; }

    [Column("default_degree_13", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree13 { get; set; }

    [Column("min_degree_13", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree13 { get; set; }

    [Column("max_degree_13", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree13 { get; set; }

    [Column("exam_ratio_13", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio13 { get; set; }

    [Column("open_date_13", TypeName = "datetime")]
    public DateTime? OpenDate13 { get; set; }

    [Column("exam_date_13", TypeName = "datetime")]
    public DateTime? ExamDate13 { get; set; }

    [Column("trans_date_13", TypeName = "datetime")]
    public DateTime? TransDate13 { get; set; }

    [Column("approve_13")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve13 { get; set; }

    [Column("posted_13")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted13 { get; set; }

    [Column("printed_13")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Printed13 { get; set; }

    [Column("exm_name_14")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExmName14 { get; set; }

    [Column("alow_degree_14")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree14 { get; set; }

    [Column("default_degree_14", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree14 { get; set; }

    [Column("min_degree_14", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree14 { get; set; }

    [Column("max_degree_14", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree14 { get; set; }

    [Column("exam_ratio_14", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio14 { get; set; }

    [Column("open_date_14", TypeName = "datetime")]
    public DateTime? OpenDate14 { get; set; }

    [Column("exam_date_14", TypeName = "datetime")]
    public DateTime? ExamDate14 { get; set; }

    [Column("trans_date_14", TypeName = "datetime")]
    public DateTime? TransDate14 { get; set; }

    [Column("approve_14")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve14 { get; set; }

    [Column("posted_14")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted14 { get; set; }

    [Column("printed_14")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Printed14 { get; set; }

    [Column("exm_name_15")]
    [StringLength(100)]
    [Unicode(false)]
    public string? ExmName15 { get; set; }

    [Column("alow_degree_15")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree15 { get; set; }

    [Column("default_degree_15", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree15 { get; set; }

    [Column("min_degree_15", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree15 { get; set; }

    [Column("max_degree_15", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree15 { get; set; }

    [Column("exam_ratio_15", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio15 { get; set; }

    [Column("open_date_15", TypeName = "datetime")]
    public DateTime? OpenDate15 { get; set; }

    [Column("exam_date_15", TypeName = "datetime")]
    public DateTime? ExamDate15 { get; set; }

    [Column("trans_date_15", TypeName = "datetime")]
    public DateTime? TransDate15 { get; set; }

    [Column("approve_15")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve15 { get; set; }

    [Column("posted_15")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted15 { get; set; }

    [Column("printed_15")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Printed15 { get; set; }

    [Column("cur_course_id", TypeName = "decimal(18, 0)")]
    public decimal? CurCourseId { get; set; }

    [Column("priority", TypeName = "decimal(18, 0)")]
    public decimal? Priority { get; set; }
}
