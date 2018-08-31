using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : Triggerable {
    public Puzzle currentPuzzle;
    public Puzzle nextPuzzle;

    public override void OnTrigger(GameObject source)
    {
        currentPuzzle.Off(null);
        nextPuzzle.On(null);
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
