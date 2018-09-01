using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slow : MonoBehaviour {
    public float slowForce;

    private void Reset()
    {
        slowForce = 1.025f;
    }
    
    private void OnCollisionStay(Collision collision)
    {
        if (collision.rigidbody != null)
        {
            collision.rigidbody.velocity *= 1f/slowForce;
        }
    }
}
