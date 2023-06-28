using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("pos_customer")]
public partial class PosCustomer
{
    [Key]
    [Column("id", TypeName = "decimal(18, 0)")]
    public decimal Id { get; set; }

    [Column("code")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Code { get; set; }

    [Column("name_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Name1 { get; set; }

    [Column("name_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Name2 { get; set; }

    [Column("cust_cat_id", TypeName = "decimal(18, 0)")]
    public decimal? CustCatId { get; set; }

    [Column("area")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Area { get; set; }

    [Column("block")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Block { get; set; }

    [Column("street")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Street { get; set; }

    [Column("avenue")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Avenue { get; set; }

    [Column("build")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Build { get; set; }

    [Column("floor")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Floor { get; set; }

    [Column("flat")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Flat { get; set; }

    [Column("adderes")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Adderes { get; set; }

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

    [Column("email")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Email { get; set; }

    [Column("creation_by", TypeName = "decimal(18, 0)")]
    public decimal? CreationBy { get; set; }

    [Column("creation_date", TypeName = "datetime")]
    public DateTime? CreationDate { get; set; }

    [Column("chang_by", TypeName = "decimal(18, 0)")]
    public decimal? ChangBy { get; set; }

    [Column("chang_date", TypeName = "datetime")]
    public DateTime? ChangDate { get; set; }

    [Column("notes")]
    [StringLength(255)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("data_1")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Data1 { get; set; }

    [Column("data_2")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Data2 { get; set; }

    [Column("data_3")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Data3 { get; set; }

    [Column("data_4")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Data4 { get; set; }

    [Column("data_5")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Data5 { get; set; }

    [Column("data_6")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Data6 { get; set; }

    [Column("data_7")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Data7 { get; set; }

    [Column("data_8")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Data8 { get; set; }

    [Column("data_9")]
    [StringLength(50)]
    [Unicode(false)]
    public string? Data9 { get; set; }

    [Column("anniversay_date", TypeName = "datetime")]
    public DateTime? AnniversayDate { get; set; }

    [Column("birth_date", TypeName = "datetime")]
    public DateTime? BirthDate { get; set; }

    [Column("marital_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? MaritalStatus { get; set; }

    [Column("cust_type")]
    [StringLength(1)]
    [Unicode(false)]
    public string? CustType { get; set; }

    [Column("vip")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Vip { get; set; }

    [Column("room_no")]
    [StringLength(50)]
    [Unicode(false)]
    public string? RoomNo { get; set; }

    [Column("reg_resp_id", TypeName = "decimal(18, 0)")]
    public decimal? RegRespId { get; set; }
}
