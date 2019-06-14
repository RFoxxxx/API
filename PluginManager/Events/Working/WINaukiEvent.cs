﻿using Smod2.Commands;
using Smod2.Events;
using Smod2;
using Smod2.EventHandlers;
using System;

namespace EventManager
{
    class WINaukiEvent : IEventHandler
    {
        private EventManager plugin;
        public WINaukiEvent(EventManager plugin, Smod2.API.Player admin, bool forced)
        {
            EventManager.ActiveEvent = "WINauki";
            this.plugin = plugin;
            plugin.Server.Map.Broadcast(5, EventManager.EMRed + plugin.GetTranslation("event_ini") + ":W imię nauki", false);
            EventManager.ToDSC.Initate(admin, "WINauki", forced);
        }
    }
}