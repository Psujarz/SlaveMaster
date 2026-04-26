using UnityEngine;

[System.Serializable]
public class Player
{
    public string Name;

    // Gracz korzysta z tego samego systemu 4 statystyk co towarzysze
    public CoreStats Stats;

    // Konstruktor do tworzenia gracza
    public Player(string name, CoreStats stats)
    {
        Name = name;
        Stats = stats;
    }

    // W³aœciwoœæ (Property), która automatycznie wylicza œredni¹ potencja³u
    // Dziêki temu nie musisz jej wpisywaæ rêcznie - zawsze bêdzie aktualna
    public float AveragePotential => (Stats.Mind.Tier + Stats.Magic.Tier + Stats.Body.Tier + Stats.Soul.Tier) / 4f;
}