using UnityEngine;

[System.Serializable]
public class GeneticStat
{
    [Range(1, 8)]
    public int Tier;

    public GeneticStat(int tier)
    {
        Tier = Mathf.Clamp(tier, 1, 8);
    }
}

// Nasza nowa lista ras
public enum RaceType
{
    Human,
    Elf,
    Demon,
    Beastman,
    Vampire
}

[System.Serializable]
public class PhysicalTraits
{
    [Header("Genetyka Cia³a")]
    public GeneticStat Height;
    public GeneticStat BonesBWH;
    public GeneticStat BreastVolume;
    public GeneticStat SkinQuality;
    public GeneticStat HairGenotype;

    [Header("Genetyka Twarzy")]
    public GeneticStat FacialHarmony;
    public GeneticStat BoneFrame;
    public GeneticStat SignalFeatures;
}