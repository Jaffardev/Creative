using System.ComponentModel.DataAnnotations;

namespace Creative.Shared.Models;

public class ExamEditModel
{
    public decimal Id { get; set; }

    [Required]
    public string Code { get; set; } = null!;
    public decimal? StuId { get; set; }
    [Required]
    public decimal? Degree { get; set; }
    public string? Notes { get; set; }

    public State State { get; set; } = State.Read;
    public ScheduleItem Schedule { get; set; } = null!;
    /// <summary>
    /// Overriding Equals is essential for use with Select and Table because they use HashSets internally
    /// </summary>
    public override bool Equals(object obj) => object.Equals(GetHashCode(), obj?.GetHashCode());

    /// <summary>
    /// Overriding GetHashCode is essential for use with Select and Table because they use HashSets internally
    /// </summary>
    public override int GetHashCode() => Code?.GetHashCode() ?? 0;

    public override string ToString() => $"{Schedule.Name}";
}

public enum State
{
    Read,
    Add,
    Edit,
    Delete
}
