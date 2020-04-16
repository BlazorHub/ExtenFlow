﻿using System.Threading.Tasks;

using Dapr.Actors;

namespace ExtenFlow.Services
{
    /// <summary>
    /// Actor to manage collection of ids.
    /// </summary>
    public interface ICollectionActor : IActor
    {
        /// <summary>
        /// Adds a new item with the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        Task Add(string id);

        /// <summary>
        /// Check if an item with the specified identifier exists.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns>True if the id exists, else false.</returns>
        Task<bool> Exist(string id);

        /// <summary>
        /// Removes a existing item with the specified identifier.
        /// </summary>
        /// <param name="id">The identifier.</param>
        Task Remove(string id);
    }
}