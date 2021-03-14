using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(1, "Satranç");
            dictionary.Add(2, "Bülbülü Öldürmek");
            dictionary.Add(3, "Dönüşüm");
            dictionary.Add(4, "Yaşamak");
           
            for (int i = 0; i < dictionary.Items.Length; i++)
            {
                Console.WriteLine(dictionary.Items[i]);
            }

            Console.WriteLine(dictionary.Length);
            dictionary.Add(5, "Simyacı");
            Console.WriteLine(dictionary.Length +". nolu ID'ye eklenen kitap: "+dictionary.Items[dictionary.Length-1]);
        }
    }
}
