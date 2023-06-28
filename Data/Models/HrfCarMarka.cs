using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("hrf_car_marka")]
public partial class HrfCarMarka
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

    [Column("desc_1")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Desc1 { get; set; }

    [Column("desc_2")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Desc2 { get; set; }

    [Column("desc_3")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Desc3 { get; set; }

    [Column("desc_4")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Desc4 { get; set; }

    [Column("desc_5")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Desc5 { get; set; }

    [Column("desc_6")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Desc6 { get; set; }

    [Column("desc_7")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Desc7 { get; set; }

    [Column("desc_8")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Desc8 { get; set; }

    [Column("desc_9")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Desc9 { get; set; }

    [Column("desc_10")]
    [StringLength(1000)]
    [Unicode(false)]
    public string? Desc10 { get; set; }

    [Column("cont_status")]
    [StringLength(1)]
    [Unicode(false)]
    public string? ContStatus { get; set; }

    [Column("ven_recived_by")]
    [StringLength(100)]
    [Unicode(false)]
    public string? VenRecivedBy { get; set; }

    [Column("ven_recived_date", TypeName = "datetime")]
    public DateTime? VenRecivedDate { get; set; }

    [Column("ven_recived_time", TypeName = "datetime")]
    public DateTime? VenRecivedTime { get; set; }

    [Column("cust_recived_by")]
    [StringLength(100)]
    [Unicode(false)]
    public string? CustRecivedBy { get; set; }

    [Column("cust_recived_date", TypeName = "datetime")]
    public DateTime? CustRecivedDate { get; set; }

    [Column("cust_recived_time", TypeName = "datetime")]
    public DateTime? CustRecivedTime { get; set; }
}
