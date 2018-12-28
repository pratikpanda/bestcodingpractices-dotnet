using Mediatr.Cqrs.Services;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Mediatr.Cqrs.Commands.Add
{
    public class AddCommandHandler : IRequestHandler<AddCommand, bool>
    {
        private readonly INumberService numberService;

        public AddCommandHandler(INumberService numberService)
        {
            this.numberService = numberService;
        }

        public Task<bool> Handle(AddCommand request, CancellationToken cancellationToken)
        {
            var number = request.Number;
            var numericString = request.NumericString;
            return Task.FromResult(numberService.Add(number, numericString));
        }
    }
}
