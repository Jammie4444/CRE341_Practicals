using System;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class PickaxeAnimation : MonoBehaviour
{

    public Animator animator;

    public static GemCollection Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            //Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
    }
    void PickAnim()
    {
        animator.SetBool("isMining", true);
    }
}
