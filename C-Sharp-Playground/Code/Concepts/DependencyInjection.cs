namespace C_Sharp_Playground.Code.Concepts
{

    public interface IService
    {
        void serve();
    }
    public class Service : IService
    {
        public void serve()
        {
            Console.WriteLine("SERVICE CALLED");
        }
    }
    public class User
    {
        private IService _service;

        public User(IService service)
        {
            service = _service;
        }
        public void Start()
        {
            _service.serve();
        }
    }
    public class _Program
    {
        void Mainn()
        {
            IService service = new Service();
            User user = new User(service);
            user.Start();
        }
    }
}