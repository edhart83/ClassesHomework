using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesHomework
{
    public class Animal
    {
        public string Breed {get; protected set;}
        //protected int Age;        
        //protected bool IsSitting;
        //protected string Species;
        //protected string whatDoesTheFoxSay;
        
        public int Age { get; protected set; }
        public bool IsSitting { get; protected set; }
        public string Species { get; protected set; }
        public string whatDoesTheFoxSay { get; protected set; }

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
