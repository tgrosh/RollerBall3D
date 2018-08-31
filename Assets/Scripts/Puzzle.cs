using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : Switchable {

    public override void Off(GameObject origin)
    {
        gameObject.SetActive(false);
    }

    public override void On(GameObject origin)
    {
        gameObject.SetActive(true);
    }

    public void Restart()
    {

    }
    
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
	}
}
