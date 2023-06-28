using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Keyless]
[Table("mmb_appointment")]
public partial class MmbAppointment
{
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

    [Column("notes")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes { get; set; }

    [Column("trans_day", TypeName = "datetime")]
    public DateTime? TransDay { get; set; }

    [Column("trainers_id", TypeName = "decimal(18, 0)")]
    public decimal? TrainersId { get; set; }

    [Column("from_date", TypeName = "datetime")]
    public DateTime? FromDate { get; set; }

    [Column("to_date", TypeName = "datetime")]
    public DateTime? ToDate { get; set; }

    [Column("status_01")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status01 { get; set; }

    [Column("reserve_id_01", TypeName = "decimal(18, 0)")]
    public decimal? ReserveId01 { get; set; }

    [Column("service_id_01", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId01 { get; set; }

    [Column("notes_01")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes01 { get; set; }

    [Column("status_02")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status02 { get; set; }

    [Column("reserve_id_02")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId02 { get; set; }

    [Column("service_id_02", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId02 { get; set; }

    [Column("notes_02")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes02 { get; set; }

    [Column("status_03")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status03 { get; set; }

    [Column("reserve_id_03")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId03 { get; set; }

    [Column("service_id_03", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId03 { get; set; }

    [Column("notes_03")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes03 { get; set; }

    [Column("status_04")]
    [StringLength(1)]
    [Unicode(false)]
    public string Status04 { get; set; } = null!;

    [Column("reserve_id_04")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId04 { get; set; }

    [Column("service_id_04", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId04 { get; set; }

    [Column("notes_04")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes04 { get; set; }

    [Column("status_05")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status05 { get; set; }

    [Column("reserve_id_05")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId05 { get; set; }

    [Column("service_id_05", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId05 { get; set; }

    [Column("notes_05")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes05 { get; set; }

    [Column("status_06")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status06 { get; set; }

    [Column("reserve_id_06")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId06 { get; set; }

    [Column("service_id_06", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId06 { get; set; }

    [Column("notes_06")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes06 { get; set; }

    [Column("status_07")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status07 { get; set; }

    [Column("reserve_id_07")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId07 { get; set; }

    [Column("service_id_07", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId07 { get; set; }

    [Column("notes_07")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes07 { get; set; }

    [Column("status_08")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status08 { get; set; }

    [Column("reserve_id_08")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId08 { get; set; }

    [Column("service_id_08", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId08 { get; set; }

    [Column("notes_08")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes08 { get; set; }

    [Column("status_09")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status09 { get; set; }

    [Column("reserve_id_09")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId09 { get; set; }

    [Column("service_id_09", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId09 { get; set; }

    [Column("notes_09")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes09 { get; set; }

    [Column("status_10")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status10 { get; set; }

    [Column("reserve_id_10")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId10 { get; set; }

    [Column("service_id_10", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId10 { get; set; }

    [Column("notes_10")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes10 { get; set; }

    [Column("status_11")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status11 { get; set; }

    [Column("reserve_id_11")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId11 { get; set; }

    [Column("service_id_11", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId11 { get; set; }

    [Column("notes_11")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes11 { get; set; }

    [Column("status_12")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status12 { get; set; }

    [Column("reserve_id_12")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId12 { get; set; }

    [Column("service_id_12", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId12 { get; set; }

    [Column("notes_12")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes12 { get; set; }

    [Column("status_13")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status13 { get; set; }

    [Column("reserve_id_13")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId13 { get; set; }

    [Column("service_id_13", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId13 { get; set; }

    [Column("notes_13")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes13 { get; set; }

    [Column("status_14")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status14 { get; set; }

    [Column("reserve_id_14")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId14 { get; set; }

    [Column("service_id_14", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId14 { get; set; }

    [Column("notes_14")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes14 { get; set; }

    [Column("status_15")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status15 { get; set; }

    [Column("reserve_id_15")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId15 { get; set; }

    [Column("service_id_15", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId15 { get; set; }

    [Column("notes_15")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes15 { get; set; }

    [Column("status_16")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status16 { get; set; }

    [Column("reserve_id_16")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId16 { get; set; }

    [Column("service_id_16", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId16 { get; set; }

    [Column("notes_16")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes16 { get; set; }

    [Column("status_17")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status17 { get; set; }

    [Column("reserve_id_17")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId17 { get; set; }

    [Column("service_id_17", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId17 { get; set; }

    [Column("notes_17")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes17 { get; set; }

    [Column("status_18")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status18 { get; set; }

    [Column("reserve_id_18")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId18 { get; set; }

    [Column("service_id_18", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId18 { get; set; }

    [Column("notes_18")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes18 { get; set; }

    [Column("status_19")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status19 { get; set; }

    [Column("reserve_id_19")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId19 { get; set; }

    [Column("service_id_19", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId19 { get; set; }

    [Column("notes_19")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes19 { get; set; }

    [Column("status_20")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status20 { get; set; }

    [Column("reserve_id_20")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId20 { get; set; }

    [Column("service_id_20", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId20 { get; set; }

    [Column("notes_20")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes20 { get; set; }

    [Column("status_21")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status21 { get; set; }

    [Column("reserve_id_21")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId21 { get; set; }

    [Column("service_id_21", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId21 { get; set; }

    [Column("notes_21")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes21 { get; set; }

    [Column("status_22")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status22 { get; set; }

    [Column("reserve_id_22")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId22 { get; set; }

    [Column("service_id_22", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId22 { get; set; }

    [Column("notes_22")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes22 { get; set; }

    [Column("status_23")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status23 { get; set; }

    [Column("reserve_id_23")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId23 { get; set; }

    [Column("service_id_23", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId23 { get; set; }

    [Column("notes_23")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes23 { get; set; }

    [Column("status_24")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status24 { get; set; }

    [Column("reserve_id_24")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId24 { get; set; }

    [Column("service_id_24", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId24 { get; set; }

    [Column("notes_24")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes24 { get; set; }

    [Column("status_25")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status25 { get; set; }

    [Column("reserve_id_25")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId25 { get; set; }

    [Column("service_id_25", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId25 { get; set; }

    [Column("notes_25")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes25 { get; set; }

    [Column("status_26")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status26 { get; set; }

    [Column("reserve_id_26")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId26 { get; set; }

    [Column("service_id_26", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId26 { get; set; }

    [Column("notes_26")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes26 { get; set; }

    [Column("status_27")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status27 { get; set; }

    [Column("reserve_id_27")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId27 { get; set; }

    [Column("service_id_27", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId27 { get; set; }

    [Column("notes_27")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes27 { get; set; }

    [Column("status_28")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status28 { get; set; }

    [Column("reserve_id_28")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId28 { get; set; }

    [Column("service_id_28", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId28 { get; set; }

    [Column("notes_28")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes28 { get; set; }

    [Column("status_29")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status29 { get; set; }

    [Column("reserve_id_29")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId29 { get; set; }

    [Column("service_id_29", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId29 { get; set; }

    [Column("notes_29")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes29 { get; set; }

    [Column("status_30")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status30 { get; set; }

    [Column("reserve_id_30")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId30 { get; set; }

    [Column("service_id_30", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId30 { get; set; }

    [Column("notes_30")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes30 { get; set; }

    [Column("status_31")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status31 { get; set; }

    [Column("reserve_id_31")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId31 { get; set; }

    [Column("service_id_31", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId31 { get; set; }

    [Column("notes_31")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes31 { get; set; }

    [Column("status_32")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status32 { get; set; }

    [Column("reserve_id_32")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId32 { get; set; }

    [Column("service_id_32", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId32 { get; set; }

    [Column("notes_32")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes32 { get; set; }

    [Column("status_33")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status33 { get; set; }

    [Column("reserve_id_33")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId33 { get; set; }

    [Column("service_id_33", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId33 { get; set; }

    [Column("notes_33")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes33 { get; set; }

    [Column("status_34")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status34 { get; set; }

    [Column("reserve_id_34")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId34 { get; set; }

    [Column("service_id_34", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId34 { get; set; }

    [Column("notes_34")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes34 { get; set; }

    [Column("status_35")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status35 { get; set; }

    [Column("reserve_id_35")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId35 { get; set; }

    [Column("service_id_35", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId35 { get; set; }

    [Column("notes_35")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes35 { get; set; }

    [Column("status_36")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status36 { get; set; }

    [Column("reserve_id_36")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId36 { get; set; }

    [Column("service_id_36", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId36 { get; set; }

    [Column("notes_36")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes36 { get; set; }

    [Column("status_37")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status37 { get; set; }

    [Column("reserve_id_37")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId37 { get; set; }

    [Column("service_id_37", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId37 { get; set; }

    [Column("notes_37")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes37 { get; set; }

    [Column("status_38")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status38 { get; set; }

    [Column("reserve_id_38")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId38 { get; set; }

    [Column("service_id_38", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId38 { get; set; }

    [Column("notes_38")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes38 { get; set; }

    [Column("status_39")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status39 { get; set; }

    [Column("reserve_id_39")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId39 { get; set; }

    [Column("service_id_39", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId39 { get; set; }

    [Column("notes_39")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes39 { get; set; }

    [Column("status_40")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status40 { get; set; }

    [Column("reserve_id_40")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId40 { get; set; }

    [Column("service_id_40", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId40 { get; set; }

    [Column("notes_40")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes40 { get; set; }

    [Column("status_41")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status41 { get; set; }

    [Column("reserve_id_41")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId41 { get; set; }

    [Column("service_id_41", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId41 { get; set; }

    [Column("notes_41")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes41 { get; set; }

    [Column("status_42")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status42 { get; set; }

    [Column("reserve_id_42")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId42 { get; set; }

    [Column("service_id_42", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId42 { get; set; }

    [Column("notes_42")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes42 { get; set; }

    [Column("status_43")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status43 { get; set; }

    [Column("reserve_id_43")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId43 { get; set; }

    [Column("service_id_43", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId43 { get; set; }

    [Column("notes_43")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes43 { get; set; }

    [Column("status_44")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status44 { get; set; }

    [Column("reserve_id_44")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId44 { get; set; }

    [Column("service_id_44", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId44 { get; set; }

    [Column("notes_44")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes44 { get; set; }

    [Column("status_45")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status45 { get; set; }

    [Column("reserve_id_45")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId45 { get; set; }

    [Column("service_id_45", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId45 { get; set; }

    [Column("notes_45")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes45 { get; set; }

    [Column("status_46")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status46 { get; set; }

    [Column("reserve_id_46")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId46 { get; set; }

    [Column("service_id_46", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId46 { get; set; }

    [Column("notes_46")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes46 { get; set; }

    [Column("status_47")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status47 { get; set; }

    [Column("reserve_id_47")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId47 { get; set; }

    [Column("service_id_47", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId47 { get; set; }

    [Column("notes_47")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes47 { get; set; }

    [Column("status_48")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status48 { get; set; }

    [Column("reserve_id_48")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId48 { get; set; }

    [Column("service_id_48", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId48 { get; set; }

    [Column("notes_48")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes48 { get; set; }

    [Column("status_49")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status49 { get; set; }

    [Column("reserve_id_49")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId49 { get; set; }

    [Column("service_id_49", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId49 { get; set; }

    [Column("notes_49")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes49 { get; set; }

    [Column("status_50")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Status50 { get; set; }

    [Column("reserve_id_50")]
    [StringLength(50)]
    [Unicode(false)]
    public string? ReserveId50 { get; set; }

    [Column("service_id_50", TypeName = "decimal(18, 0)")]
    public decimal? ServiceId50 { get; set; }

    [Column("notes_50")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Notes50 { get; set; }

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
