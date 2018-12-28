using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediatr.Cqrs.Commands.Add
{
    public class AddCommand : IRequest<bool>
    {
        public int Number { get; set; }
        public string NumericString { get; set; }
    }
}
