using UnityEngine;

public static class InheritanceSystem
{
    public static Slave CreateOffspring(Slave parentA, Slave parentB, string childName, RaceType childRace)
    {
        // 1. Dziedziczenie statystyk g³ównych
        CoreStats childStats = new CoreStats();
        childStats.Mind = InheritTrait(parentA.Stats.Mind, parentB.Stats.Mind);
        childStats.Magic = InheritTrait(parentA.Stats.Magic, parentB.Stats.Magic);
        childStats.Body = InheritTrait(parentA.Stats.Body, parentB.Stats.Body);
        childStats.Soul = InheritTrait(parentA.Stats.Soul, parentB.Stats.Soul);

        // 2. Dziedziczenie cech fizycznych
        PhysicalTraits childGenetics = new PhysicalTraits();
        childGenetics.Height = InheritTrait(parentA.Genetics.Height, parentB.Genetics.Height);
        childGenetics.BonesBWH = InheritTrait(parentA.Genetics.BonesBWH, parentB.Genetics.BonesBWH);
        childGenetics.BreastVolume = InheritTrait(parentA.Genetics.BreastVolume, parentB.Genetics.BreastVolume);
        childGenetics.SkinQuality = InheritTrait(parentA.Genetics.SkinQuality, parentB.Genetics.SkinQuality);
        childGenetics.HairGenotype = InheritTrait(parentA.Genetics.HairGenotype, parentB.Genetics.HairGenotype);
        childGenetics.FacialHarmony = InheritTrait(parentA.Genetics.FacialHarmony, parentB.Genetics.FacialHarmony);
        childGenetics.BoneFrame = InheritTrait(parentA.Genetics.BoneFrame, parentB.Genetics.BoneFrame);
        childGenetics.SignalFeatures = InheritTrait(parentA.Genetics.SignalFeatures, parentB.Genetics.SignalFeatures);

        // Zwracamy now¹ postaæ z kompletem danych
        return new Slave(childName, childRace, childStats, childGenetics);
    }

    // Zaktualizowana matematyka: S³abszy vs Silniejszy
    private static GeneticStat InheritTrait(GeneticStat statA, GeneticStat statB)
    {
        // Rozpoznajemy, który gen jest s³abszy, a który silniejszy
        int weakerTier = Mathf.Min(statA.Tier, statB.Tier);
        int strongerTier = Mathf.Max(statA.Tier, statB.Tier);

        // Obliczamy œredni¹
        int avgTier = Mathf.RoundToInt((weakerTier + strongerTier) / 2f);

        // Rzut kostk¹ (0.0 do 100.0)
        float roll = Random.Range(0f, 100f);
        int resultTier;

        if (roll <= 25f)
        {
            resultTier = weakerTier;                         // 25% S³abszy gen
        }
        else if (roll <= 50f)
        {
            resultTier = strongerTier;                       // 25% Lepszy gen
        }
        else if (roll <= 75f)
        {
            resultTier = avgTier;                            // 25% Œrednia
        }
        else
        {
            resultTier = Mathf.Clamp(strongerTier + 1, 1, 9); // 25% Skok Ewolucyjny (Lepszy + 1)
        }

        return new GeneticStat(resultTier);
    }
}