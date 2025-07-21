public interface IMyService
{
    Guid GetGuid();
}

public class MyService : IMyService
{
    private Guid _guid;

    public MyService()
    {
        _guid = Guid.NewGuid();
        Console.WriteLine($"[Scoped] MyService created: {_guid}");
    }

    public Guid GetGuid()
    {
        return _guid;
    }
}

// Transient Service
public interface IMyService2
{
    Guid GetGuid();
}

public class MyService2 : IMyService2
{
    private Guid _guid;

    public MyService2()
    {
        _guid = Guid.NewGuid();
        Console.WriteLine($"[Transient] MyService2 created: {_guid}");
    }

    public Guid GetGuid()
    {
        return _guid;
    }
}

// Singleton Service
public interface IMyService3
{
    Guid GetGuid();
}

public class MyService3 : IMyService3
{
    private Guid _guid;

    public MyService3()
    {
        _guid = Guid.NewGuid();
        Console.WriteLine($"[Singleton] MyService3 created: {_guid}");
    }

    public Guid GetGuid()
    {
        return _guid;
    }
}
