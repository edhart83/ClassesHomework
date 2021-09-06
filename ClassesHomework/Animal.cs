using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    public class Animal
    {
        public string Breed;
        public int Age = 1;
        public bool IsSitting = false;
        public string Species = "unknown";
        public string whatDoesTheFoxSay = "What am I?";
        public Animal()
        {

        }
        public string Speak()
        {
            return whatDoesTheFoxSay;
        }
        public string Speak(string sound)
        {
            whatDoesTheFoxSay = sound;
            return whatDoesTheFoxSay;
        }
        public void Sit()
        {
            IsSitting = true;
        }
        public void Stand()
        {
            IsSitting = false;
        }
        public void CelebrateBirthday()
        {
            Age++;
        }
    }
}
