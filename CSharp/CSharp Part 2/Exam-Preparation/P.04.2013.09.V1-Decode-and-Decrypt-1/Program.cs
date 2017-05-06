using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeAndDecrypt
{
    class Program
    {
        const char BaseLetter = 'A';

        static void Main(string[] args)
        {
            //ABBAA6BA7        --->  Encode(Encrypt(message, cypher)cypher)     //concatenated with cypher
            //ABBAA6BA   7     --->  Encode(Encrypt(message, cypher) + cypher)  //cypher.length is extrapolated                 
            //ABBAABBBBBBA     --->  Encrypt(message, cypher) + cypher          //decoded enctypted message + cypher  //Encrypt(message, cypher) + cypher
            //BBBBBBA          --->  cypher                                     //cypher is extrapolated              //cypher                             ----> last part of decoded message        
            //ABBAA            --->  Encrypt(message, cypher)                   //enctypted message                   //Encrypt(message, cypher)           ----> first part of decoded message      
            //AAABB            --->  message AAABB                              //message is decrypted                //Encrypt(ABBAABBBBBBA, cypher)      ----> Encrypt("AAABB", "BBBBBBA") = "ABBAA"  and Encrypt("ABBAA", "BBBBBBA") = "ABBAA"


            string encodedEncryptedMessage = Console.ReadLine();

            int cypherLength = GetMessageCypherLength(encodedEncryptedMessage);
            int cypherLengthNumberSubstringLength = cypherLength.ToString().Length;

            string encodedEncryptedMessageWithCypher = encodedEncryptedMessage.Substring(0, encodedEncryptedMessage.Length - cypherLengthNumberSubstringLength);

            string encryptedMessageWithCypher = Decode(encodedEncryptedMessageWithCypher);

            string cypher = encryptedMessageWithCypher.Substring(encryptedMessageWithCypher.Length - cypherLength);
            string encryptedMessage = encryptedMessageWithCypher.Substring(0, encryptedMessageWithCypher.Length - cypherLength);

            string message = Decrypt(encryptedMessage, cypher);

            Console.WriteLine(message);
        }

        static int GetMessageCypherLength(string encodedEncryptedMessage)//cypher is extrapolated
        {
            int lengthSubstringStartIndex = -1;
            for (int index = encodedEncryptedMessage.Length - 1; index > 0; index--)
            {
                char currentSymbol = encodedEncryptedMessage[index];
                if (!Char.IsDigit(currentSymbol))
                {
                    lengthSubstringStartIndex = index + 1;
                    break;
                }
            }

            string lengthSubstring = encodedEncryptedMessage.Substring(lengthSubstringStartIndex);
            int cypherLength = int.Parse(lengthSubstring);

            return cypherLength;
        }

        static string Decode(string encodedText) //decompress   4a=>aaaa
        {
            StringBuilder decodedTextBuilder = new StringBuilder();

            int index = 0;
            int currentNumber = 0;
            while (index < encodedText.Length)
            {
                if (Char.IsDigit(encodedText[index]))
                {
                    currentNumber = encodedText[index] - '0' + (currentNumber * 10);
                }
                else
                {
                    char currentSymbol = encodedText[index];
                    if (currentNumber > 0)
                    {
                        decodedTextBuilder.Append(new string(currentSymbol, currentNumber));
                        currentNumber = 0;
                    }
                    else
                    {
                        decodedTextBuilder.Append(currentSymbol);
                    }
                }

                index++;
            }

            return decodedTextBuilder.ToString();
        }

        static string Decrypt(string encryptedMessage, string cypher) 
        {
            StringBuilder messageBuilder = new StringBuilder(encryptedMessage);

            int longer = Math.Max(encryptedMessage.Length, cypher.Length);

            for (int index = 0; index < longer; index++)
            {
                int message = index % encryptedMessage.Length;
                int indexInCypher = index % cypher.Length;

                int charInencryptedMessageOffset = messageBuilder[message] - BaseLetter;
                int charInCypherOffset = cypher[indexInCypher] - BaseLetter;

                messageBuilder[message] = (char)(BaseLetter + (charInencryptedMessageOffset ^ charInCypherOffset));
            }

            return messageBuilder.ToString();
        }
    }
}
