using System;
using UnityEngine;

public class PlayerCondition : MonoBehaviour
{
    public UIConditions uIConditions;
    Condition health { get { return uIConditions.health; } }

    void Update()
    {
        health.Sub(health.passiveValue * Time.deltaTime);
        
        if (health.curValue == 0f)
        {
            Die();
        }
    }

    public void Heal(float amount)
    {
        health.Add(amount);
    }

    public void Die()
    {
        Debug.Log("죽었다!");
    }
}
