using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp.Ispit.Zadatak1
{
    class Program
    {
        public void Main(string[] args) 
        {
            double unos = 1;
            Console.WriteLine("unesi broj od 1 do 30");
            while (unos>1 || unos <30)
            {
                unos = double.Parse(Console.ReadLine());
                Console.WriteLine(unos + "       " + unos / 3);
            
            
            
            }
        
        
        
        }
       
    }
}
