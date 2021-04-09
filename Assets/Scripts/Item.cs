using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "Item/Weapon")]
public class Item : ScriptableObject
{
    public string itemName = "item";
    public Sprite itemSprite;
    public string itemDescription;
    public float itemDamage;
}
