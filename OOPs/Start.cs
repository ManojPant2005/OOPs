using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPs
{
    public class Start
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }  
        public int Balance { get; set; }



        public void AddTwo(int a, int b)
        {
            var result = a + b;
            Console.WriteLine(result);  
        }
    }
}
