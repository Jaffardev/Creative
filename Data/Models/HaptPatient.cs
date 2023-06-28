using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hapt_patient")]
public partial class HaptPatient
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("doc_id", TypeName = "decimal(18, 0)")]
    public decimal? DocId { get; set; }

    [Column("name_1")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("file_no")]
    [StringLength(100)]
    [Unicode(false)]
    public string? FileNo { get; set; }

    [Column("id_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IdNo { get; set; }

    [Column("id_no_photo")]
    [StringLength(500)]
    [Unicode(false)]
    public string? IdNoPhoto { get; set; }

    [Column("gender")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Gender { get; set; }

    [Column("nationality")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Nationality { get; set; }

    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("marital_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MaritalStatus { get; set; }

    [Column("relegion")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Relegion { get; set; }

    [Column("address")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Address { get; set; }

    [Column("area")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Area { get; set; }

    [Column("block")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Block { get; set; }

    [Column("street")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Street { get; set; }

    [Column("gada")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Gada { get; set; }

    [Column("building")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Building { get; set; }

    [Column("tel_1")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Tel1 { get; set; }

    [Column("tel_2")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Tel2 { get; set; }

    [Column("mobile")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Mobile { get; set; }

    [Column("trans_date", TypeName = "datetime")]
    public DateTime? TransDate { get; set; }

    [Column("relation")]
    [StringLength(20)]
    [Unicode(false)]
    public string? Relation { get; set; }

    [Column("write_data")]
    [StringLength(100)]
    [Unicode(false)]
    public string? WriteData { get; set; }

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("email")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("refferal_doc")]
    [StringLength(500)]
    [Unicode(false)]
    public string? RefferalDoc { get; set; }

    [Column("mother_name")]
    [StringLength(100)]
    [Unicode(false)]
    public string? MotherName { get; set; }

    [Column("mother_id_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MotherIdNo { get; set; }

    [Column("mother_address")]
    [StringLength(100)]
    [Unicode(false)]
    public string? MotherAddress { get; set; }

    [Column("mother_area")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MotherArea { get; set; }

    [Column("mother_block")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MotherBlock { get; set; }

    [Column("mother_street")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MotherStreet { get; set; }

    [Column("mother_gada")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MotherGada { get; set; }

    [Column("mother_building")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MotherBuilding { get; set; }

    [Column("mother_tel_1")]
    [StringLength(20)]
    [Unicode(false)]
    public string? MotherTel1 { get; set; }

    [Column("mother_tel_2")]
    [StringLength(20)]
    [Unicode(false)]
    public string? MotherTel2 { get; set; }

    [Column("mother_mobile")]
    [StringLength(20)]
    [Unicode(false)]
    public string? MotherMobile { get; set; }

    [Column("mother_notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? MotherNotes { get; set; }

    [Column("active")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Active { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("modify_by", TypeName = "decimal(18, 0)")]
    public decimal? ModifyBy { get; set; }

    [Column("modify_date", TypeName = "datetime")]
    public DateTime? ModifyDate { get; set; }
}
