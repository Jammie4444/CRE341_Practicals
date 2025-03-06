using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Cinemachine;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public TMP_Text diamondText;
    public TMP_Text rubyText;
    public TMP_Text emeraldText;

    public int diamondGems = 0;
    public int rubyGems = 0;
    public int emeraldGems = 0;

    public static Inventory instance;  
    public List<Item> items = new List<Item>();

    void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        else 
            instance = this;
    }

    void Update()
    {
        diamondText.text = "Diamonds: " + diamondGems + "/3";
        rubyText.text = "Rubys: " + rubyGems + "/3";
        emeraldText.text = "Emeralds: " + emeraldGems + "/3";
    }

    public void AddItem(Item itemToAdd)
    {
        bool itemExists = false;

        foreach (Item item in items)
        {
            if (item.name == itemToAdd.name)
            {
                if (itemToAdd.name == "Diamond")
                {
                    Debug.Log("Diamond Collected");
                    diamondGems += 1;
                }
                if (itemToAdd.name == "Ruby")
                {
                    Debug.Log("Ruby Collected");
                    rubyGems++; 
                }
                if (itemToAdd.name == "Emerald")
                {
                    Debug.Log("Emerald Collected");
                    emeraldGems++;
                }
                item.count += itemToAdd.count;
                itemExists = true;  
                break;
            }
        }
        if (!itemExists)
        {
            items.Add(itemToAdd);
        }
        Debug.Log(itemToAdd.count + " " +  itemToAdd.name + " added to inventory");
    }

    //public void RemoveItem(Item itemToRemove)
    //{
    //    foreach (var item in items)
    //    {
    //        if(item.name == itemToRemove.name)
    //        {
    //            item.count -= itemToRemove.count;
    //            if(item.count <= 0)
    //            {
    //                items.Remove(itemToRemove); 
    //            }
    //            break;
    //        }
    //    }
    //    Debug.Log(itemToRemove.count + " " + itemToRemove.name + "removed from inventory");
    //}
}
