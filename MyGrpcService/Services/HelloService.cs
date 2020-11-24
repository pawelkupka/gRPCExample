using Grpc.Core;
using System.Threading.Tasks;


namespace MyGrpcService
{
    public class HelloService : Hello.HelloBase
    {
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply
            {
                Message = "Hello " + request.Name
            });
        }
    }
}
