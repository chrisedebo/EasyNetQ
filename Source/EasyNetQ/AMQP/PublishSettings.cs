﻿using System;

namespace EasyNetQ.AMQP
{
    public class PublishSettings
    {
        public IExchange Exchange { get; private set; }
        public string RoutingKey { get; private set; }
        public bool Mandatory { get; set; }
        public bool Immediate { get; set; }

        public PublishSettings(IExchange exchange, string routingKey)
        {
            if(exchange == null)
            {
                throw new ArgumentNullException("exchange");
            }
            if(routingKey == null)
            {
                throw new ArgumentNullException("routingKey");
            }

            Exchange = exchange;
            RoutingKey = routingKey;
            
            // defaults
            Mandatory = false;
            Immediate = false;
        }
    }
}