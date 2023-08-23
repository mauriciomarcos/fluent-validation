using Domains.Interfaces.Services.Bases;

namespace Application.Services.Bases;

public class Notification : INotification
{
    public string Code { get; set; }
    public string Description { get; set; }

    public Notification(string code, string description)
    {
        Code = code;
        Description = description;
    }
}