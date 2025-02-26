using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class PlayerHealth : MonoBehaviour
{
    public int CurrentHealth = 100;
    public int MaxHealth = 100;
    public TMP_Text HealthText;
    public Transform SpawnPoint;
    public bool DealthCheck = false;
    private void Start()
    {
        HealthText.text = "HP: " + CurrentHealth + " / " + MaxHealth;
    }
    public void ChangeHealth(int Amount)
    {
        DealthCheck = false;
        CurrentHealth += Amount;
        HealthText.text = "HP: " + CurrentHealth + " / " + MaxHealth;
        if (CurrentHealth <= 0)
        {
            gameObject.SetActive(false);
            DealthCheck = true;
        }
        if (DealthCheck)
        {

            gameObject.transform.position = SpawnPoint.position;
            CurrentHealth = 100;
            HealthText.text = "HP: " + CurrentHealth + " / " + MaxHealth;
            gameObject.SetActive(true);
        }
    }
}

