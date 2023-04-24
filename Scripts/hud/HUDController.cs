using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUDController : MonoBehaviour
{
    public Text coinText;
    public Text healthText;

    private int coinCount = 0;
    private int health = 3;

    void Update()
    {
        // Atualizar texto da HUD
        coinText.text = "Moedas: " + coinCount;
        healthText.text = "Vida: " + health;
    }

    public void AddCoin()
    {
        // Adicionar moeda
        coinCount++;
    }

    public void TakeDamage()
    {
        // Reduzir vida
        health--;
    }
}
