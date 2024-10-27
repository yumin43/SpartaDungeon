using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIConditions : MonoBehaviour
{
    public Condition health;

    // Start is called before the first frame update
    void Start()
    {
        CharacterManager.Instance.Player.condition.uIConditions = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
