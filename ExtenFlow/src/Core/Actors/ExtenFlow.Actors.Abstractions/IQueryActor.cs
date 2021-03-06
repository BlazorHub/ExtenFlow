﻿using System.Threading.Tasks;

using Dapr.Actors;

using ExtenFlow.Messages;

namespace ExtenFlow.Actors
{
    /// <summary>
    /// Interface IAggregateRootActor Implements the <see cref="Dapr.Actors.IActor"/>
    /// </summary>
    /// <seealso cref="Dapr.Actors.IActor"/>
    public interface IQueryActor : IActor
    {
        /// <summary>
        /// Ask for a response to the query contained in the spécified envelope.
        /// </summary>
        /// <param name="envelope">The envelope.</param>
        /// <returns></returns>
        Task<object> Ask(Envelope envelope);

        /// <summary>
        /// Notifies with the message contained in the spécified envelope.
        /// </summary>
        /// <param name="envelope">The envelope.</param>
        /// <returns></returns>
        Task Notify(Envelope envelope);
    }
}