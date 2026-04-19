using UnityEngine;

[System.Serializable]
public class GeneticStat
{
    [Range(1, 9)]
    public int Tier;

    public GeneticStat(int tier)
    {
        Tier = Mathf.Clamp(tier, 1, 9);
    }
}

[System.Serializable]
public class PhysicalTraits
{
    [Header("Genetyka Cia³a")]
    public GeneticStat Height;
    public GeneticStat BonesBWH;
    public GeneticStat BreastVolume;
    public GeneticStat MusclePotential;
    public GeneticStat SkinQuality;
    public GeneticStat HairGenotype;

    [Header("Genetyka Twarzy")]
    public GeneticStat FacialHarmony;
    public GeneticStat BoneFrame;
    public GeneticStat SignalFeatures;
}