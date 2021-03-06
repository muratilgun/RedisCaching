using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using StackExchange.Redis;

namespace RedisDeneme.BackgroundTasks
{
    public class RedisSubscriber : BackgroundService
    {
        private readonly IConnectionMultiplexer _connectionMultiplexer;

        public RedisSubscriber(IConnectionMultiplexer connectionMultiplexer)
        {
            _connectionMultiplexer = connectionMultiplexer;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var subscriber =  _connectionMultiplexer.GetSubscriber();
            return  subscriber.SubscribeAsync("messages",((channel, value) =>
            {
                Console.WriteLine($"The message content was: {value}");
            }));
            
        }
    }
}
