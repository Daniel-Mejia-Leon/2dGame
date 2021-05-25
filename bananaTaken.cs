using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bananaTaken : MonoBehaviour
{
    public gameManager gameManager;
    public collected collected;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (collected.Taken)
        {
            gameManager.BananaTaken();

        }
    }
}
