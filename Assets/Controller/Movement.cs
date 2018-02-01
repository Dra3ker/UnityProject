using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    Vector3 moveToward;
    public int speed = 5;
    Rigidbody2D rb2d;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0)) {
            var mousePos = Input.mousePosition;
            moveToward = Camera.main.ScreenToWorldPoint(mousePos);
            //Debug.Log("Preesed button "+ moveToward + "_____" + rb2d.position.x + " : " + rb2d.position.y);

        }
        Vector2 dif = new Vector2(moveToward.x - rb2d.position.x, moveToward.y - rb2d.position.y);
        //Debug.Log(dif.magnitude);
        if (dif.magnitude > 0.50) {

            dif.Normalize();
            dif.x *= speed;
            dif.y *= speed;

            rb2d.velocity = dif;
        }
        else
        {
            rb2d.velocity = new Vector2();
        }

	}
}
