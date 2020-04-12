﻿using Dapr.Actors;

using ExtenFlow.Actors;

namespace ExtenFlow.Identity.Roles
{
    /// <summary>
    /// The role actor interface
    /// </summary>
    /// <seealso cref="IActor"/>
    public interface IRoleActor : IActor, IDispatchActor
    {
    }
}