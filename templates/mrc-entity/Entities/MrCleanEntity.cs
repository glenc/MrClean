namespace MrClean.Entities;

public class MrCleanEntity : BaseAuditableEntity
{
    public string Name { get; private set; } = "";

    public MrCleanEntity(string name)
    {
        Name = name;
    }

    // for ef rehydration
    private MrCleanEntity() {}
}