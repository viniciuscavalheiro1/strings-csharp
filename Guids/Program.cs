using System;

namespace Guids
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            Console.WriteLine(id.ToString().Substring(2, 8));
        }
    }
}
