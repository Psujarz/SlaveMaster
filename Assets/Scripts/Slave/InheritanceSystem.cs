using UnityEngine;

public static class InheritanceSystem
{
    // G³ówna metoda przyjmuj¹ca dwoje rodziców i zwracaj¹ca nowego Slave'a
    public static Slave CreateOffspring(Slave mother, Slave father, string childName, string childRace)
    {
        PhysicalTraits childGenetics = new PhysicalTraits();

        // Kategoria 1
        childGenetics.Height = InheritTrait(mother.Genetics.Height, father.Genetics.Height);
        childGenetics.BonesBWH = InheritTrait(mother.Genetics.BonesBWH, father.Genetics.BonesBWH);
        childGenetics.BreastVolume = InheritTrait(mother.Genetics.BreastVolume, father.Genetics.BreastVolume);
        childGenetics.MusclePotential = InheritTrait(mother.Genetics.MusclePotential, father.Genetics.MusclePotential);
        childGenetics.SkinQuality = InheritTrait(mother.Genetics.SkinQuality, father.Genetics.SkinQuality);
        childGenetics.HairGenotype = InheritTrait(mother.Genetics.HairGenotype, father.Genetics.HairGenotype);

        // Kategoria 2
        childGenetics.FacialHarmony = InheritTrait(mother.Genetics.FacialHarmony, father.Genetics.FacialHarmony);
        childGenetics.BoneFrame = InheritTrait(mother.Genetics.BoneFrame, father.Genetics.BoneFrame);
        childGenetics.SignalFeatures = InheritTrait(mother.Genetics.SignalFeatures, father.Genetics.SignalFeatures);

        return new Slave(childName, childRace, childGenetics);
    }

    // Prywatna metoda wykonuj¹ca wa¿one RNG dla pojedynczej cechy
    private static GeneticStat InheritTrait(GeneticStat motherStat, GeneticStat fatherStat)
    {
        float roll = Random.Range(0f, 100f);
        int avg = Mathf.RoundToInt((motherStat.Tier + fatherStat.Tier) / 2f);
        int resultTier;

        if (roll <= 25f) resultTier = motherStat.Tier;                     // 25% Matka
        else if (roll <= 50f) resultTier = fatherStat.Tier;                // 25% Ojciec
        else if (roll <= 75f) resultTier = avg;                            // 25% Œrednia
        else if (roll <= 87.5f) resultTier = Mathf.Clamp(avg + 1, 1, 9);   // 12.5% Skok Ewolucyjny
        else resultTier = Mathf.Clamp(avg - 1, 1, 9);                      // 12.5% Regresja do œredniej

        return new GeneticStat(resultTier);
    }
}