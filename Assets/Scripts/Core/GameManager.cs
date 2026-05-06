using UnityEngine;

public class GameManager : MonoBehaviour
{
    [Header("G³ówny Gracz")]
    public Player mainPlayer;

    // Metoda Start() wykonuje siê automatycznie RAZ, dok³adnie w u³amku sekundy
    // po tym, jak wciœniesz przycisk PLAY w Unity.
    void Start()
    {
        // 1. Definiujemy pocz¹tkowe statystyki gracza
        CoreStats startingStats = new CoreStats
        {
            Mind = new GeneticStat(5),
            Magic = new GeneticStat(3),
            Body = new GeneticStat(5),
            Soul = new GeneticStat(4)
        };

        // 2. Tworzymy obiekt Gracza
        mainPlayer = new Player("Bohater", startingStats);

        // 3. Wyœwietlamy powitanie w konsoli
        Debug.Log("=================================");
        Debug.Log($"Gra uruchomiona! Witaj w œwiecie gry, {mainPlayer.Name}.");
        Debug.Log($"Twój œredni potencja³ to: {mainPlayer.AveragePotential:F1}");
        Debug.Log("=================================");
    }
}