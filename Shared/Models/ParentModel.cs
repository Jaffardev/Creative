using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Creative.Shared.Models;

public class ParentModel
{
    [Required]
    public decimal Id { get; set; }

    [Required]
    public string? Code { get; set; }
    public string? Name11 { get; set; }
    public string? Name12 { get; set; }
    public string? Name13 { get; set; }
    public string? Name14 { get; set; }
    public string? Name21 { get; set; }
    public string? Name22 { get; set; }
    public string? Name23 { get; set; }
    public string? Name24 { get; set; }

    public string? Name2 { get; set; }
    public string? Name1 { get; set; }
    public decimal? NationalId { get; set; }
    public decimal? JobId { get; set; }

    [Required]
    public string? IdNo { get; set; }

    [Required]
    public DateTime? IdEndDate { get; set; }

    [Required]
    public string? Tel1 { get; set; }
    public string? Tel2 { get; set; }

    [Required]
    public string? Address1 { get; set; }
    public string? Notes { get; set; }
    public IEnumerable<StudentModel>? Students { get; set; }

    [JsonIgnore]
    public bool Modified { get; set; }

    public bool IsChanged(string? code)
    {
        return this.Code != code || Modified;
    }

}

public class StudentModel
{
    public int? Status { get; set; }
    public string? Section { get; set; }
    public string? Grade { get; set; }
    public string? Branch { get; set; }
    public string? Year { get; set; }
    public string? Name2 { get; set; }
    public string? Code { get; set; }
    public decimal Id { get; set; }
}


