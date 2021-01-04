using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tilfaeldigheder
{
    class Program
    {
        public static string GenerateRandomStringUsingRNGCryptoServiceProvider(int length)
        {
            using (RNGCryptoServiceProvider randomNumberGenerator = new RNGCryptoServiceProvider())
            {
                byte[] randomNumber = new byte[length];
                randomNumberGenerator.GetBytes(randomNumber);
                return Convert.ToBase64String(randomNumber);
            }
        }

        public static string GenerateRandomStringUsingRandom(int length)
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] stringChars = new char[length];
            Random random = new Random();

            try
            {
                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return (new String(stringChars));
        }

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            try
            {
                for (int i = 0; i < 100000; i++)
                {
                    Console.WriteLine(GenerateRandomStringUsingRNGCryptoServiceProvider(10));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            
            stopwatch.Stop();
            Console.WriteLine("Time elapsed: {0}", stopwatch.Elapsed);

            Console.ReadLine();
        }
    }
}
