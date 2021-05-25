using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class gameManager : MonoBehaviour
{
    public Rigidbody2D Character;
    public GameObject Pineapple, Cherrie, Banana, rebote, Tile1, Tile2, Tile3;
    public float cherrieTaken, pineappleTaken, bananaTaken, JumpForce, MovimientoX;
    public FloorChecker floorChecker;
    public bool movimiento;

    // Start is called before the first frame update
    void Start()
    {
        movimiento = true;

        cherrieTaken = 0f;
        pineappleTaken = 0f;
        bananaTaken = 0f;

        Tile1.GetComponent<TilemapCollider2D>().enabled = false;
        Tile2.GetComponent<TilemapCollider2D>().enabled = false;
        Tile3.GetComponent<TilemapCollider2D>().enabled = false;


        Pineapple.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.3f);
        Cherrie.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.3f);
        Banana.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 0.3f);




    }

    // Update is called once per frame
    void Update()
    {


        ItemCounter(bananaTaken, Banana);
        ItemCounter(cherrieTaken, Cherrie);
        ItemCounter(pineappleTaken, Pineapple);


        if (Character.transform.position.y > 0.223f)
        {
            Tile1.GetComponent<TilemapCollider2D>().enabled = true;

        }
        if (Character.transform.position.y < 0.223f)
        {
            Tile1.GetComponent<TilemapCollider2D>().enabled = false;

        }

        if (Character.transform.position.y > 0.902f)
        {
            Tile2.GetComponent<TilemapCollider2D>().enabled = true;

        }

        if (Character.transform.position.y < 0.902f)
        {
            Tile2.GetComponent<TilemapCollider2D>().enabled = false;

        }

        if (Character.transform.position.y > 1.558)
        {
            Tile3.GetComponent<TilemapCollider2D>().enabled = true;

        }

        if (Character.transform.position.y < 1.558)
        {
            Tile3.GetComponent<TilemapCollider2D>().enabled = false;

        }
    }

    public void FixedUpdate()
    {
        if (movimiento)
        {
            BasicMovement(Character);

        }

    
        
    }


    public void CherrieTaken()
    {
        cherrieTaken++;
    }

    public void PineappleTaken()
    {
        pineappleTaken++;
    }

    public void BananaTaken()
    {
        bananaTaken++;
    }


    public void BasicMovement(Rigidbody2D toMove)
    {
        Vector3 fixedVelocity = toMove.velocity;
        fixedVelocity.x *= 0.5f;

        if (floorChecker.ableToJump)
        {
            toMove.velocity = fixedVelocity;
        }

        if (Input.GetKey("a"))
        {
            if (floorChecker.ableToJump)
            {
                toMove.GetComponent<SpriteRenderer>().flipX = true;
                toMove.transform.position = new Vector3(toMove.transform.position.x - MovimientoX, toMove.transform.position.y, toMove.transform.position.z);
            }

            if (!floorChecker.ableToJump)
            {
                toMove.GetComponent<SpriteRenderer>().flipX = true;
                toMove.transform.position = new Vector3(toMove.transform.position.x - MovimientoX, toMove.transform.position.y, toMove.transform.position.z);
       
            }
        }
        

        if (Input.GetKey("d"))
        {
            if (floorChecker.ableToJump)
            {
                toMove.GetComponent<SpriteRenderer>().flipX = false;
                toMove.transform.position = new Vector3(toMove.transform.position.x + MovimientoX, toMove.transform.position.y, toMove.transform.position.z);
            }

            if (!floorChecker.ableToJump)
            {
                toMove.GetComponent<SpriteRenderer>().flipX = false;
                toMove.transform.position = new Vector3(toMove.transform.position.x + MovimientoX, toMove.transform.position.y, toMove.transform.position.z);
              
            }
        }

        if (Input.GetKey("w") && floorChecker.ableToJump)
        {

            toMove.velocity = new Vector2(0, JumpForce);
        }
    }

    public void ItemCounter(float toCount, GameObject fruit)
    {

        if (toCount > 1)
            toCount = 1;

        if (toCount == 1)
        {
            fruit.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1f);

        }

    }
}
