// See https://aka.ms/new-console-template for more information
using Consul;
using System.Text;

Console.WriteLine("Hello, World!");


static async Task<string> RegisterService()
{
    ConsulClientConfiguration configuration = new ConsulClientConfiguration()
    {
        Address = new Uri("http://localhost:8500")
    };

    using (var client = new ConsulClient(configuration))
    {
        AgentServiceRegistration regOptions = new AgentServiceRegistration()
        {
            ID = "987654321",
            Address = "someaddr2",
            Name = "TestService"
        };

        var resultOfRegistration = client.Agent.ServiceRegister(regOptions).GetAwaiter().GetResult();

        var serv = client.Catalog.Services().Result.Response.Values;
    }

    return string.Empty;
}

static async Task<string> AddKeyValuePair()
{
    ConsulClientConfiguration configuration = new ConsulClientConfiguration()
    {
        Address = new Uri("http://localhost:8500")
    };
    using (var client = new ConsulClient(configuration))
    {
        var pair = new KVPair("fromConsole1")
        {
            Value = Encoding.UTF8.GetBytes("valFromConsole2")
        };

        var putAttemptResult = client.KV.Put(pair);

        if (putAttemptResult.Result.Response)
        {
            var getPair = client.KV.Get("fromConsole1");
            var valueFromKV = Encoding.UTF8.GetString(getPair.Result.Response.Value, 0, getPair.Result.Response.Value.Length);
        }

        return String.Empty;
    }
}