using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collected : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject FruitSound;
    public bool Taken;

    void Start()
    {
        gameObject.transform.GetChild(0).gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            Instantiate(FruitSound);
            Taken = true;
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            Destroy(gameObject, 0.5f);

        }
    }
}
