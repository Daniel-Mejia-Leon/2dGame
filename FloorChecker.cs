using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorChecker : MonoBehaviour
{
    // Start is called before the first frame update

    public bool ableToJump;
    public GameObject Character;

    void Start()
    {
        ableToJump = false;
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            ableToJump = true;
        }

        if (collision.CompareTag("Platform"))
        {
            Character.transform.parent = collision.transform;
            ableToJump = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Ground"))
        {
            ableToJump = false;
        }

        if (collision.CompareTag("Platform"))
        {
            Character.transform.parent = null;

            ableToJump = false;
        }

    }
}


