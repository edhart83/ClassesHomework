using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    public class Dog : Animal{

        //private string Breed;
        //private int Age = 1;
        //private string whatDoesTheDogSay = "woof!";
        //private bool IsSitting = false;
        public Dog()
        {
            Species = "dog";
            whatDoesTheFoxSay = "woof!";
        }        
        public Dog(string breed)
        {
            Breed = breed;
            whatDoesTheFoxSay = "woof!";
        }
        public Dog(string breed, int newage)
        {
            Breed = breed;
            Age = newage;
            whatDoesTheFoxSay = "woof!";
        }
                
        
    }    
}
