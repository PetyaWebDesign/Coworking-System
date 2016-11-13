using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreClient.Services
{
    public class DefaultModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            //builder.RegisterType<CharacterRepository>().As<ICharacterRepository>();
            builder.RegisterType<AuthMessageSender>().As<IEmailSender>();
            builder.RegisterType<AuthMessageSender>().As<ISmsSender>();
        }
    }
}
