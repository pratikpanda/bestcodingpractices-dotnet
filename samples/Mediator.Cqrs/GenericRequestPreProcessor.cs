using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediatr.Cqrs
{
    public class GenericRequestPreProcessor<TRequest> : IRequestPreProcessor<TRequest>
    {
        public Task Process(TRequest request, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}
