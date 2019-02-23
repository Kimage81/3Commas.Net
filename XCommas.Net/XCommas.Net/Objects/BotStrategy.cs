﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace XCommas.Net.Objects
{
    public abstract class BotStrategy
    {
        public BotStrategy(string name)
        {

        }

        [JsonProperty("strategy")]
        public string Name { get; private set; }
    }

    public class NonStopBotStrategy : BotStrategy
    {
        public const string Id = "nonstop";
        public NonStopBotStrategy() : base(Id)
        {

        }
    }

    public class QflBotStrategy : BotStrategy
    {
        public const string Id = "qfl";
        public QflBotStrategy() : base("qfl")
        {

        }

        [JsonProperty("options")]
        public QflOptions Options { get; set; }
    }

    public class CqsTelegramBotStrategy : BotStrategy
    {
        public const string Id = "cqs_telegram";
        public CqsTelegramBotStrategy() : base(Id)
        {

        }
    }

    public class TaPresetBotStrategy : BotStrategy
    {
        public const string Id = "ta_preset";
        public TaPresetBotStrategy() : base(Id)
        {

        }

        [JsonProperty("options")]
        public TaPresetsOptions Options { get; set; }
    }

    public class TradingViewBotStrategy : BotStrategy
    {
        public const string Id = "trading_view";
        public TradingViewBotStrategy() : base(Id)
        {

        }

        [JsonProperty("options")]
        public TradingViewOptions Options { get; set; }
    }

    public class RsiBotStrategy : BotStrategy
    {
        public const string Id = "rsi";
        public RsiBotStrategy() : base(Id)
        {

        }

        [JsonProperty("options")]
        public RsiOptions Options { get; set; }
    }

    public class UltBotStrategy : BotStrategy
    {
        public const string Id = "ult";
        public UltBotStrategy() : base(Id)
        {

        }

        [JsonProperty("options")]
        public UltOptions Options { get; set; }
    }
}