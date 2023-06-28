namespace Creative.Shared.Models;

public class ExamEditModel
{
    public decimal Id { get; set; }
    public string? Code { get; set; }
    public string? Name1 { get; set; }
    public string? Name2 { get; set; }
    public decimal? Degree { get; set; }
    public string? Notes { get; set; }
    public decimal? TypeId { get; set; }
    public DateOnly ExmStartTime { get; set; }
    public CRUDAction Action { get; set; }
}

public enum CRUDAction
{
    Add,
    Edit,
    Delete
}
