
namespace Harmony.Domain.Entities;

public class Activity : BaseEntity
{
    public string Name { get; set; } = null!;
    public List<JournalEntry> JournalEntries { get; set; } = null!;
}