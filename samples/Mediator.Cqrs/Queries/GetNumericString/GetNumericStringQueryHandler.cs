using Mediatr.Cqrs.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediatr.Cqrs.Queries.GetNumericString
{
    public class GetNumericStringQueryHandler : IRequestHandler<GetNumericStringQuery, string>
    {
        private readonly INumberService numberService;

        public GetNumericStringQueryHandler(INumberService numberService)
        {
            this.numberService = numberService;
        }

        public Task<string> Handle(GetNumericStringQuery request, CancellationToken cancellationToken)
        {
            var number = request.Number;
            var numericString = numberService.GetNumericStringValue(number);
            return Task.FromResult(numericString);
        }
    }
}
