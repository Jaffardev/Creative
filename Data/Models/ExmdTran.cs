using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("exmd_trans")]
public partial class ExmdTran
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(50)]
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

    [Column("exam_id", TypeName = "decimal(18, 0)")]
    public decimal? ExamId { get; set; }

    [Column("stu_id", TypeName = "decimal(18, 0)")]
    public decimal? StuId { get; set; }

    [Column("branch_id", TypeName = "decimal(18, 0)")]
    public decimal? BranchId { get; set; }

    [Column("stage_id", TypeName = "decimal(18, 0)")]
    public decimal? StageId { get; set; }

    [Column("gread_id", TypeName = "decimal(18, 0)")]
    public decimal? GreadId { get; set; }

    [Column("class_id", TypeName = "decimal(18, 0)")]
    public decimal? ClassId { get; set; }

    [Column("teacher_id", TypeName = "decimal(18, 0)")]
    public decimal? TeacherId { get; set; }

    [Column("assisstant_id", TypeName = "decimal(18, 0)")]
    public decimal? AssisstantId { get; set; }

    [Column("year_id", TypeName = "decimal(18, 0)")]
    public decimal? YearId { get; set; }

    [Column("term_id", TypeName = "decimal(18, 0)")]
    public decimal? TermId { get; set; }

    [Column("quarter_id", TypeName = "decimal(18, 0)")]
    public decimal? QuarterId { get; set; }

    [Column("course_id", TypeName = "decimal(18, 0)")]
    public decimal? CourseId { get; set; }

    [Column("skille_id", TypeName = "decimal(18, 0)")]
    public decimal? SkilleId { get; set; }

    [Column("item_id", TypeName = "decimal(18, 0)")]
    public decimal? ItemId { get; set; }

    [Column("cur_course_id", TypeName = "decimal(18, 0)")]
    public decimal? CurCourseId { get; set; }

    [Column("degree", TypeName = "decimal(18, 3)")]
    public decimal? Degree { get; set; }

    [Column("default_degree", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree { get; set; }

    [Column("min_degree", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree { get; set; }

    [Column("max_degree", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree { get; set; }

    [Column("exam_ratio", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio { get; set; }

    [Column("open_date", TypeName = "datetime")]
    public DateTime? OpenDate { get; set; }

    [Column("exam_date", TypeName = "datetime")]
    public DateTime? ExamDate { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("alow_degree")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree { get; set; }

    [Column("approve")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve { get; set; }

    [Column("posted")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted { get; set; }

    [Column("printed")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Printed { get; set; }

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

    [Column("degree_1", TypeName = "decimal(18, 3)")]
    public decimal? Degree1 { get; set; }

    [Column("default_degree_1", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree1 { get; set; }

    [Column("min_degree_1", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree1 { get; set; }

    [Column("max_degree_1", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree1 { get; set; }

    [Column("exam_ratio_1", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio1 { get; set; }

    [Column("alow_degree_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree1 { get; set; }

    [Column("approve_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve1 { get; set; }

    [Column("posted_1")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted1 { get; set; }

    [Column("degree_2", TypeName = "decimal(18, 3)")]
    public decimal? Degree2 { get; set; }

    [Column("default_degree_2", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree2 { get; set; }

    [Column("min_degree_2", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree2 { get; set; }

    [Column("max_degree_2", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree2 { get; set; }

    [Column("exam_ratio_2", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio2 { get; set; }

    [Column("alow_degree_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree2 { get; set; }

    [Column("approve_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve2 { get; set; }

    [Column("posted_2")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted2 { get; set; }

    [Column("degree_3", TypeName = "decimal(18, 3)")]
    public decimal? Degree3 { get; set; }

    [Column("default_degree_3", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree3 { get; set; }

    [Column("min_degree_3", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree3 { get; set; }

    [Column("max_degree_3", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree3 { get; set; }

    [Column("exam_ratio_3", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio3 { get; set; }

    [Column("alow_degree_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree3 { get; set; }

    [Column("approve_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve3 { get; set; }

    [Column("posted_3")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted3 { get; set; }

    [Column("degree_4", TypeName = "decimal(18, 3)")]
    public decimal? Degree4 { get; set; }

    [Column("default_degree_4", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree4 { get; set; }

    [Column("min_degree_4", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree4 { get; set; }

    [Column("max_degree_4", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree4 { get; set; }

    [Column("exam_ratio_4", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio4 { get; set; }

    [Column("alow_degree_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree4 { get; set; }

    [Column("approve_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve4 { get; set; }

    [Column("posted_4")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted4 { get; set; }

    [Column("degree_5", TypeName = "decimal(18, 3)")]
    public decimal? Degree5 { get; set; }

    [Column("default_degree_5", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree5 { get; set; }

    [Column("min_degree_5", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree5 { get; set; }

    [Column("max_degree_5", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree5 { get; set; }

    [Column("exam_ratio_5", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio5 { get; set; }

    [Column("alow_degree_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree5 { get; set; }

    [Column("approve_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve5 { get; set; }

    [Column("posted_5")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted5 { get; set; }

    [Column("degree_6", TypeName = "decimal(18, 3)")]
    public decimal? Degree6 { get; set; }

    [Column("default_degree_6", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree6 { get; set; }

    [Column("min_degree_6", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree6 { get; set; }

    [Column("max_degree_6", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree6 { get; set; }

    [Column("exam_ratio_6", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio6 { get; set; }

    [Column("alow_degree_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree6 { get; set; }

    [Column("approve_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve6 { get; set; }

    [Column("posted_6")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted6 { get; set; }

    [Column("degree_7", TypeName = "decimal(18, 3)")]
    public decimal? Degree7 { get; set; }

    [Column("default_degree_7", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree7 { get; set; }

    [Column("min_degree_7", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree7 { get; set; }

    [Column("max_degree_7", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree7 { get; set; }

    [Column("exam_ratio_7", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio7 { get; set; }

    [Column("alow_degree_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree7 { get; set; }

    [Column("approve_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve7 { get; set; }

    [Column("posted_7")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted7 { get; set; }

    [Column("degree_8", TypeName = "decimal(18, 3)")]
    public decimal? Degree8 { get; set; }

    [Column("default_degree_8", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree8 { get; set; }

    [Column("min_degree_8", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree8 { get; set; }

    [Column("max_degree_8", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree8 { get; set; }

    [Column("exam_ratio_8", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio8 { get; set; }

    [Column("alow_degree_8")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree8 { get; set; }

    [Column("approve_8")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve8 { get; set; }

    [Column("posted_8")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted8 { get; set; }

    [Column("degree_9", TypeName = "decimal(18, 3)")]
    public decimal? Degree9 { get; set; }

    [Column("default_degree_9", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree9 { get; set; }

    [Column("min_degree_9", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree9 { get; set; }

    [Column("max_degree_9", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree9 { get; set; }

    [Column("exam_ratio_9", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio9 { get; set; }

    [Column("alow_degree_9")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree9 { get; set; }

    [Column("approve_9")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve9 { get; set; }

    [Column("posted_9")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted9 { get; set; }

    [Column("degree_10", TypeName = "decimal(18, 3)")]
    public decimal? Degree10 { get; set; }

    [Column("default_degree_10", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree10 { get; set; }

    [Column("min_degree_10", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree10 { get; set; }

    [Column("max_degree_10", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree10 { get; set; }

    [Column("exam_ratio_10", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio10 { get; set; }

    [Column("alow_degree_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree10 { get; set; }

    [Column("approve_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve10 { get; set; }

    [Column("posted_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted10 { get; set; }

    [Column("degree_11", TypeName = "decimal(18, 3)")]
    public decimal? Degree11 { get; set; }

    [Column("default_degree_11", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree11 { get; set; }

    [Column("min_degree_11", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree11 { get; set; }

    [Column("max_degree_11", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree11 { get; set; }

    [Column("exam_ratio_11", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio11 { get; set; }

    [Column("alow_degree_11")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree11 { get; set; }

    [Column("approve_11")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve11 { get; set; }

    [Column("posted_11")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted11 { get; set; }

    [Column("degree_12", TypeName = "decimal(18, 3)")]
    public decimal? Degree12 { get; set; }

    [Column("default_degree_12", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree12 { get; set; }

    [Column("min_degree_12", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree12 { get; set; }

    [Column("max_degree_12", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree12 { get; set; }

    [Column("exam_ratio_12", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio12 { get; set; }

    [Column("alow_degree_12")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree12 { get; set; }

    [Column("approve_12")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve12 { get; set; }

    [Column("posted_12")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted12 { get; set; }

    [Column("degree_13", TypeName = "decimal(18, 3)")]
    public decimal? Degree13 { get; set; }

    [Column("default_degree_13", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree13 { get; set; }

    [Column("min_degree_13", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree13 { get; set; }

    [Column("max_degree_13", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree13 { get; set; }

    [Column("exam_ratio_13", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio13 { get; set; }

    [Column("alow_degree_13")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree13 { get; set; }

    [Column("approve_13")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve13 { get; set; }

    [Column("posted_13")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted13 { get; set; }

    [Column("degree_14", TypeName = "decimal(18, 3)")]
    public decimal? Degree14 { get; set; }

    [Column("default_degree_14", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree14 { get; set; }

    [Column("min_degree_14", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree14 { get; set; }

    [Column("max_degree_14", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree14 { get; set; }

    [Column("exam_ratio_14", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio14 { get; set; }

    [Column("alow_degree_14")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree14 { get; set; }

    [Column("approve_14")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve14 { get; set; }

    [Column("posted_14")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted14 { get; set; }

    [Column("degree_15", TypeName = "decimal(18, 3)")]
    public decimal? Degree15 { get; set; }

    [Column("default_degree_15", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree15 { get; set; }

    [Column("min_degree_15", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree15 { get; set; }

    [Column("max_degree_15", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree15 { get; set; }

    [Column("exam_ratio_15", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio15 { get; set; }

    [Column("alow_degree_15")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree15 { get; set; }

    [Column("approve_15")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve15 { get; set; }

    [Column("posted_15")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted15 { get; set; }

    [Column("degree_16", TypeName = "decimal(18, 3)")]
    public decimal? Degree16 { get; set; }

    [Column("default_degree_16", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree16 { get; set; }

    [Column("min_degree_16", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree16 { get; set; }

    [Column("max_degree_16", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree16 { get; set; }

    [Column("exam_ratio_16", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio16 { get; set; }

    [Column("alow_degree_16")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree16 { get; set; }

    [Column("approve_16")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve16 { get; set; }

    [Column("posted_16")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted16 { get; set; }

    [Column("degree_17", TypeName = "decimal(18, 3)")]
    public decimal? Degree17 { get; set; }

    [Column("default_degree_17", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree17 { get; set; }

    [Column("min_degree_17", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree17 { get; set; }

    [Column("max_degree_17", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree17 { get; set; }

    [Column("exam_ratio_17", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio17 { get; set; }

    [Column("alow_degree_17")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree17 { get; set; }

    [Column("approve_17")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve17 { get; set; }

    [Column("posted_17")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted17 { get; set; }

    [Column("degree_18", TypeName = "decimal(18, 3)")]
    public decimal? Degree18 { get; set; }

    [Column("default_degree_18", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree18 { get; set; }

    [Column("min_degree_18", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree18 { get; set; }

    [Column("max_degree_18", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree18 { get; set; }

    [Column("exam_ratio_18", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio18 { get; set; }

    [Column("alow_degree_18")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree18 { get; set; }

    [Column("approve_18")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve18 { get; set; }

    [Column("posted_18")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted18 { get; set; }

    [Column("degree_19", TypeName = "decimal(18, 3)")]
    public decimal? Degree19 { get; set; }

    [Column("default_degree_19", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree19 { get; set; }

    [Column("min_degree_19", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree19 { get; set; }

    [Column("max_degree_19", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree19 { get; set; }

    [Column("exam_ratio_19", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio19 { get; set; }

    [Column("alow_degree_19")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree19 { get; set; }

    [Column("approve_19")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve19 { get; set; }

    [Column("posted_19")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted19 { get; set; }

    [Column("degree_20", TypeName = "decimal(18, 3)")]
    public decimal? Degree20 { get; set; }

    [Column("default_degree_20", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree20 { get; set; }

    [Column("min_degree_20", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree20 { get; set; }

    [Column("max_degree_20", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree20 { get; set; }

    [Column("exam_ratio_20", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio20 { get; set; }

    [Column("alow_degree_20")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree20 { get; set; }

    [Column("approve_20")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve20 { get; set; }

    [Column("posted_20")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted20 { get; set; }

    [Column("degree_21", TypeName = "decimal(18, 3)")]
    public decimal? Degree21 { get; set; }

    [Column("default_degree_21", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree21 { get; set; }

    [Column("min_degree_21", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree21 { get; set; }

    [Column("max_degree_21", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree21 { get; set; }

    [Column("exam_ratio_21", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio21 { get; set; }

    [Column("alow_degree_21")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree21 { get; set; }

    [Column("approve_21")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve21 { get; set; }

    [Column("posted_21")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted21 { get; set; }

    [Column("degree_22", TypeName = "decimal(18, 3)")]
    public decimal? Degree22 { get; set; }

    [Column("default_degree_22", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree22 { get; set; }

    [Column("min_degree_22", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree22 { get; set; }

    [Column("max_degree_22", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree22 { get; set; }

    [Column("exam_ratio_22", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio22 { get; set; }

    [Column("alow_degree_22")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree22 { get; set; }

    [Column("approve_22")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve22 { get; set; }

    [Column("posted_22")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted22 { get; set; }

    [Column("degree_23", TypeName = "decimal(18, 3)")]
    public decimal? Degree23 { get; set; }

    [Column("default_degree_23", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree23 { get; set; }

    [Column("min_degree_23", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree23 { get; set; }

    [Column("max_degree_23", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree23 { get; set; }

    [Column("exam_ratio_23", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio23 { get; set; }

    [Column("alow_degree_23")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree23 { get; set; }

    [Column("approve_23")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve23 { get; set; }

    [Column("posted_23")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted23 { get; set; }

    [Column("degree_24", TypeName = "decimal(18, 3)")]
    public decimal? Degree24 { get; set; }

    [Column("default_degree_24", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree24 { get; set; }

    [Column("min_degree_24", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree24 { get; set; }

    [Column("max_degree_24", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree24 { get; set; }

    [Column("exam_ratio_24", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio24 { get; set; }

    [Column("alow_degree_24")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree24 { get; set; }

    [Column("approve_24")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve24 { get; set; }

    [Column("posted_24")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted24 { get; set; }

    [Column("degree_25", TypeName = "decimal(18, 3)")]
    public decimal? Degree25 { get; set; }

    [Column("default_degree_25", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree25 { get; set; }

    [Column("min_degree_25", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree25 { get; set; }

    [Column("max_degree_25", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree25 { get; set; }

    [Column("exam_ratio_25", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio25 { get; set; }

    [Column("alow_degree_25")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree25 { get; set; }

    [Column("approve_25")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve25 { get; set; }

    [Column("posted_25")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted25 { get; set; }

    [Column("degree_26", TypeName = "decimal(18, 3)")]
    public decimal? Degree26 { get; set; }

    [Column("default_degree_26", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree26 { get; set; }

    [Column("min_degree_26", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree26 { get; set; }

    [Column("max_degree_26", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree26 { get; set; }

    [Column("exam_ratio_26", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio26 { get; set; }

    [Column("alow_degree_26")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree26 { get; set; }

    [Column("approve_26")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve26 { get; set; }

    [Column("posted_26")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted26 { get; set; }

    [Column("degree_27", TypeName = "decimal(18, 3)")]
    public decimal? Degree27 { get; set; }

    [Column("default_degree_27", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree27 { get; set; }

    [Column("min_degree_27", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree27 { get; set; }

    [Column("max_degree_27", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree27 { get; set; }

    [Column("exam_ratio_27", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio27 { get; set; }

    [Column("alow_degree_27")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree27 { get; set; }

    [Column("approve_27")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve27 { get; set; }

    [Column("posted_27")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted27 { get; set; }

    [Column("degree_28", TypeName = "decimal(18, 3)")]
    public decimal? Degree28 { get; set; }

    [Column("default_degree_28", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree28 { get; set; }

    [Column("min_degree_28", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree28 { get; set; }

    [Column("max_degree_28", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree28 { get; set; }

    [Column("exam_ratio_28", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio28 { get; set; }

    [Column("alow_degree_28")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree28 { get; set; }

    [Column("approve_28")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve28 { get; set; }

    [Column("posted_28")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted28 { get; set; }

    [Column("degree_29", TypeName = "decimal(18, 3)")]
    public decimal? Degree29 { get; set; }

    [Column("default_degree_29", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree29 { get; set; }

    [Column("min_degree_29", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree29 { get; set; }

    [Column("max_degree_29", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree29 { get; set; }

    [Column("exam_ratio_29", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio29 { get; set; }

    [Column("alow_degree_29")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree29 { get; set; }

    [Column("approve_29")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve29 { get; set; }

    [Column("posted_29")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted29 { get; set; }

    [Column("degree_30", TypeName = "decimal(18, 3)")]
    public decimal? Degree30 { get; set; }

    [Column("default_degree_30", TypeName = "decimal(18, 3)")]
    public decimal? DefaultDegree30 { get; set; }

    [Column("min_degree_30", TypeName = "decimal(18, 3)")]
    public decimal? MinDegree30 { get; set; }

    [Column("max_degree_30", TypeName = "decimal(18, 3)")]
    public decimal? MaxDegree30 { get; set; }

    [Column("exam_ratio_30", TypeName = "decimal(18, 3)")]
    public decimal? ExamRatio30 { get; set; }

    [Column("alow_degree_30")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AlowDegree30 { get; set; }

    [Column("approve_30")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Approve30 { get; set; }

    [Column("posted_30")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Posted30 { get; set; }
}
