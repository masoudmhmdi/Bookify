using Bookify.Application.Abstractions.Messaging;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookify.Application.Abstractions.Behaviors
{
    public class ValidationBehavior<TRequest, TResponse>
         : IPipelineBehavior<TRequest, TResponse>
         where TRequest : IBaseCommand // because we only want to run validation for commands
    {
        private readonly IEnumerable<IValidator<TRequest>> _validators;
        public Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
