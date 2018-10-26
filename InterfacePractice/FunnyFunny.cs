using System;

namespace InterfacePractice
{
    public class FunnyFunny : IClown
    {
        private string _funnyThingIHave;
        public string FunnyThingIHave
        {
            get { return _funnyThingIHave; }
        }

        //ctor
        public FunnyFunny(string funnyThingIHave)
        {
            _funnyThingIHave = funnyThingIHave;
        }

        public void Honk()
        {
            Console.WriteLine($"Hi kids! I have a {_funnyThingIHave}");
        }
    }
}