using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("med_medical_card")]
public partial class MedMedicalCard
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

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("asmtha")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Asmtha { get; set; }

    [Column("alergic")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Alergic { get; set; }

    [Column("tonsillistis")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Tonsillistis { get; set; }

    [Column("media")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Media { get; set; }

    [Column("hearing")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Hearing { get; set; }

    [Column("eye")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Eye { get; set; }

    [Column("anemia")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Anemia { get; set; }

    [Column("skin")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Skin { get; set; }

    [Column("diabetes")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Diabetes { get; set; }

    [Column("nose")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Nose { get; set; }

    [Column("heart")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Heart { get; set; }

    [Column("chest")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Chest { get; set; }

    [Column("liver")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Liver { get; set; }

    [Column("bone")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Bone { get; set; }

    [Column("epilepsy")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Epilepsy { get; set; }

    [Column("chickenbox")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Chickenbox { get; set; }

    [Column("measles")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Measles { get; set; }

    [Column("mumps")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Mumps { get; set; }

    [Column("scarlet_fever")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ScarletFever { get; set; }

    [Column("rheumatic_fever")]
    [StringLength(1)]
    [Unicode(false)]
    public string? RheumaticFever { get; set; }

    [Column("hepatitis")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Hepatitis { get; set; }

    [Column("hepatitis_text")]
    [StringLength(50)]
    [Unicode(false)]
    public string? HepatitisText { get; set; }

    [Column("convulsions")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Convulsions { get; set; }

    [Column("convulsions_age")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ConvulsionsAge { get; set; }

    [Column("surgeries")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Surgeries { get; set; }

    [Column("surgeries_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? SurgeriesText { get; set; }

    [Column("surgeries_date", TypeName = "datetime")]
    public DateTime? SurgeriesDate { get; set; }

    [Column("accident")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Accident { get; set; }

    [Column("accident_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? AccidentText { get; set; }

    [Column("eyeglasses")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Eyeglasses { get; set; }

    [Column("eyeglasses_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? EyeglassesText { get; set; }

    [Column("medicine")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Medicine { get; set; }

    [Column("medicine_text")]
    [StringLength(500)]
    [Unicode(false)]
    public string? MedicineText { get; set; }

    [Column("medicine_photo")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? MedicinePhoto { get; set; }

    [Column("allergies")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Allergies { get; set; }

    [Column("allergies_text")]
    [StringLength(100)]
    [Unicode(false)]
    public string? AllergiesText { get; set; }

    [Column("treatment_text")]
    [StringLength(100)]
    [Unicode(false)]
    public string? TreatmentText { get; set; }

    [Column("recommendations")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Recommendations { get; set; }

    [Column("antihistamines")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Antihistamines { get; set; }

    [Column("anti_spasmodie")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AntiSpasmodie { get; set; }

    [Column("antibiotic_cream")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AntibioticCream { get; set; }

    [Column("anti_pyraties")]
    [StringLength(1)]
    [Unicode(false)]
    public string? AntiPyraties { get; set; }

    [Column("throat")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Throat { get; set; }

    [Column("cough_syrup")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CoughSyrup { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

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

    [Column("health_file")]
    [StringLength(1)]
    [Unicode(false)]
    public string? HealthFile { get; set; }

    [Column("health_file_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? HealthFileNo { get; set; }

    [Column("vaccination")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Vaccination { get; set; }

    [Column("german_measles")]
    [StringLength(1)]
    [Unicode(false)]
    public string? GermanMeasles { get; set; }

    [Column("enuresis")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Enuresis { get; set; }

    [Column("kidney_diseases")]
    [StringLength(1)]
    [Unicode(false)]
    public string? KidneyDiseases { get; set; }
}
