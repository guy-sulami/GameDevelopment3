﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMotion : MonoBehaviour
{
    public Animator animator;
    public GameObject door_axis;
    public bool isOpen;
    // Start is called before the first frame update
    void Start()
    {
        animator = door_axis.GetComponent<Animator>();
        isOpen = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("NPC") || other.CompareTag("MainCamera"))
        {
            animator.SetTrigger("Open");
            isOpen = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (isOpen){
            animator.SetTrigger("Close");
            isOpen = false;
        }
    }
}
