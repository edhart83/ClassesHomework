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
            this.Species = "dog";
            this.whatDoesTheFoxSay = "woof!";
        }        
        public Dog(string breed)
        {
            this.Breed = breed;
            this.whatDoesTheFoxSay = "woof!";
        }
        public Dog(string breed, int newage)
        {
            this.Breed = breed;
            this.Age = newage;
            this.whatDoesTheFoxSay = "woof!";
        }
        public override string Speak()
        {
            return base.Speak();
        }
        public override string Speak(string sound)
        {
            return base.Speak(sound);
        }

    }    
}
