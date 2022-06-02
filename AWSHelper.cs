using System;
using System.Threading.Tasks;
using Amazon.Pinpoint;
using Amazon.Pinpoint.Model;
using Amazon.SQS;
using Amazon.SQS.Model;

namespace Api.Database.MySql
{
    public class AWSHelper
    {
        private static readonly IAmazonSQS sqsClient;

        static AWSHelper()
        {
            sqsClient = new AmazonSQSClient();
        }

        public static async Task SendEmail(
            string messageBody,
            string messageGroupId,
            string messageDeduplicationId,
            string queueUrl
            )
        {
            var sendMessageRequest = new SendMessageRequest();
            sendMessageRequest.MessageBody = messageBody;
            sendMessageRequest.MessageGroupId = messageGroupId;
            sendMessageRequest.MessageDeduplicationId = messageDeduplicationId;
            sendMessageRequest.QueueUrl = queueUrl;

            var response = await sqsClient.SendMessageAsync(sendMessageRequest);
        }
    }
}