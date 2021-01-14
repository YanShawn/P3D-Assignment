using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    [SerializeField] public GameObject  obj;
    [SerializeField] private Vector3 ballPosition;

    private BoxCollider boxCollider;
    private Door door;
    private bool enterCollider = false;

    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
        door = GameObject.Find("Door").GetComponent<Door>();
    }

    private void OnTriggerEnter(Collider boxCollider)
    {
        enterCollider = true;

        Debug.Log("ENTER");
    }

    private void OnTriggerExit(Collider boxCollider)
    {
        enterCollider = false;
        Debug.Log("exit");
    }
    void Update()
    {
        if (enterCollider == true)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                Debug.Log("F");

                if (door.GetIsOpen())
                {
                    door.CloseDoorMethod();
                }

                else
                {
                    door.OpenDoorMethod();
                    if (obj != null)
                    {
                        Instantiate(obj, ballPosition, new Quaternion());
                    }

                }
            }

        }
    }
}
