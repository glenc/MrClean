namespace MrClean.Domain.Events;

public class MrCleanEvent<T> : BaseEvent 
{ 
    public T Entity { get; }

    public MrCleanEvent(T entity)
    {
        Entity = entity;
    }
}