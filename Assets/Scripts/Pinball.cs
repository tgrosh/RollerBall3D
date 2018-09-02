using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinball : MonoBehaviour {
    public float pinballForce;

    private bool pulling;
    private float currentPull;
    private Vector3 originalPosition;

	// Use this for initialization
	void Start () {
        originalPosition = transform.position;
    }
	
	// Update is called once per frame
	void Update () {
        pulling = Input.GetMouseButton(0);

        if (pulling)
        {
            currentPull += Time.deltaTime;
            if (currentPull > 1)
            {
                currentPull = 1;
            }
        } else if (currentPull > 0)
        {
            currentPull = 0;
        }

        transform.localScale = new Vector3(2 - currentPull, transform.localScale.y, transform.localScale.z);
        GetComponent<Rigidbody>().MovePosition(originalPosition - new Vector3(0, (currentPull / 2), 0));
    }
}
