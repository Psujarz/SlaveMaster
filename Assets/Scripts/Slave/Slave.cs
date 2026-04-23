using UnityEngine;

[System.Serializable]
public class Slave
{
    public string Name;
    public string Race;

    // Zagnie¿d¿one kategorie
    public CoreStats Stats;
    public PhysicalTraits Genetics;

    // Zaktualizowany konstruktor
    public Slave(string name, string race, CoreStats stats, PhysicalTraits genetics)
    {
        Name = name;
        Race = race;
        Stats = stats;
        Genetics = genetics;
    }
}