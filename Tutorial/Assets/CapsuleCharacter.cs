using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleCharacter : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                gameObject.GetComponent<Rigidbody>().transform.Translate(0, 0, 0.25f);
            }
            gameObject.GetComponent<Rigidbody>().transform.Translate(0, 0, 0.25f);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
            {
                gameObject.GetComponent<Rigidbody>().transform.Translate(0, 0, -0.25f);
            }
            gameObject.GetComponent<Rigidbody>().transform.Translate(0, 0, -0.25f);
        }

    }
}
