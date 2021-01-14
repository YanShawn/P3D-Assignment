using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    private Animator animator;

    private bool isOpen = false;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {

    }
    public void OpenDoorMethod()
    {
        animator.SetBool("isOpening", true);
        isOpen = !isOpen;
        Debug.Log("O");
    }

    public void CloseDoorMethod()
    {
        animator.SetBool("isOpening", false);
        isOpen = !isOpen;
        Debug.Log("C");
    }


    public bool GetIsOpen()
    {
        return isOpen;
    }
    public void SetIsOpen(bool b)
    {
        isOpen = b;
    }
}

