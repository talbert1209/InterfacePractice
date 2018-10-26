namespace InterfacePractice
{
    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }

        void ScareLittleChildren();
    }
}

