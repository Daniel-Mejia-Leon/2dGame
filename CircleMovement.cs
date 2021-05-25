using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleMovement : MonoBehaviour
{
    public float VelMov, distance;
    public GameObject From, hongo;
    public bool regreso;

    // Start is called before the first frame update
    void Start()
    {

    }


    void Update()
    {

        distance = Vector2.Distance(hongo.transform.position, From.transform.position);

        Debug.Log(distance);

        

        if (distance == From.transform.position.x)
        {
            regreso = false;

        }

        if (distance == 1)
        {
            regreso = true;

        }

        if (regreso)
        {
            hongo.transform.position = new Vector3(gameObject.transform.position.x + VelMov, hongo.transform.position.y, hongo.transform.position.z);

        }
        
        if (!regreso)
        {
            hongo.transform.position = new Vector3(hongo.transform.position.x - VelMov, hongo.transform.position.y, hongo.transform.position.z);

        }

    }

}
