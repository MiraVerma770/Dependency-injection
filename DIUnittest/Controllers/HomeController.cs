using Microsoft.AspNetCore.Mvc;

public class HomeController : Controller
{
    private readonly IMyService _scoped1;
    private readonly IMyService _scoped2;

    private readonly IMyService2 _transient1;
    private readonly IMyService2 _transient2;

    private readonly IMyService3 _singleton1;
    private readonly IMyService3 _singleton2;

    public HomeController(IMyService scoped1,
                          IMyService scoped2,
                          IMyService2 transient1,
                          IMyService2 transient2,
                          IMyService3 singleton1,
                          IMyService3 singleton2)
    {
        _scoped1 = scoped1;
        _scoped2 = scoped2;

        _transient1 = transient1;
        _transient2 = transient2;

        _singleton1 = singleton1;
        _singleton2 = singleton2;
    }

    public IActionResult Index()
    {
        var result = $@"
        Scoped Service 1: {_scoped1.GetGuid()}
        Scoped Service 2: {_scoped2.GetGuid()}
        Are Scoped Instances Same? {_scoped1.GetGuid() == _scoped2.GetGuid()}

        Transient Service 1: {_transient1.GetGuid()}
        Transient Service 2: {_transient2.GetGuid()}
        Are Transient Instances Same? {_transient1.GetGuid() == _transient2.GetGuid()}

        Singleton Service 1: {_singleton1.GetGuid()}
        Singleton Service 2: {_singleton2.GetGuid()}
        Are Singleton Instances Same? {_singleton1.GetGuid() == _singleton2.GetGuid()}
";
        return Content(result);
    }
}
