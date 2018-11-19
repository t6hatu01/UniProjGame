using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardControl : MonoBehaviour {

    public GameObject DemoCard;

    // Use this for initialization
    void Start()
    {
        DemoCard.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "waypoint")
        {
            //Destroy(collision.gameObject);
            DemoCard.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "waypoint")
        {
            DemoCard.SetActive(false);
        }
    }
}
