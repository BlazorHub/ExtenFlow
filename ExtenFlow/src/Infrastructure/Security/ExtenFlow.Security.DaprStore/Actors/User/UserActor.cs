﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Dapr.Actors;
using Dapr.Actors.Runtime;

using ExtenFlow.Security.Users;

using Microsoft.AspNetCore.Identity;

#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.

namespace ExtenFlow.Security.DaprStore.Actors
{
    public class UserActor : Actor, IUserActor, IRemindable
    {
        private const string StateName = "User";
        private User? _state;
        private IdentityErrorDescriber _errorDescriber = new IdentityErrorDescriber();

        public User State => _state ?? throw new NullReferenceException(nameof(_state));

        public IdentityErrorDescriber ErrorDescriber { get => _errorDescriber ?? (_errorDescriber = new IdentityErrorDescriber()); }

        public UserActor(ActorService actorService, ActorId actorId, IActorStateManager? actorStateManager = null) : base(actorService, actorId, actorStateManager)
        {
        }

        public Task ReceiveReminderAsync(string reminderName, byte[] state, TimeSpan dueTime, TimeSpan period) => throw new NotImplementedException();

        public Task<string> GetUserName()
            => Task.FromResult(State?.UserName);

        public Task<string> FindUserId()
             => Task.FromResult(_state?.Id);

        public Task<string> GetNormalizedUserName()
          => Task.FromResult(State?.NormalizedUserName);

        public Task SetUserName(string userName)
        {
            State.UserName = (userName ?? throw new NullReferenceException(nameof(_state)));
            return Task.CompletedTask;
        }

        public Task SetNormalizedUserName(string normalizedName)
        {
            State.NormalizedUserName = (normalizedName ?? throw new NullReferenceException(nameof(_state)));
            return Task.CompletedTask;
        }

        public async Task<IdentityResult> Create(User user)
        {
            if (_state != null)
            {
                throw new InvalidOperationException($"The user Id ({user.Id}, {_state.UserName}) already exist.");
            }
            if (user.Id != Id.GetId())
            {
                throw new InvalidOperationException($"The user Id ({user.Id}) is not the same as the actor Id({Id.GetId()})");
            }
            _state = user;
            await Save();
            return IdentityResult.Success;
        }

        public async Task<IdentityResult> Update(User user)
        {
            if (_state != null)
            {
                throw new InvalidOperationException($"The user ({Id.GetId()}, does not exist or has been deleted.");
            }
            if (user.Id != Id.GetId())
            {
                throw new InvalidOperationException($"The user Id ({user.Id}) is not the same as the actor Id({Id.GetId()})");
            }
            _state = user;
            await Save();
            return IdentityResult.Success;
        }

        private Task Save() => StateManager.SetStateAsync(StateName, _state);

        // Public for test purposes
        public async Task Read() => _state = await StateManager.GetStateAsync<User?>(StateName);

        public async Task<IdentityResult> Delete()
        {
            if (_state == null)
            {
                throw new InvalidOperationException($"The user Id ({Id.GetId()}) already exist.");
            }
            _state = null;
            await Save();
            return IdentityResult.Success;
        }

        public Task<User> GetUser() => _state == null ? Task.FromException<User>(new KeyNotFoundException($"The user with Id='{Id.GetId()}' has not been created or has been deleted.")) : Task.FromResult(State);

        protected override async Task OnActivateAsync()
        {
            await Read();
            await base.OnActivateAsync();
        }
    }
}