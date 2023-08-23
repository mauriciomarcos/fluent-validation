namespace Application.Notifications;

public class Notification
{
    public string Code { get; set; }
    public string Description { get; set; }

    public Notification(string code, string description)
    {
        Code = code;
        Description = description;
    }
}