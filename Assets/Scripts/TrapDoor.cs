using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapDoor : Switchable {
    Collider thisCollider;

    public override void Off(GameObject origin)
    {
        gameObject.SetActive(false);
    }

    public override void On(GameObject origin)
    {
        gameObject.SetActive(true);
    }

    // Use this for initialization
    void Start () {
        thisCollider = GetComponent<Collider>();
        gameObject.SetActive(true);
	}

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit) && hit.collider == thisCollider)
            {
                Off(gameObject);
            }            
        }
    }
}
