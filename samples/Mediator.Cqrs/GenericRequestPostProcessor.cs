using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Mediatr.Cqrs
{
    public class GenericRequestPostProcessor<TRequest, TResponse> : IRequestPostProcessor<TRequest, TResponse>
    {

        public Task Process(TRequest request, TResponse response)
        {
            return Task.CompletedTask;
        }
    }
}
