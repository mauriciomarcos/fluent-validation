namespace Domains.Interfaces.Services.Bases;

public interface IServiceResponseBase
{
    object? ResponseData { get; set; }
    bool HasNotifications { get; }
    IReadOnlyCollection<INotification> Notifications { get; }

    void SetResponseData<T>(T response) where T : class;
    void AddNotification(string code, string description);
    IReadOnlyCollection<INotification> GetErrors();
}