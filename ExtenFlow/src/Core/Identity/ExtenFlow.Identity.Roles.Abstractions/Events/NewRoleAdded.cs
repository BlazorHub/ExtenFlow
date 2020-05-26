﻿using System;

using ExtenFlow.Infrastructure;

namespace ExtenFlow.Identity.Roles.Events
{
    /// <summary>
    /// New role created
    /// </summary>
    /// <seealso cref="RoleEvent"/>
    public class NewRoleAdded : RoleEvent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NewRoleAdded"/> class.
        /// </summary>
        /// <remarks>This constructor must not be used. It has been added for serializers</remarks>
        [Obsolete("Can only be used by serializers")]
        public NewRoleAdded()
        {
            Name = string.Empty;
            NormalizedName = string.Empty;
            ConcurrencyCheckStamp = string.Empty;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NewRoleAdded"/> class.
        /// </summary>
        /// <param name="aggregateId">Aggragate Id.</param>
        /// <param name="name">The role new name.</param>
        /// <param name="normalizedName">The role new normalized name.</param>
        /// <param name="userId">The user submitting the command.</param>
        /// <param name="concurrencyCheckStamp">The optimistic concurrency check stamp.</param>
        /// <param name="correlationId">
        /// The correlation id used to chain messages, queries, commands and events.
        /// </param>
        /// <param name="id">The Id of this command.</param>
        /// <param name="dateTime">The date time of the command submission.</param>
        public NewRoleAdded(string aggregateId, string name, string normalizedName, string userId, string? concurrencyCheckStamp = null, string? correlationId = null, string? id = null, DateTimeOffset? dateTime = null)
            : base(aggregateId, userId, correlationId, id, dateTime)
        {
            Name = name;
            NormalizedName = normalizedName;
            ConcurrencyCheckStamp = concurrencyCheckStamp ?? Guid.NewGuid().ToBase64String();
        }

        /// <summary>
        /// Gets the optimistic concurrency check stamp.
        /// </summary>
        /// <value>The concurrency check stamp.</value>
        public string ConcurrencyCheckStamp { get; }

        /// <summary>
        /// Gets the new role name.
        /// </summary>
        /// <value>The name.</value>
        public string Name { get; }

        /// <summary>
        /// Gets the new role normalized name.
        /// </summary>
        /// <value>The name of the normalized.</value>
        public string NormalizedName { get; }
    }
}