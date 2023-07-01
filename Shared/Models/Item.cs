namespace Creative.Shared.Models
{
    public class Item
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public Identity Identity { get; set; }
        // Note: this is important so the MudSelect can compare pizzas
        public override bool Equals(object o)
        {
            var other = o as Item;
            return other?.Name == Name;
        }

        // Note: this is important too!
        public override int GetHashCode() => Name?.GetHashCode() ?? 0;

        // Implement this for the Pizza to display correctly in MudSelect
        public override string ToString() => Name;
    }

    public class AcademicLookups
    {
        public IEnumerable<Item>? Grades { get; set; }
        public IEnumerable<Item>? Branches { get; set; }
        public IEnumerable<Item>? Years { get; set; }
        public IEnumerable<Item>? Classes { get; set; }
        public long ExecutedIn { get; set; }
        public IEnumerable<Item>? Parents { get; set; }
        public IEnumerable<Item>? Religions { get; set; }
        public IEnumerable<Item>? Nationals { get; set; }
        public IEnumerable<Item>? Employees { get; set; }
        public IEnumerable<Item>? ExamTypes { get; set; }
        public IEnumerable<Item>? Jobs { get; set; }
        public IEnumerable<Item>? HandicapTypes { get; set; }

        public List<Item>? ParentsAndStudent { get; set; }
    }

    public class ScheduleItem
    {
        public decimal Id { get; set; }
        public string Name { get; set; }
        public string? Exam { get; set; }
        public string? Room { get; set; }
        public DateTime? ExamDate { get; set; }

        // Note: this is important so the MudSelect can compare pizzas
        public override bool Equals(object o)
        {
            var other = o as Item;
            return other?.Name == Name;
        }

        // Note: this is important too!
        public override int GetHashCode() => Name?.GetHashCode() ?? 0;

        // Implement this for the Pizza to display correctly in MudSelect
        public override string ToString() => Name;
    }
}
