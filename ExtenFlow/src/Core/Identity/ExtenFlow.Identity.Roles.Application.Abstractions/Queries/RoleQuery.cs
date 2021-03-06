﻿using System;

using ExtenFlow.Messages;

namespace ExtenFlow.Identity.Roles.Application.Queries
{
    /// <summary>
    /// Class RoleQuery. Implements the <see cref="Query{T}"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Query{T}"/>
    public class RoleQuery<T> : Query<T>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoleQuery{T}"/> class.
        /// </summary>
        /// <remarks>Do not use this constructor. It has been added for serializers</remarks>
        [Obsolete("Can only be used by serializers")]
        public RoleQuery()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RoleQuery{T}"/> class.
        /// </summary>
        /// <param name="aggregateId">The aggregate identifier.</param>
        /// <param name="userId">The identifier of the user that created the message.</param>
        /// <param name="correlationId">The correlation identifier. Used to link messages together.</param>
        /// <param name="id">The message unique identifier.</param>
        /// <param name="dateTime">The date time, the message was created.</param>
        public RoleQuery(string aggregateId, string userId, string? correlationId = null, string? id = null, DateTimeOffset? dateTime = null)
            : base(nameof(AggregateName.Role), aggregateId, userId, correlationId, id, dateTime)
        {
        }
    }
}