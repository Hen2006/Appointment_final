using AppointmentApp.Model;

namespace AppointmentApp.Controller;

public enum SubmitStatus
{
    ValidationError,
    Conflict,
    SuggestGroup,
    Success
}

public sealed class SubmitResult
{
    public SubmitStatus Status { get; }
    public string Message { get; }
    public Appointment? ConflictingAppointment { get; }
    public GroupMeeting? SuggestedGroup { get; }
    public Appointment? CreatedAppointment { get; }

    private SubmitResult(
        SubmitStatus status,
        string message = "",
        Appointment? conflicting = null,
        GroupMeeting? suggestedGroup = null,
        Appointment? createdAppointment = null)
    {
        Status = status;
        Message = message;
        ConflictingAppointment = conflicting;
        SuggestedGroup = suggestedGroup;
        CreatedAppointment = createdAppointment;
    }

    public static SubmitResult ValidationError(string message)
    {
        return new SubmitResult(SubmitStatus.ValidationError, message);
    }

    public static SubmitResult Conflict(Appointment conflicting)
    {
        return new SubmitResult(SubmitStatus.Conflict, "Conflict detected.", conflicting);
    }

    public static SubmitResult SuggestGroup(GroupMeeting groupMeeting)
    {
        return new SubmitResult(SubmitStatus.SuggestGroup, "Matching group meeting found.", null, groupMeeting);
    }

    public static SubmitResult Success(Appointment created, string message)
    {
        return new SubmitResult(SubmitStatus.Success, message, null, null, created);
    }
}
