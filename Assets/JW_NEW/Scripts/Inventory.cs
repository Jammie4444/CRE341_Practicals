using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.Cinemachine;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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

    public bool gemCheck = true;

    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] float timerTime;

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

        if (diamondGems == 3 & rubyGems == 3 & emeraldGems == 3)
        {
            SceneManager.LoadScene("End");
        }
  
        if (timerTime >= 0)
        {
            timerTime += Time.deltaTime;
        }
        else if (timerTime < 0)
        {
            timerTime = 0;
        }
        int minutes = Mathf.FloorToInt(timerTime / 60);
        int seconds = Mathf.FloorToInt(timerTime % 60);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        
    }

    public void AddItem(Item itemToAdd)
    {
        if (itemToAdd.name == "Diamond")
        {
            Debug.Log("Diamond Collected");
            diamondGems += 1;
        }
        if (itemToAdd.name == "Ruby")
        {
            Debug.Log("Ruby Collected");
            rubyGems += 1;
        }
        if (itemToAdd.name == "Emerald")
        {
            Debug.Log("Emerald Collected");
            emeraldGems += 1;
        }

        bool itemExists = false;

        foreach (Item item in items)
        {
            if (item.name == itemToAdd.name)
            {
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
