using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GemCollection : MonoBehaviour
{
    public Item item = new Item("Item Name", 1);

    PickaxeAnimation PickaxeAnimation;
    
    private void OnTriggerEnter(Collider other)
    {
         if (other.CompareTag("Player"))
         {
            //PickaxeAnimation.PickAnim();
            Inventory.instance.AddItem(item);
            Destroy(gameObject);
         }
    }
}
