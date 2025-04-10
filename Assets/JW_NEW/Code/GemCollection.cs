using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.Cinemachine;

public class GemCollection : MonoBehaviour
{
    public Item item = new Item("Item Name", 1);

    //public Pickaxe pickaxe;

    public Animator animator;

    private void OnTriggerEnter(Collider other)
    {
         if (other.CompareTag("Player"))
         {
            Inventory.instance.AddItem(item);
            animator.SetBool("isMining", true);
            //pickaxe.PickAnim();
            Destroy(gameObject);
        }
    }
}
