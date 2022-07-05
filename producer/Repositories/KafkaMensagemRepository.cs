using App.Entities;
using App.Repositories.Interfaces;
using Confluent.Kafka;
using System.Text.Json;

namespace App.Repositories
{
    public class KafkaMensagemRepository : IAppMensagemRepository
    {
        public async Task SendMensagem(AppMensagem mensagem, string queue)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };
            using (var producer = new ProducerBuilder<string, string>(config).Build())
            {
                string json = JsonSerializer.Serialize(mensagem);
                try
                {
                    var dr = await producer.ProduceAsync(queue, new Message<string, string>{Value = json});
                    Console.WriteLine($"Delivered '{dr.Value}' to '{dr.TopicPartitionOffset}'");
                }
                catch (ProduceException<Null, string> e)
                {
                    Console.WriteLine($"Delivery failed: {e.Error.Reason}");
                }
            }
        }
        public async Task PutMensagem(AppMensagemTransaction mensagem, string queue)
        {
            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092"
            };
            using (var producer = new ProducerBuilder<string, string>(config).Build())
            {
                string json = JsonSerializer.Serialize(mensagem);
                try
                {
                    var dr = await producer.ProduceAsync(queue, new Message<string, string>{Value = json});
                    Console.WriteLine($"Delivered '{dr.Value}' to '{dr.TopicPartitionOffset}'");
                }
                catch (ProduceException<Null, string> e)
                {
                    Console.WriteLine($"Delivery failed: {e.Error.Reason}");
                }
            }
        }
    }
}
