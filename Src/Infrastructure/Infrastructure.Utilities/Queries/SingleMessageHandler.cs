﻿using Infrastructure.Utilities.Common;
using System.Threading.Tasks;

namespace Infrastructure.Utilities.Queries
{
    public abstract class SingleMessageHandler<T, TOut>
        where T : class, IRequest<TOut>
        where TOut : class, IResult, new()
    {
        public abstract Task<TOut> Handler(T message);
    }
}
