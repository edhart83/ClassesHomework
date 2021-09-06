using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    public class Dog {

        public string Breed;
        public int Age = 1;
        public string whatDoesTheDogSay = "woof!";
        public Dog()
        {

        }        
        public Dog(string breed)
        {
            Breed = breed;
        }
        public Dog(string breed, int newage)
        {
            Breed = breed;
            Age = newage;
        }
        public string Speak()
        {
            return whatDoesTheDogSay;
        }
        public string Speak(string sound)
        {
            whatDoesTheDogSay = sound;
            return whatDoesTheDogSay;
        }
    }    
}
