using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("prty_member")]
public partial class PrtyMember
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

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("sex")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Sex { get; set; }

    [Column("serial")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Serial { get; set; }

    [Column("member_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MemberNo { get; set; }

    [Column("id_no")]
    [StringLength(14)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("tel_1")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("tel_3")]
    [StringLength(15)]
    [Unicode(false)]
    public string? Tel3 { get; set; }

    [Column("qualification")]
    [StringLength(2)]
    [Unicode(false)]
    public string? Qualification { get; set; }

    [Column("specialization_id", TypeName = "decimal(18, 0)")]
    public decimal? SpecializationId { get; set; }

    [Column("job")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Job { get; set; }

    [Column("job_id", TypeName = "decimal(18, 0)")]
    public decimal? JobId { get; set; }

    [Column("gover_id", TypeName = "decimal(18, 0)")]
    public decimal? GoverId { get; set; }

    [Column("section_id", TypeName = "decimal(18, 0)")]
    public decimal? SectionId { get; set; }

    [Column("district_id", TypeName = "decimal(18, 0)")]
    public decimal? DistrictId { get; set; }

    [Column("area_id", TypeName = "decimal(18, 0)")]
    public decimal? AreaId { get; set; }

    [Column("street")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Street { get; set; }

    [Column("home")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Home { get; set; }

    [Column("flat")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Flat { get; set; }

    [Column("address")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("email")]
    [StringLength(200)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("department")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Department { get; set; }

    [Column("son_name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SonName1 { get; set; }

    [Column("son_birth_date_1", TypeName = "datetime")]
    public DateTime? SonBirthDate1 { get; set; }

    [Column("son_hobby_id1_1", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId11 { get; set; }

    [Column("son_hobby_id2_1", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId21 { get; set; }

    [Column("son_hobby_id3_1", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId31 { get; set; }

    [Column("son_name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SonName2 { get; set; }

    [Column("son_birth_date_2", TypeName = "datetime")]
    public DateTime? SonBirthDate2 { get; set; }

    [Column("son_hobby_id1_2", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId12 { get; set; }

    [Column("son_hobby_id2_2", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId22 { get; set; }

    [Column("son_hobby_id3_2", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId32 { get; set; }

    [Column("son_name_3")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SonName3 { get; set; }

    [Column("son_birth_date_3", TypeName = "datetime")]
    public DateTime? SonBirthDate3 { get; set; }

    [Column("son_hobby_id1_3", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId13 { get; set; }

    [Column("son_hobby_id2_3", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId23 { get; set; }

    [Column("son_hobby_id3_3", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId33 { get; set; }

    [Column("son_name_4")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SonName4 { get; set; }

    [Column("son_birth_date_4", TypeName = "datetime")]
    public DateTime? SonBirthDate4 { get; set; }

    [Column("son_hobby_id1_4", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId14 { get; set; }

    [Column("son_hobby_id2_4", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId24 { get; set; }

    [Column("son_hobby_id3_4", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId34 { get; set; }

    [Column("son_name_5")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SonName5 { get; set; }

    [Column("son_birth_date_5", TypeName = "datetime")]
    public DateTime? SonBirthDate5 { get; set; }

    [Column("son_hobby_id1_5", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId15 { get; set; }

    [Column("son_hobby_id2_5", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId25 { get; set; }

    [Column("son_hobby_id3_5", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId35 { get; set; }

    [Column("son_name_6")]
    [StringLength(100)]
    [Unicode(false)]
    public string? SonName6 { get; set; }

    [Column("son_birth_date_6", TypeName = "datetime")]
    public DateTime? SonBirthDate6 { get; set; }

    [Column("son_hobby_id1_6", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId16 { get; set; }

    [Column("son_hobby_id2_6", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId26 { get; set; }

    [Column("son_hobby_id3_6", TypeName = "decimal(18, 0)")]
    public decimal? SonHobbyId36 { get; set; }

    [Column("subscribe_2011_doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Subscribe2011DocNo { get; set; }

    [Column("subscribe_2011_amount", TypeName = "decimal(18, 3)")]
    public decimal? Subscribe2011Amount { get; set; }

    [Column("subscribe_2012_doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Subscribe2012DocNo { get; set; }

    [Column("subscribe_2012_amount", TypeName = "decimal(18, 3)")]
    public decimal? Subscribe2012Amount { get; set; }

    [Column("subscribe_2013_doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Subscribe2013DocNo { get; set; }

    [Column("subscribe_2013_amount", TypeName = "decimal(18, 3)")]
    public decimal? Subscribe2013Amount { get; set; }

    [Column("subscribe_2014_doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Subscribe2014DocNo { get; set; }

    [Column("subscribe_2014_amount", TypeName = "decimal(18, 3)")]
    public decimal? Subscribe2014Amount { get; set; }

    [Column("subscribe_2015_doc_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Subscribe2015DocNo { get; set; }

    [Column("subscribe_2015_amount", TypeName = "decimal(18, 3)")]
    public decimal? Subscribe2015Amount { get; set; }

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
