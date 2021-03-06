﻿using Autofac;

using Microsoft.AspNet.SignalR.Hubs;


namespace TomNet.Autofac.SignalR
{
    /// <summary>
    /// Autofac Hub 创建器
    /// </summary>
    internal class AutofacHubActivator : IHubActivator
    {
        private readonly LifetimeHubManager _lifetimeHubManager;
        private readonly ILifetimeScope _lifetimeScope;

        public AutofacHubActivator(LifetimeHubManager lifetimeHubManager, ILifetimeScope lifetimeScope)
        {
            _lifetimeScope = lifetimeScope;
            _lifetimeHubManager = lifetimeHubManager;
        }

        public IHub Create(HubDescriptor descriptor)
        {
            IHub hub;
            if (!typeof(ILifetimeHub).IsAssignableFrom(descriptor.HubType))
            {
                hub = _lifetimeScope.Resolve(descriptor.HubType) as IHub;
            }
            else
            {
                hub = _lifetimeHubManager.ResolveHub<ILifetimeHub>(descriptor.HubType, _lifetimeScope);
            }
            return hub;
        }
    }
}