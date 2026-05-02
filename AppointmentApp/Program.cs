using AppointmentApp.Controller;
using AppointmentApp.Model;
using AppointmentApp.View;
using Microsoft.EntityFrameworkCore;

namespace AppointmentApp;

static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        try
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer(AppDbContext.ConnectionString)
                .Options;

            var db = new AppDbContext(options);
            db.Database.EnsureCreated();
            DemoDataSeeder.Seed(db);

            var currentUserId = "u01";
            var calendar = new Calendar(db, currentUserId);
            var groupRepo = new GroupMeetingRepository(db);
            var controller = new AppointmentController(calendar, groupRepo, currentUserId);

            Application.ApplicationExit += (_, _) => db.Dispose();
            Application.Run(new CalendarUI(controller, currentUserId));
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.ToString(), "Startup Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}