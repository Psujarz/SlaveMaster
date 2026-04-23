using UnityEngine;

[System.Serializable]
public class Slave
{
    public string Name;
    public RaceType Race;

    // Zagnie¿d¿one kategorie
    public CoreStats Stats;
    public PhysicalTraits Genetics;

    // Zaktualizowany konstruktor
    public Slave(string name, RaceType race, CoreStats stats, PhysicalTraits genetics)
    {
        Name = name;
        Race = race;
        Stats = stats;
        Genetics = genetics;
    }
}