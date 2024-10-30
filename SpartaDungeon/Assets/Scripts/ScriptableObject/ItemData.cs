using UnityEngine;

public enum ItemType
{
    immediate,
    Consumable
}

[CreateAssetMenu(fileName = "Item", menuName = "newItem", order = 0)]
public class ItemData : ScriptableObject
{
    [Header("Info")]
    public string displayName;
    public string description;
    public ItemType type;
    public Sprite icon;
    public GameObject dropPrefab;

    [Header("Stacking")]
    public bool canStack;
    public int maxStackAmount;

    [Header("Effect")]
    public float duration;
    public float changedValue;
}
