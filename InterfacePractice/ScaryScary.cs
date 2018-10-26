using System;

namespace InterfacePractice
{
    public class ScaryScary : FunnyFunny, IScaryClown
    {
        //Fields
        private readonly int _numberOfScaryThings;
        
        //Properties
        public string ScaryThingIHave
        {
            get { return $"{_numberOfScaryThings} spiders"; }
        }
        
        //Constructor
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings)
            : base(funnyThingIHave)
        {
            _numberOfScaryThings = numberOfScaryThings;
        }

        //Methods
        public void ScareLittleChildren()
        {
            Console.WriteLine($"You can't have my {FunnyThingIHave}");
        }
    }
}