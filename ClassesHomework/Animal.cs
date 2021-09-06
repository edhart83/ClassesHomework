using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    public class Animal
    {
        //protected string Breed;
        //protected int Age;        
        //protected bool IsSitting;
        //protected string Species;
        //protected string whatDoesTheFoxSay;
        public string Breed;
        public int Age;        
        public bool IsSitting;
        public string Species;
        public string whatDoesTheFoxSay;

        public Animal()
        {
            Age = 1;
            IsSitting = false;
            Species = "unknown";
            whatDoesTheFoxSay = "What am I?";
        }
        public virtual string Speak()
        {
            return whatDoesTheFoxSay;
        }
        public virtual string Speak(string sound)
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
