using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickaxe : MonoBehaviour
{
    public Animator animator;

    public void PickAnim()
    {
        animator.SetBool("isMining", true);
    }
}
