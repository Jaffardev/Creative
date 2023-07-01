namespace Creative.Shared.Models;

public class ExamEditModel
{
    public decimal Id { get; set; }
    public string? Code { get; set; }
    public decimal? ScheduleId { get; set; }
    public string? ScheduleName1 { get; set; }
    public decimal? StuId { get; set; }
    public decimal? Degree { get; set; }
    public string? Notes { get; set; }
    public string? Room { get; set; }
    public string? Exm { get; set; }
    public DateTime? ExmDate { get; set; }
    public CRUDAction Action { get; set; }
}

public enum CRUDAction
{
    Add,
    Edit,
    Delete
}
