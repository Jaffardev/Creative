using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("mmb_members")]
public partial class MmbMember
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

    [Column("group_id", TypeName = "decimal(18, 0)")]
    public decimal? GroupId { get; set; }

    [Column("team_id", TypeName = "decimal(18, 0)")]
    public decimal? TeamId { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("mobile")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("email")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("id_no")]
    [StringLength(15)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("birth_day", TypeName = "datetime")]
    public DateTime? BirthDay { get; set; }

    [Column("class_id", TypeName = "decimal(18, 0)")]
    public decimal? ClassId { get; set; }

    [Column("acc_id", TypeName = "decimal(18, 0)")]
    public decimal? AccId { get; set; }

    [Column("cost_id", TypeName = "decimal(18, 0)")]
    public decimal? CostId { get; set; }

    [Column("exp_id", TypeName = "decimal(18, 0)")]
    public decimal? ExpId { get; set; }

    [Column("analysis_id", TypeName = "decimal(18, 1)")]
    public decimal? AnalysisId { get; set; }

    [Column("acc_discount_id", TypeName = "decimal(18, 1)")]
    public decimal? AccDiscountId { get; set; }

    [Column("doc_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Doc1 { get; set; }

    [Column("doc_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Doc2 { get; set; }

    [Column("doc_3")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Doc3 { get; set; }

    [Column("doc_4")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Doc4 { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("blood_group")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BloodGroup { get; set; }

    [Column("photo_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Photo1 { get; set; }

    [Column("photo_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Photo2 { get; set; }

    [Column("goals")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Goals { get; set; }

    [Column("Weight_loss")]
    [StringLength(1)]
    [Unicode(false)]
    public string? WeightLoss { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Strength { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Flexibility { get; set; }

    [Column("General_Fitness")]
    [StringLength(1)]
    [Unicode(false)]
    public string? GeneralFitness { get; set; }

    [Column("Muscle_Building")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MuscleBuilding { get; set; }

    [Column("Physical_Exerciese")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PhysicalExerciese { get; set; }

    [Column("PE_Yes")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PeYes { get; set; }

    [Column("PE_No")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PeNo { get; set; }

    [Column("PE_Yes_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? PeYesText { get; set; }

    [Column("Exerciese_Past")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ExerciesePast { get; set; }

    [Column("EP_Yes")]
    [StringLength(1)]
    [Unicode(false)]
    public string? EpYes { get; set; }

    [Column("EP_No")]
    [StringLength(1)]
    [Unicode(false)]
    public string? EpNo { get; set; }

    [Column("EP_Yes_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? EpYesText { get; set; }

    [StringLength(1)]
    [Unicode(false)]
    public string? Sport { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("crossfit")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Crossfit { get; set; }

    [Column("crossfit_Yes")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CrossfitYes { get; set; }

    [Column("crossfit_No")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CrossfitNo { get; set; }

    [Column("crossfit_Yes_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? CrossfitYesText { get; set; }

    [Column("exercise_week")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ExerciseWeek { get; set; }

    [Column("exercise_from_date", TypeName = "datetime")]
    public DateTime? ExerciseFromDate { get; set; }

    [Column("exercise_to_date", TypeName = "datetime")]
    public DateTime? ExerciseToDate { get; set; }

    [Column("exercise_time")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ExerciseTime { get; set; }

    [Column("exercise_from_time", TypeName = "datetime")]
    public DateTime? ExerciseFromTime { get; set; }

    [Column("exercise_to_time", TypeName = "datetime")]
    public DateTime? ExerciseToTime { get; set; }

    [Column("medication")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Medication { get; set; }

    [Column("medication_Yes")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MedicationYes { get; set; }

    [Column("medication_No")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MedicationNo { get; set; }

    [Column("medication_Yes_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? MedicationYesText { get; set; }

    [Column("heart_problem")]
    [StringLength(1)]
    [Unicode(false)]
    public string? HeartProblem { get; set; }

    [Column("heart_problem_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? HeartProblemText { get; set; }

    [Column("high_blood")]
    [StringLength(1)]
    [Unicode(false)]
    public string? HighBlood { get; set; }

    [Column("high_blood_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? HighBloodText { get; set; }

    [Column("asthma")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Asthma { get; set; }

    [Column("asthma_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? AsthmaText { get; set; }

    [Column("surgery")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Surgery { get; set; }

    [Column("surgery_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? SurgeryText { get; set; }

    [Column("allergies")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Allergies { get; set; }

    [Column("allergies_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? AllergiesText { get; set; }

    [Column("diabetes")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Diabetes { get; set; }

    [Column("diabetes_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? DiabetesText { get; set; }

    [Column("dizziness")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Dizziness { get; set; }

    [Column("dizziness_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? DizzinessText { get; set; }

    [Column("joint_problem")]
    [StringLength(1)]
    [Unicode(false)]
    public string? JointProblem { get; set; }

    [Column("joint_problem_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? JointProblemText { get; set; }

    [Column("hernias")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Hernias { get; set; }

    [Column("hernias_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? HerniasText { get; set; }

    [Column("back_problem")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BackProblem { get; set; }

    [Column("back_problem_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? BackProblemText { get; set; }

    [Column("smoke")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Smoke { get; set; }

    [Column("smoke_Yes")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SmokeYes { get; set; }

    [Column("smoke_No")]
    [StringLength(1)]
    [Unicode(false)]
    public string? SmokeNo { get; set; }

    [Column("doctor")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Doctor { get; set; }

    [Column("doctor_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? DoctorText { get; set; }

    [Column("breathing")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Breathing { get; set; }

    [Column("breathing_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? BreathingText { get; set; }

    [Column("other_medical")]
    [StringLength(1)]
    [Unicode(false)]
    public string? OtherMedical { get; set; }

    [Column("other_medical_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? OtherMedicalText { get; set; }

    [Column("Sport_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? SportText { get; set; }

    [Column("EP_date", TypeName = "datetime")]
    public DateTime? EpDate { get; set; }

    [Column("smoke_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? SmokeText { get; set; }

    [Column("smoke_How_time", TypeName = "decimal(18, 0)")]
    public decimal? SmokeHowTime { get; set; }

    [Column("pos_cust_id", TypeName = "decimal(18, 0)")]
    public decimal? PosCustId { get; set; }
}
