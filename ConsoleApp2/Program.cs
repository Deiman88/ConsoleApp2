using System;
using HUtils;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var jstr =@"{""order"":{""Id"": 2213, ""zip"": ""65203"", ""city"": ""Columbia"", ""name"": ""Sonya Carney"", ""email"": ""sonyacarney@gmail.com"", ""state"": ""MO"", ""express"": false, ""is_dead"": false, ""is_gift"": false, ""priority"": false, ""url_show"": null, ""was_paid"": true, ""OrderItem"": [{""Id"": 2770, ""Listing"": {""Id"": 65, ""image_url"": ""https://i.etsystatic.com/14572595/d/il/df4ac4/2214458452/il_170x135.2214458452_cj3o.jpg?version=0""}, ""comment"": null, ""initial"": ""S"", ""orderId"": 2213, ""OrderNum"": 0, ""quantity"": 1, ""ItemParam"": [{""Id"": 934, ""value_id"": null, ""property_id"": 54, ""formatted_name"": ""Personalization"", ""formatted_value"": ""S"", ""formatted_name_local"": null, ""formatted_value_local"": null}, {""Id"": 20, ""value_id"": 73569996380, ""property_id"": 513, ""formatted_name"": ""Personalization"", ""formatted_value"": ""Add initials"", ""formatted_name_local"": null, ""formatted_value_local"": ""С инициалами""}, {""Id"": 2, ""value_id"": 49974750690, ""property_id"": 200, ""formatted_name"": ""Color"", ""formatted_value"": ""Purple"", ""formatted_name_local"": null, ""formatted_value_local"": ""Фиолетовый""}], ""listingId"": 65, ""ListingSku"": {""Id"": 189, ""txt"": ""U01_i"", ""area"": 0.040, ""price"": 56.50, ""comment"": null}, ""creation_tsz"": ""2020-07-21T17:27:05"", ""listingSkuId"": 189, ""OrderItemWorks"": [], ""transaction_id"": 1992316603}], ""country_id"": 209, ""first_line"": ""2600 Ridgefield Rd"", ""receipt_id"": 1708758572, ""second_line"": null, ""was_shipped"": true, ""creation_tsz"": ""2020-07-21T17:27:05"", ""gift_message"": """", ""loadFromEtsy"": ""2020-07-22T05:17:29.903872"", ""needs_gift_wrap"": false, ""name_alternative"": ""Sonya"", ""formatted_address"": ""Sonya Carney\n2600 Ridgefield Rd\nCOLUMBIA, MO 65203\nUnited States"", ""message_from_buyer"": null, ""message_from_seller"": null, ""message_from_payment"": ""Paypal sent us the following information from the buyer.\n        txn_id=4AG68326KF6866009\n        payment_date=10:27:06 Jul 21, 2020 PDT\n        Sonya Carney\n        2600 Ridgefield Rd\n        Columbia\n        MO\n        65203-1536\n        US"", ""formatter_address_change"": null, ""gift_message_alternative"": null}}";
                
            RabbitMaster.Send(QueueNames.SendEmail, jstr);
        }
    }
}