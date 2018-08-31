using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : Switchable
{
    public bool running;
    public float fanForce;
    public float fanRange;
    public BoxCollider rangeCollider;
    public bool ballOnly;

    public override void Off(GameObject origin)
    {
        running = false;
    }

    public override void On(GameObject origin)
    {
        running = true;
    }

    private void Reset()
    {
        fanForce = 20f;
        fanRange = 10f;
        ballOnly = true;
    }

    // Use this for initialization
    void Start () {
        Vector3 fanRangeVector = new Vector3(fanRange, 1, 1);

        rangeCollider.gameObject.transform.localPosition += Vector3.Scale(Vector3.right, fanRangeVector/2);
        rangeCollider.gameObject.transform.localScale = fanRangeVector;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (ballOnly && other.gameObject.GetComponentInParent<Ball>() == null)
        {
            return;
        }

        Rigidbody otherBody = other.GetComponentInParent<Rigidbody>();
        float fanRangeModifier = Vector3.Magnitude(other.transform.position - transform.position);
        otherBody.AddForce(transform.right * fanForce * (Mathf.Max(fanRange-fanRangeModifier,0)));
    }
}
