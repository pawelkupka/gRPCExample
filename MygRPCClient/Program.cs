using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using MyGrpcService;

namespace MygRPCClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var channel = GrpcChannel.ForAddress("http://localhost:5000");
            var client = new Hello.HelloClient(channel);
            var response = await client.SayHelloAsync(new HelloRequest { Name = "Pawel" });
            Console.WriteLine(response.Message);
        }
    }
}
