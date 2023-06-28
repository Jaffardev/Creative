using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Creative.Data.Models;

[Table("gen_rfid")]
public partial class GenRfid
{
    [Key]
    [Column("id")]
    public int Id { get; set; }

    [Column("gateno")]
    public int? Gateno { get; set; }

    [Column("tagid")]
    [StringLength(500)]
    [Unicode(false)]
    public string? Tagid { get; set; }

    [Column("trans_date", TypeName = "date")]
    public DateTime? TransDate { get; set; }

    [Column("trans_time")]
    public TimeSpan? TransTime { get; set; }
}
