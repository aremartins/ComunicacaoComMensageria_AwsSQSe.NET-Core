using System;
using System.Threading.Tasks;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace SQS.Fornecedor
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
            var request = new SendMessageRequest
            {
                QueueUrl = "https://sqs.sa-east-1.amazonaws.com/796779732004/teste2",
                MessageBody = "Mensagem recebida com sucesso!"
            };
            
            await client.SendMessageAsync(request);
        }
    }
}
