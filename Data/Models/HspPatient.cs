using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hsp_patient")]
public partial class HspPatient
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

    [Column("name_1_1")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name11 { get; set; }

    [Column("name_1_2")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name12 { get; set; }

    [Column("name_1_3")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name13 { get; set; }

    [Column("name_1_4")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name14 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("name_2_1")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name21 { get; set; }

    [Column("name_2_2")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name22 { get; set; }

    [Column("name_2_3")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name23 { get; set; }

    [Column("name_2_4")]
    [StringLength(25)]
    [Unicode(false)]
    public string? Name24 { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("address")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("gender")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column("nationality_id", TypeName = "decimal(18, 0)")]
    public decimal? NationalityId { get; set; }

    [Column("group_id", TypeName = "decimal(18, 0)")]
    public decimal? GroupId { get; set; }

    [Column("insurance_id", TypeName = "decimal(18, 0)")]
    public decimal? InsuranceId { get; set; }

    [Column("allergies_id", TypeName = "decimal(18, 0)")]
    public decimal? AllergiesId { get; set; }

    [Column("clinic_id", TypeName = "decimal(18, 0)")]
    public decimal? ClinicId { get; set; }

    [Column("doctor_id", TypeName = "decimal(18, 0)")]
    public decimal? DoctorId { get; set; }

    [Column("relegion_id", TypeName = "decimal(18, 0)")]
    public decimal? RelegionId { get; set; }

    [Column("area_id", TypeName = "decimal(18, 0)")]
    public decimal? AreaId { get; set; }

    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("mobile_1")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Mobile1 { get; set; }

    [Column("mobile_2")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Mobile2 { get; set; }

    [Column("mobile_3")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Mobile3 { get; set; }

    [Column("mobile_4")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Mobile4 { get; set; }

    [Column("fax")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Fax { get; set; }

    [Column("office")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Office { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("lab_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? LabNo { get; set; }

    [Column("id_no")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("job_id", TypeName = "decimal(18, 0)")]
    public decimal? JobId { get; set; }

    [Column("complaints_en")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ComplaintsEn { get; set; }

    [Column("complaints_ar")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? ComplaintsAr { get; set; }

    [Column("reg_date", TypeName = "datetime")]
    public DateTime? RegDate { get; set; }

    [Column("open_amt", TypeName = "decimal(18, 3)")]
    public decimal? OpenAmt { get; set; }

    [Column("treatment_amt", TypeName = "decimal(18, 3)")]
    public decimal? TreatmentAmt { get; set; }

    [Column("blood_group")]
    [StringLength(1)]
    [Unicode(false)]
    public string? BloodGroup { get; set; }

    [Column("birth_place")]
    [StringLength(20)]
    [Unicode(false)]
    public string? BirthPlace { get; set; }

    [Column("weight", TypeName = "decimal(18, 3)")]
    public decimal? Weight { get; set; }

    [Column("father_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? FatherName { get; set; }

    [Column("mother_name")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MotherName { get; set; }

    [Column("diseases")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Diseases { get; set; }

    [Column("user_id", TypeName = "decimal(18, 0)")]
    public decimal? UserId { get; set; }

    [Column("notes_2")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes2 { get; set; }

    [Column("notes_3")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes3 { get; set; }

    [Column("rh")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Rh { get; set; }

    [Column("other_places")]
    [StringLength(100)]
    [Unicode(false)]
    public string? OtherPlaces { get; set; }

    [Column("consanguinity")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Consanguinity { get; set; }

    [Column("reffering")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Reffering { get; set; }

    [Column("reffering_other")]
    [StringLength(255)]
    [Unicode(false)]
    public string? RefferingOther { get; set; }

    [Column("data_by")]
    [StringLength(100)]
    [Unicode(false)]
    public string? DataBy { get; set; }

    [Column("insurance_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? InsuranceStatus { get; set; }

    [Column("patient_ratio", TypeName = "decimal(18, 3)")]
    public decimal? PatientRatio { get; set; }

    [Column("insurance_ratio", TypeName = "decimal(18, 3)")]
    public decimal? InsuranceRatio { get; set; }

    [Column("patient_discount", TypeName = "decimal(18, 3)")]
    public decimal? PatientDiscount { get; set; }

    [Column("insurance_discount", TypeName = "decimal(18, 3)")]
    public decimal? InsuranceDiscount { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }

    [Column("patient_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? PatientStatus { get; set; }

    [Column("price_list_id", TypeName = "decimal(18, 0)")]
    public decimal? PriceListId { get; set; }
}
