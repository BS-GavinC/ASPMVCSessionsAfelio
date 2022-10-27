namespace ASPMVC.Services;

public class SessionManager
{
    private readonly ISession _session;

    public SessionManager(IHttpContextAccessor accessor)
    {
        _session = accessor.HttpContext.Session;
    }

    public string Email
    {
        get { return _session.GetString("Email");}
        set { _session.SetString("Email", value);}
    }

    public void Logout()
    {
        _session.Clear();
    }
}