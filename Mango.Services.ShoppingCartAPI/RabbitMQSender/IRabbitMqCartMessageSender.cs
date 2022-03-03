using Mango.MessageBus;

namespace Mango.Services.ShoppingCartAPI.RabbitMQSender
{
    public interface IRabbitMqCartMessageSender
    {
        void SendMessage(BaseMessage message, string queueName);
    }
}