using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GemCollection : MonoBehaviour
{
    public Item item = new Item("Item Name", 1);

    private void OnTriggerEnter(Collider other)
    {
         if (other.CompareTag("Player"))
         {
            Inventory.instance.AddItem(item);
            Destroy(gameObject);
         }
    }
}
