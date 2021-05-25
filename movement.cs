using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public gameManager gameManager;
    public FloorChecker floorChecker;
    public GameObject JumpSound;
    public float transpo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        

        if (Input.GetKey("a"))
        {
            if (floorChecker.ableToJump)
            {
                gameManager.Character.GetComponent<Animator>().SetBool("run", true);
                gameManager.Character.GetComponent<Animator>().SetBool("idle", false);
                gameManager.Character.GetComponent<Animator>().SetBool("jump", false);
                gameManager.Character.GetComponent<Animator>().SetBool("desa", false);

            }

            if (!floorChecker.ableToJump)
            {
                gameManager.Character.GetComponent<Animator>().SetBool("run", false);
                gameManager.Character.GetComponent<Animator>().SetBool("idle", false);
                gameManager.Character.GetComponent<Animator>().SetBool("jump", true);
                gameManager.Character.GetComponent<Animator>().SetBool("desa", false);

            }

        }

        if (Input.GetKey("d"))
        {
            if (floorChecker.ableToJump)
            {
                gameManager.Character.GetComponent<Animator>().SetBool("run", true);
                gameManager.Character.GetComponent<Animator>().SetBool("idle", false);
                gameManager.Character.GetComponent<Animator>().SetBool("jump", false);
                gameManager.Character.GetComponent<Animator>().SetBool("desa", false);

            }

            if (!floorChecker.ableToJump)
            {
                gameManager.Character.GetComponent<Animator>().SetBool("run", false);
                gameManager.Character.GetComponent<Animator>().SetBool("idle", false);
                gameManager.Character.GetComponent<Animator>().SetBool("jump", true);
                gameManager.Character.GetComponent<Animator>().SetBool("desa", false);

            }


        }

        if (Input.GetKey("w") && Input.GetKey("d") || Input.GetKey("w") && Input.GetKey("a"))
        {
            gameManager.Character.GetComponent<Animator>().SetBool("jump", true);
            gameManager.Character.GetComponent<Animator>().SetBool("idle", false);
            gameManager.Character.GetComponent<Animator>().SetBool("run", false);
            gameManager.Character.GetComponent<Animator>().SetBool("desa", false);

        }

        if (Input.GetKey("w") && floorChecker.ableToJump)
        {

            gameManager.Character.GetComponent<Animator>().SetBool("jump", true);
            gameManager.Character.GetComponent<Animator>().SetBool("idle", false);
            gameManager.Character.GetComponent<Animator>().SetBool("run", false);
            gameManager.Character.GetComponent<Animator>().SetBool("desa", false);

            Instantiate(JumpSound);
            //Destroy(JumpSound, 0.5f);
        }

        if (!Input.GetKey("w") && !Input.GetKey("a") && !Input.GetKey("d") && !Input.GetKey("k"))
        {
            gameManager.Character.GetComponent<Animator>().SetBool("run", false);
            gameManager.Character.GetComponent<Animator>().SetBool("jump", false);
            gameManager.Character.GetComponent<Animator>().SetBool("idle", true);
            gameManager.Character.GetComponent<Animator>().SetBool("desa", false);

        }


       /* if (Input.GetKey("k"))
        {

            gameManager.movimiento = false;


            gameManager.Character.transform.position = new Vector3(gameManager.Character.transform.position.x + transpo, gameManager.Character.transform.position.y, gameManager.Character.transform.position.z);
            gameManager.Character.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

            gameManager.Character.GetComponent<Animator>().SetBool("run", false);
            gameManager.Character.GetComponent<Animator>().SetBool("jump", false);
            gameManager.Character.GetComponent<Animator>().SetBool("idle", false);
            gameManager.Character.GetComponent<Animator>().SetBool("desa", true);

        }

        if (!Input.GetKey("k"))
        {
            gameManager.movimiento = true;

        }
*/
    }
}
