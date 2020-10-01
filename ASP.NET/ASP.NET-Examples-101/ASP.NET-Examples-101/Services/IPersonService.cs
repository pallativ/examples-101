namespace DependencyInjection.Services
{
    public interface IPersonService
    {
        string Execute(string name);
    }

    public class PersonService : IPersonService
    {
        public string Execute(string name)
        {
            return string.Format("Hello {0} From Person Service", name);
        }
    }
}