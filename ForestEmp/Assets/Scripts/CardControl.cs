using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardControl : MonoBehaviour {

    public GameObject PinkCard;
    public GameObject PurpleCard;
    public GameObject RedCard;
    public GameObject BlueCard;
    public GameObject YellowCard;
    public GameObject BrownCard;
    public GameObject OrangeCard;
    //public GameObject Buy;

    // Use this for initialization
    void Start()
    {
        PinkCard.SetActive(false);
        PurpleCard.SetActive(false);
        RedCard.SetActive(false);
        BlueCard.SetActive(false);
        YellowCard.SetActive(false);
        BrownCard.SetActive(false);
        OrangeCard.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "waypoint")
        {
            BrownCard.SetActive(true);
        }
        if (collision.gameObject.tag == "waypoint1")
        {
            BlueCard.SetActive(true);
        }
        if (collision.gameObject.tag == "waypoint2")
        {
            PinkCard.SetActive(true);
        }
        if (collision.gameObject.tag == "waypoint3")
        {
            OrangeCard.SetActive(true);
        }
        if (collision.gameObject.tag == "waypoint4")
        {
            RedCard.SetActive(true);
        }
        if (collision.gameObject.tag == "waypoint5")
        {
            YellowCard.SetActive(true);
        }
        /*if (collision.gameObject.tag == "waypoint6")
        {
            DemoCard.SetActive(false);
        }*/
        if (collision.gameObject.tag == "waypoint7")
        {
            PurpleCard.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "waypoint")
        {
            BrownCard.SetActive(false);
        }
        if (collision.gameObject.tag == "waypoint1")
        {
            BlueCard.SetActive(false);
        }
        if (collision.gameObject.tag == "waypoint2")
        {
            PinkCard.SetActive(false);
        }
        if (collision.gameObject.tag == "waypoint3")
        {
            OrangeCard.SetActive(false);
        }
        if (collision.gameObject.tag == "waypoint4")
        {
            RedCard.SetActive(false);
        }
        if (collision.gameObject.tag == "waypoint5")
        {
            YellowCard.SetActive(false);
        }
        /*if (collision.gameObject.tag == "waypoint6")
        {
            DemoCard.SetActive(false);
        }*/
        if (collision.gameObject.tag == "waypoint7")
        {
            PurpleCard.SetActive(false);
        }
    }

    /*void ButtonClicked()
    {
        BrownCard.SetActive(false);
        BlueCard.SetActive(false);
        PinkCard.SetActive(false);
        OrangeCard.SetActive(false);
        RedCard.SetActive(false);
        YellowCard.SetActive(false);
        PurpleCard.SetActive(false);
    }*/
}
