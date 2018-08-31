using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTrigger : Triggerable {
    public Puzzle currentPuzzle;

    public override void OnTrigger(GameObject source)
    {
        currentPuzzle.Restart();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
