using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor;

public class ItemUI : MonoBehaviour
{
    public Text nameText;
    public Image imgItem;
    public Text descriptionText;
    public Text damageText;
    private Item itemFeatured;
    [SerializeField]
    private Item [] itemsFeatured;

    // Start is called before the first frame update
    void Start()
    {
        itemFeatured = Resources.Load<Item>("Weapons/EspadaVorpal");
        //itemFeatured = Resources.Load("1") as Item;
        itemsFeatured = Resources.LoadAll<Item>("Weapons/");
        
        ShowInfo(itemFeatured);

        Item item2 = new Item();
        item2.name = "Item2";
        item2.itemName = "Escudo de corpo";
        item2.itemDescription = "Cobre todo o corpo e dimuniu deslocamento";
        item2.itemDamage = 10;

        #if UNITY_EDITOR
            AssetDatabase.CreateAsset(item2,"Assets/Resources/Weapons/"+item2.name+".asset");
        #endif
    }

    void ShowInfo(Item i){
        nameText.text = i.itemName;
        imgItem.sprite = i.itemSprite;
        descriptionText.text = i.itemDescription;
        damageText.text = i.itemDamage.ToString();
    }
}
