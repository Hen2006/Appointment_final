namespace AppointmentApp.Model;

public class Appointment
{
    public string AppId { get; set; } = Guid.NewGuid().ToString("N");
    public string Name { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public string? OwnerUserId { get; set; }
    public List<Reminder> Reminders { get; set; } = new();

    public int GetDuration()
    {
        return (int)Math.Max(0, (EndTime - StartTime).TotalMinutes);
    }

    public void AddReminder(Reminder rem)
    {
        Reminders.Add(rem);
    }
}
