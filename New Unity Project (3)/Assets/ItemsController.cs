using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsController : MonoBehaviour
{

    private bool isBallPickedUp = false;
    private GameObject ball;


    void Start()
    {


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ball = other.gameObject;
            Debug.Log("BI");
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            ball = null;
            Debug.Log("BO");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q) && ball != null && !isBallPickedUp)
        {
            Debug.Log("q");
            ball.transform.SetParent(this.transform);
            ball.transform.position = transform.TransformPoint(0, 0, 2);
            ball.GetComponent<Rigidbody>().isKinematic = true;
            isBallPickedUp = true;
        }

        if (Input.GetKeyDown(KeyCode.E) && ball != null)
        {
            if (ball.transform.parent == this.transform)
            {
                Debug.Log("e");
                ball.GetComponent<Rigidbody>().isKinematic = false;
                ball.GetComponent<Rigidbody>().useGravity = true;
                Vector3 vec = transform.TransformDirection(Vector3.forward);
                ball.GetComponent<Rigidbody>().AddForce(vec*5, ForceMode.Impulse);
            }
            ball.transform.parent = null;
            isBallPickedUp = false;
        }
    }

}

