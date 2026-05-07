using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("G³ówny Gracz")]
    public Player mainPlayer;

    [Header("Ekonomia i Czas")]
    public int currentDay = 1;
    public int gold = 100; // Pieni¹dze na start

    void Start()
    {
        // 1. Inicjalizacja gracza (to co mieliœmy wczoraj)
        CoreStats startingStats = new CoreStats
        {
            Mind = new GeneticStat(5),
            Magic = new GeneticStat(3),
            Body = new GeneticStat(5),
            Soul = new GeneticStat(4)
        };
        mainPlayer = new Player("Bohater", startingStats);

        // 2. Powitanie z nowymi danymi
        Debug.Log("=================================");
        Debug.Log($"Witaj {mainPlayer.Name}! Rozpoczynasz grê o potêgê.");
        Debug.Log($"Dzieñ: {currentDay} | Z³oto: {gold}");
        Debug.Log("=================================");
    }

    // Nowa mechanika: Up³yw czasu! (Mo¿esz to klikaæ w Inspektorze)
    [ContextMenu("Zakoñcz Dzieñ")]
    public void PassDay()
    {
        currentDay++;
        int dailyIncome = 50; // Dzienna wyp³ata (w przysz³oœci np. zysk z chowañców)

        gold += dailyIncome;

        Debug.Log($"--- Nasta³ Dzieñ {currentDay} ---");
        Debug.Log($"Podsumowanie dnia: Zarobi³eœ {dailyIncome} z³ota. Twój skarbiec: {gold}");
    }
}