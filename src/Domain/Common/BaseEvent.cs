using MediatR;

namespace MrClean.Domain.Common;

public abstract class BaseEvent : INotification
{
    public DateTime OccurredOn { get; init; } = DateTime.UtcNow;
}
