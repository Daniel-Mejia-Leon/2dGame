/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class TouchMove : MonoBehaviour
{
    public Rigidbody2D Character;
    public float JumpForce, MovementX;
    public FloorChecker floorChecker;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Character.transform.position = new Vector3(Character.transform.position.x + MovementX, Character.transform.position.y, Character.transform.position.z);

        if (floorChecker.ableToJump && Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Character.velocity = new Vector2(0, JumpForce);
        }

        *//*if (Input.touchCount > 1 && Input.GetTouch(1).phase == TouchPhase.Began)
        {
            Character.transform.position = new Vector3(Character.transform.position.x + MovementX, Character.transform.position.y, Character.transform.position.z);
        }*//*

    }
}
*/