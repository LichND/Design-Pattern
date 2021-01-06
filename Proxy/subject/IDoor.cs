namespace Proxy.Subject.DoorSubject {
    public interface IDoor {
        StatusCode Open();
        StatusCode Close();
    }
}