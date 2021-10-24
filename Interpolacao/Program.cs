using System;

namespace Interpolacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var price = 10.9;
            var price2 = 9.9;
            var text = string.Format(
              "O preço do produto é {0} e o preço na promoção {1}", 
              price,
              price2);
            Console.WriteLine(text);
            var text2 = $"O preço do produto é {price} e o preço na promoção {price2}";
            Console.WriteLine(text2);
        }
    }
}
