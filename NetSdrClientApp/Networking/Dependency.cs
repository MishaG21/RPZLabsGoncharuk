using EchoTspServer;

namespace NetSdrClientApp
{
    public class Dependency
    {
        public void CreateServer()
        {
            var server = new EchoServer(5000);
        }
    }
}