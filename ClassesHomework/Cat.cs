using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    public class Cat : Animal
    {
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
        public override string Speak()
        {
            return base.Speak();
        }
        public override string Speak(string sound)
        {
            return base.Speak(sound);
        }
    }
    // Write your Cat class here
}
