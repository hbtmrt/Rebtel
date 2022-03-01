using Grpc.Core;
using Grpc.Core.Interceptors;
using RebtelTest.Service.CustomExceptions;
using System;
using System.Threading.Tasks;

namespace RebtelTest.Service.Interceptors
{
    /// <summary>
    /// A middleware to intercept exception
    /// </summary>
    public class ExceptionInterceptor : Interceptor
    {
        public ExceptionInterceptor()
        {
        }

        public override async Task<TResponse> UnaryServerHandler<TRequest, TResponse>(
        TRequest request,
        ServerCallContext context,
        UnaryServerMethod<TRequest, TResponse> continuation)
        {
            try
            {
                return await continuation(request, context);
            }
            catch (BookNotFoundException ex)
            {
                throw new RpcException(new Status(StatusCode.InvalidArgument, ex.Message));
            }
            catch (Exception exception)
            {
                throw new RpcException(new Status(StatusCode.Internal, exception.ToString()));
            }
        }
    }
}