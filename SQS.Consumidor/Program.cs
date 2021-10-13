using System;
using System.Threading.Tasks;
using Amazon;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace SQS.Consumidor
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var client = new AmazonSQSClient(RegionEndpoint.SAEast1);
            var request = new ReceiveMessageRequest
            {
                QueueUrl = "https://sqs.sa-east-1.amazonaws.com/796779732004/teste2"
            };


            while (true)
            {
                var response = await client.ReceiveMessageAsync(request);

                foreach (var mensagem in response.Messages)
                {
                    Console.WriteLine(mensagem.Body);
                    await client.DeleteMessageAsync("https://sqs.sa-east-1.amazonaws.com/796779732004/teste2", mensagem.ReceiptHandle);
                }
            }
        }
    }
}
