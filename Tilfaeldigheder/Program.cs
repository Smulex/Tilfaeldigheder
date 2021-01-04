using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Tilfaeldigheder
{
    class Program
    {
        static void Main(string[] args)
        {
            using (RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider())
            {
                //Buffer
                byte[] data = new byte[4];

                //Ten iterations
                for (int i = 0; i < 10; i++)
                {
                    //Fill buffer
                    rng.GetBytes(data);

                    //Convert to int
                    int value = BitConverter.ToInt32(data, 0);

                    //Print value
                    Console.WriteLine(value);
                }
            }
            Console.ReadKey();
        }
    }
}
