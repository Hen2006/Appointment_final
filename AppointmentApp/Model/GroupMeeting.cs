using System.ComponentModel.DataAnnotations.Schema;

namespace AppointmentApp.Model;

public class GroupMeeting : Appointment
{
    public int MaxCapacity { get; set; } = 20;
    public List<User> Participants { get; set; } = new();

    [NotMapped]
    public string GroupId => AppId;

    public void AddParticipant(User user)
    {
        if (IsFull())
        {
            throw new InvalidOperationException("Group meeting is full.");
        }

        if (Participants.All(p => p.UserId != user.UserId))
        {
            Participants.Add(user);
        }
    }

    public bool IsFull()
    {
        return Participants.Count >= MaxCapacity;
    }

    public int GetParticipantCount()
    {
        return Participants.Count;
    }
}
