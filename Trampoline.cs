using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    public gameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        //gameObject.GetComponent<Animator>().enabled = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("floorChecker"))
        {
            //gameObject.GetComponent<Animator>().enabled = true;
            gameObject.GetComponent<Animator>().SetBool("onIt", true);
            gameManager.Character.velocity = new Vector2(0, gameManager.JumpForce + 1);
            Instantiate(gameManager.rebote);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("floorChecker"))
        {
            //gameObject.GetComponent<Animator>().enabled = false;
            gameObject.GetComponent<Animator>().SetBool("onIt", false);

            //gameObject.GetComponent<SpriteRenderer>().sprite = "Jump (28x28)_0";

        }

    }

}
