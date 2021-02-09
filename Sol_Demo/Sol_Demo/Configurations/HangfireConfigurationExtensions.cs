using Hangfire;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Configurations
{
    public static class HangfireConfigurationExtensions
    {
        public static void UseMediatR(this IGlobalConfiguration configuration)
        {
            var jsonSettings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All
            };
            configuration.UseSerializerSettings(jsonSettings);
        }
    }
}