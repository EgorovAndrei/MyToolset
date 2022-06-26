using MassTransit;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MassTransit31
{
    public class MessageConsumer : IConsumer<Message>
    {
        readonly ILogger<MessageConsumer> _logger;
        public MessageConsumer(ILogger<MessageConsumer> logger)
        {
            _logger = logger;
        }
        public Task Consume(ConsumeContext<Message> context)
        {
            _logger.LogInformation("received text: " + context.Message.Text);

            return Task.CompletedTask;
        }
    }
}
