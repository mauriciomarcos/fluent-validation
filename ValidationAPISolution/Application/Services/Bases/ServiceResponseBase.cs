using Domains.Interfaces.Services.Bases;

namespace Application.Services.Bases;

public class ServiceResponseBase : IServiceResponseBase
{

    private readonly List<INotification> _notifications;

    public object? ResponseData { get; set; }
    public bool HasNotifications => _notifications.Any();
    public IReadOnlyCollection<INotification> Notifications => _notifications;

    public ServiceResponseBase() => _notifications ??= new List<INotification>();

    public void SetResponseData<T>(T response) where T : class => ResponseData = response;

    public void AddNotification(string code, string description) => _notifications.Add(new Notification(code, description));

    public IReadOnlyCollection<INotification> GetErrors() => Notifications;
}