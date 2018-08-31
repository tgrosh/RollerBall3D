using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncy : MonoBehaviour {
    public float bounceForce;

    private void Reset()
    {
        bounceForce = 1f;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.rigidbody != null)
        {
            collision.rigidbody.AddForce(collision.contacts[0].normal * bounceForce, ForceMode.Impulse);
        }
    }
}
