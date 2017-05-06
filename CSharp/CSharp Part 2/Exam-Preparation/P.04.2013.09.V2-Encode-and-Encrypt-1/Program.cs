using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncodeAndEncrypt
{
    class Program
    {
        const char BaseLetter = 'A';

        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string cypher = Console.ReadLine();

            var encryptedMessageWithCypher = Encrypt(message, cypher) + cypher;
            var compressedEncryptedMessageWithCypher = Encode(encryptedMessageWithCypher) + cypher.Length;

            Console.WriteLine(compressedEncryptedMessageWithCypher);
        }

        private static string Encrypt(string message, string cypher)
        {
            StringBuilder encryptedMessageWithCypherBuilder = new StringBuilder(message);

            int longer = Math.Max(message.Length, cypher.Length);

            for (int index = 0; index < longer; index++)
            {
                int messageIndex = index % message.Length;
                int indexInCypher = index % cypher.Length;

                int charInMessageOffset = encryptedMessageWithCypherBuilder[messageIndex] - BaseLetter;
                int charInCypherOffset = cypher[indexInCypher] - BaseLetter;

                encryptedMessageWithCypherBuilder[messageIndex] = (char)(BaseLetter + (charInMessageOffset ^ charInCypherOffset));
            }

            return encryptedMessageWithCypherBuilder.ToString();
        }

        private static string Encode(string message)//compress aaaaa --> 5a
        {
            StringBuilder encodedTextBuilder = new StringBuilder(message.Length);
            int messageIndex = 0;
            while (messageIndex < message.Length)
            {
                char currentSymbol = message[messageIndex];
                int scanIndex = messageIndex + 1;
                int counter = 1;

                while (scanIndex < message.Length && message[scanIndex] == currentSymbol) //message[scanIndex] == currentSymbol ---> a == a
                {
                    counter++;
                    scanIndex++;
                }

                messageIndex = scanIndex;
                if (counter > 2)
                {
                    encodedTextBuilder.Append(counter);
                    encodedTextBuilder.Append(currentSymbol);
                }
                else
                {
                    encodedTextBuilder.Append(new string(currentSymbol, counter));
                }
            }

            return encodedTextBuilder.ToString();
        }
    }
}
