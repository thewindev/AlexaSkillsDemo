﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateDemo
{
    public static class IntentNames
    {
        // Default intents.
        public const string Cancel = "AMAZON.CancelIntent";
        public const string Help = "AMAZON.HelpIntent";
        public const string Stop = "AMAZON.StopIntent";
        public const string NavigateHomeIntent = "AMAZON.NavigateHomeIntent";
        public const string Fallback = "AMAZON.FallbackIntent";

        //Custom intents
        public const string ReadList = "ReadList";
        public const string PickWinner = "PickWinner";
    }
}
