using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateDistance : MonoBehaviour
{
    public GameObject Character;
    private float distance;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Animator>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(gameObject.transform.position, Character.transform.position);

        if (distance < 1.5f)
        {
            gameObject.GetComponent<Animator>().enabled = true;

        }
        if (distance > 5)
        {
            gameObject.GetComponent<Animator>().enabled = false;

        }

    }
}
