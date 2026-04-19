using UnityEngine;

[System.Serializable]
public class Slave
{
    public string Name;
    public string Race;

    // Zagnie¿d¿amy klasê z cechami (Kompozycja)
    public PhysicalTraits Genetics;

    // Konstruktor do szybkiego tworzenia obiektu
    public Slave(string name, string race, PhysicalTraits genetics)
    {
        Name = name;
        Race = race;
        Genetics = genetics;
    }
}