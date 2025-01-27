using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int CurrentHealth;
    public int MaxHealth;

    public void changeHealth(int Amount)
    {
        CurrentHealth += Amount;
        if(CurrentHealth <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
