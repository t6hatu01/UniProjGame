using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class testtp : MonoBehaviour {

    public GameObject Player1, Player2;
    public Transform Waypoint;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "p1")
        {
            Player1.transform.position = Waypoint.transform.position;
        }

         if (collision.gameObject.tag == "p2")
        {
            Player2.transform.position = Waypoint.transform.position;
        }
    }
}
