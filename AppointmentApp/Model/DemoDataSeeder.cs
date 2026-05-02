using Microsoft.EntityFrameworkCore;

namespace AppointmentApp.Model;

public static class DemoDataSeeder
{
    public static void Seed(AppDbContext db)
    {
        if (!db.Users.Any(u => u.UserId == "u01"))
        {
            db.Users.Add(new User
            {
                UserId = "u01",
                Name = "Demo User",
                Email = "u01@demo.local"
            });
        }

        if (!db.Users.Any(u => u.UserId == "u02"))
        {
            db.Users.Add(new User
            {
                UserId = "u02",
                Name = "Group Host",
                Email = "u02@demo.local"
            });
        }

        db.SaveChanges();

        if (!db.GroupMeetings.Any())
        {
            var host = db.Users.First(u => u.UserId == "u02");

            var meeting1 = new GroupMeeting
            {
                Name = "OOAD Meeting",
                Location = "Room 101",
                StartTime = DateTime.Now.AddHours(2),
                EndTime = DateTime.Now.AddHours(3),
                MaxCapacity = 10
            };
            meeting1.Participants.Add(host);

            var meeting2 = new GroupMeeting
            {
                Name = "Design Sync",
                Location = "Room 202",
                StartTime = DateTime.Now.AddHours(4),
                EndTime = DateTime.Now.AddHours(5),
                MaxCapacity = 8
            };
            meeting2.Participants.Add(host);

            db.GroupMeetings.AddRange(meeting1, meeting2);
        }

        db.SaveChanges();
    }
}
