﻿using System;
using System.Threading.Tasks;
using Impostor.Api.Events.Managers;
using Impostor.Api.Plugins;
using Microsoft.Extensions.Logging;

namespace XtraCube.Plugins.AllofUs
{
    [ImpostorPlugin(
        package: "gg.xtracube.allofus",
        name: "AllOfUsBot",
        author: "XtraCube",
        version: "2.1.1")]
    public class AllOfUsPlugin : PluginBase
    {
        private readonly ILogger<AllOfUsPlugin> _logger; 

        public AllOfUsPlugin(ILogger<AllOfUsPlugin> logger, IEventManager eventManager)
        {
            _logger = logger;
        }

        public override ValueTask EnableAsync()
        {
            _logger.LogInformation("AllofUs is starting.");
            return default;
        }

        public override ValueTask DisableAsync()
        {
            _logger.LogInformation("AllofUs is being disabled.");
            return default;
        }
    }
}