using Application.Notifications;

namespace Application.Services;

public class ServiceResponseBase
{
    private readonly List<Notification> _notifications;

    public object? ResponseData { get; private set; }
    public bool HasNotifications => _notifications.Any();
    public IReadOnlyCollection<Notification> Notifications => _notifications;


    public ServiceResponseBase() => _notifications ??= new List<Notification>();


    public void SetResponseData<T>(T response) where T : class => ResponseData = response;

    public void AddNotification(string code, string description) => _notifications.Add(new Notification(code, description));

    public IReadOnlyCollection<Notification> GetErrors() => Notifications;
}