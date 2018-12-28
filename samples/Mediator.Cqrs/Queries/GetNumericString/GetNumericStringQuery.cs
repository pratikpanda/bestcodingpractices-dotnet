using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mediatr.Cqrs.Queries.GetNumericString
{
    public class GetNumericStringQuery : IRequest<string>
    {
        public int Number { get; set; }
    }
}
