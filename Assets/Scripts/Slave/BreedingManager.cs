using UnityEngine;
using System.Linq; // Potrzebne do ³atwego przeszukiwania listy

public class BreedingManager : MonoBehaviour
{
    [Header("Ustawienia Komendy")]
    public string inputName1 = "Gideon";
    public string inputName2 = "Aeloria";

    [ContextMenu("Generuj Potomka")]
    public void ExecuteBreedingCommand()
    {
        // 1. Szukamy rodziców w bazie danych po imieniu
        Slave parent1 = SlaveDatabase.Roster.FirstOrDefault(c => c.Name == inputName1);
        Slave parent2 = SlaveDatabase.Roster.FirstOrDefault(c => c.Name == inputName2);

        if (parent1 == null || parent2 == null)
        {
            Debug.LogError("B³¹d: Nie znaleziono jednego lub obu rodziców w bazie danych!");
            return;
        }

        // 2. Tworzymy potomka (System dziedziczenia)
        Slave child = InheritanceSystem.CreateOffspring(parent1, parent2, "Potomek", parent1.Race);

        // 3. Wyœwietlamy sformatowany raport w konsoli
        DisplayChildStats(child);
    }

    private void DisplayChildStats(Slave c)
    {
        string report = "";

        // Sekcja 1: Podstawowe informacje
        report += "1. PODSTAWOWE INFORMACJE\n";
        report += $"Imiê: {c.Name}\n";
        report += $"Rasa: {c.Race}\n";
        report += "----------------\n";

        // Sekcja 2: Statystyki G³ówne (Stats)
        report += "2. STATYSTYKI\n";
        report += $"Mind = {c.Stats.Mind.Tier}\n";
        report += $"Magic = {c.Stats.Magic.Tier}\n";
        report += $"Body = {c.Stats.Body.Tier}\n";
        report += $"Soul = {c.Stats.Soul.Tier}\n";
        report += "----------------\n";

        // Sekcja 3: Cechy Cia³a (Genetics - Body)
        report += "3. CECHY CIA£A\n";
        report += $"Height = {c.Genetics.Height.Tier}\n";
        report += $"BonesBWH = {c.Genetics.BonesBWH.Tier}\n";
        report += $"Stamina = {c.Genetics.BreastVolume.Tier}\n";
        report += $"SkinQuality = {c.Genetics.SkinQuality.Tier}\n";
        report += $"HairGenotype = {c.Genetics.HairGenotype.Tier}\n";
        report += "----------------\n";

        // Sekcja 4: Cechy Twarzy (Genetics - Face)
        report += "4. CECHY TWARZY\n";
        report += $"FacialHarmony = {c.Genetics.FacialHarmony.Tier}\n";
        report += $"BoneFrame = {c.Genetics.BoneFrame.Tier}\n";
        report += $"SignalFeatures = {c.Genetics.SignalFeatures.Tier}\n";

        Debug.Log(report);
    }
}