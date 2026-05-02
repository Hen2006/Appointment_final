namespace AppointmentApp.Model;

public class Reminder
{
    public string ReminderId { get; set; } = Guid.NewGuid().ToString("N");
    public string Title { get; set; } = string.Empty;
    public DateTime ReminderTime { get; set; }

    public string? AppointmentId { get; set; }
    public Appointment? Appointment { get; set; }

    public void Trigger()
    {
        // Demo placeholder
    }

    public bool IsUpcoming()
    {
        return ReminderTime > DateTime.Now;
    }
}
