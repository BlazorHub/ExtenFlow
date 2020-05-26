﻿namespace ExtenFlow.Domain
{
    /// <summary>
    /// The base interface for all commands
    /// </summary>
    public interface ICommand : IRequest
    {
        /// <summary>
        /// Gets the concurrency check stamp.
        /// </summary>
        /// <value>The concurrency check stamp.</value>
        string ConcurrencyCheckStamp { get; }
    }
}