﻿using System;

using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

using Newtonsoft.Json.Serialization;

using TomNet.Core.Packs;


namespace TomNet.AspNetCore.SignalR
{
    /// <summary>
    /// SignalR模块基类
    /// </summary>

    public abstract class SignalRPackBase : AspTomNetPack
    {
        /// <summary>
        /// 获取 模块级别，级别越小越先启动
        /// </summary>
        public override PackLevel Level => PackLevel.Application;

        /// <summary>
        /// 获取 模块启动顺序，模块启动的顺序先按级别启动，同一级别内部再按此顺序启动，
        /// 级别默认为0，表示无依赖，需要在同级别有依赖顺序的时候，再重写为>0的顺序值
        /// </summary>
        public override int Order => 1;

        /// <summary>
        /// 将模块服务添加到依赖注入服务容器中
        /// </summary>
        /// <param name="services">依赖注入服务容器</param>
        /// <returns></returns>
        public override IServiceCollection AddServices(IServiceCollection services)
        {
            services.TryAddSingleton<IUserIdProvider, UserNameUserIdProvider>();

            ISignalRServerBuilder builder = services.AddSignalR();
            Action<ISignalRServerBuilder> buildAction = GetSignalRServerBuildAction(services);
            buildAction?.Invoke(builder);

            return services;
        }

        /// <summary>
        /// 应用AspNetCore的服务业务
        /// </summary>
        /// <param name="app">Asp应用程序构建器</param>
        public override void UsePack(IApplicationBuilder app)
        {
            Action<HubRouteBuilder> hubRouteBuildAction = GetHubRouteBuildAction(app.ApplicationServices);
            app.UseSignalR(hubRouteBuildAction);
        }

        /// <summary>
        /// 重写以获取SignalR服务器创建委托
        /// </summary>
        /// <param name="services">依赖注入服务容器</param>
        /// <returns></returns>
        protected virtual Action<ISignalRServerBuilder> GetSignalRServerBuildAction(IServiceCollection services)
        {
            return builder => builder.AddJsonProtocol(config => config.PayloadSerializerSettings.ContractResolver = new DefaultContractResolver());
        }

        /// <summary>
        /// 重写以获取Hub路由创建委托
        /// </summary>
        /// <param name="serviceProvider">服务提供者</param>
        /// <returns></returns>
        protected abstract Action<HubRouteBuilder> GetHubRouteBuildAction(IServiceProvider serviceProvider);
    }
}