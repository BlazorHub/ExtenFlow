﻿using System;
using System.Globalization;

using ExtenFlow.Domain.Aggregates;

namespace ExtenFlow.Domain.Exceptions
{
    /// <summary>
    /// Class EntityDuplicateException. Implements the <see cref="System.Exception"/>
    /// </summary>
    /// <seealso cref="System.Exception"/>
    public class EntityDuplicateException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntityDuplicateException"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
        public EntityDuplicateException(IEntity entity)
            : base(string.Format(CultureInfo.CurrentCulture, Properties.Resources.EntityDuplicate, entity?.EntityName, nameof(IEntity.Id), entity?.Id))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityDuplicateException"/> class.
        /// </summary>
        /// <param name="entity">The entity.</param>
        /// <param name="keyName">Name of the key.</param>
        /// <param name="keyValue">The key value.</param>
        public EntityDuplicateException(IEntity entity, string keyName, string keyValue)
            : base(string.Format(CultureInfo.CurrentCulture, Properties.Resources.EntityDuplicate, entity?.EntityName, keyName, keyValue))
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityDuplicateException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public EntityDuplicateException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityDuplicateException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">
        /// The exception that is the cause of the current exception, or a null reference ( <see
        /// langword="Nothing"/> in Visual Basic) if no inner exception is specified.
        /// </param>
        public EntityDuplicateException(string message, Exception innerException) : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityDuplicateException"/> class.
        /// </summary>
        public EntityDuplicateException()
        {
        }
    }
}