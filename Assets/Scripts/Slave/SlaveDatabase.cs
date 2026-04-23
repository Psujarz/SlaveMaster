using System.Collections.Generic;

public static class SlaveDatabase
{
    // Gotowa lista predefiniowanych postaci
    public static List<Slave> Roster = new List<Slave>()
    {
        // 1. Ludzki wojownik (Zbalansowany, silne cia³o)
        new Slave(
            "Gideon",
            RaceType.Human,
            new CoreStats {
                Mind = new GeneticStat(4), Magic = new GeneticStat(2), Body = new GeneticStat(7), Soul = new GeneticStat(5)
            },
            new PhysicalTraits {
                Height = new GeneticStat(6), BonesBWH = new GeneticStat(6), BreastVolume = new GeneticStat(7),
                SkinQuality = new GeneticStat(4), HairGenotype = new GeneticStat(4),
                FacialHarmony = new GeneticStat(5), BoneFrame = new GeneticStat(6), SignalFeatures = new GeneticStat(4)
            }
        ),

        // 2. Elfia czarodziejka (Wysoka magia, doskona³a uroda, s³abe cia³o)
        new Slave(
            "Aeloria",
            RaceType.Elf,
            new CoreStats {
                Mind = new GeneticStat(7), Magic = new GeneticStat(8), Body = new GeneticStat(2), Soul = new GeneticStat(6)
            },
            new PhysicalTraits {
                Height = new GeneticStat(5), BonesBWH = new GeneticStat(3), BreastVolume = new GeneticStat(3),
                SkinQuality = new GeneticStat(8), HairGenotype = new GeneticStat(8),
                FacialHarmony = new GeneticStat(8), BoneFrame = new GeneticStat(4), SignalFeatures = new GeneticStat(7)
            }
        ),

        // 3. Demoniczny berserker (Potê¿ne statystyki fizyczne i dusza, toporna twarz)
        new Slave(
            "Kael'Thar",
            RaceType.Demon,
            new CoreStats {
                Mind = new GeneticStat(3), Magic = new GeneticStat(5), Body = new GeneticStat(8), Soul = new GeneticStat(8)
            },
            new PhysicalTraits {
                Height = new GeneticStat(8), BonesBWH = new GeneticStat(8), BreastVolume = new GeneticStat(8),
                SkinQuality = new GeneticStat(5), HairGenotype = new GeneticStat(2),
                FacialHarmony = new GeneticStat(3), BoneFrame = new GeneticStat(8), SignalFeatures = new GeneticStat(5)
            }
        ),

        // 4. Bestio³ak - Zwiadowca (Niska magia, wysoka wytrzyma³oœæ i geny przetrwania)
        new Slave(
            "Fenrir",
            RaceType.Beastman,
            new CoreStats {
                Mind = new GeneticStat(5), Magic = new GeneticStat(1), Body = new GeneticStat(6), Soul = new GeneticStat(4)
            },
            new PhysicalTraits {
                Height = new GeneticStat(7), BonesBWH = new GeneticStat(5), BreastVolume = new GeneticStat(7),
                SkinQuality = new GeneticStat(6), HairGenotype = new GeneticStat(8),
                FacialHarmony = new GeneticStat(4), BoneFrame = new GeneticStat(6), SignalFeatures = new GeneticStat(6)
            }
        ),

        // 5. Wampirzy arystokrata (Wybitny umys³, mroczna magia, nienaganna symetria)
        new Slave(
            "Vladislaus",
            RaceType.Vampire,
            new CoreStats {
                Mind = new GeneticStat(8), Magic = new GeneticStat(7), Body = new GeneticStat(5), Soul = new GeneticStat(2)
            },
            new PhysicalTraits {
                Height = new GeneticStat(6), BonesBWH = new GeneticStat(4), BreastVolume = new GeneticStat(6),
                SkinQuality = new GeneticStat(7), HairGenotype = new GeneticStat(6),
                FacialHarmony = new GeneticStat(8), BoneFrame = new GeneticStat(7), SignalFeatures = new GeneticStat(8)
            }
        )
    };
}