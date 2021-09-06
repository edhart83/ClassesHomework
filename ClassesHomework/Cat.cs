using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    public class Cat : Animal
    {

        
        //private string Breed;
        //private int Age = 1;
        //private string whatDoesTheFoxSay = "woof!";
        //private bool IsSitting = false;
        public Cat()
        {
            Species = "cat";
            whatDoesTheFoxSay = "meow!";
        }
        public Cat(string breed)
        {
            Breed = breed;
            whatDoesTheFoxSay = "meow!";
        }
        public Cat(string breed, int newage)
        {
            Breed = breed;
            Age = newage;
            whatDoesTheFoxSay = "meow!";
        }        
        
    }
    // Write your Cat class here
}
