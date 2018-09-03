using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseTrigger : Triggerable {
    public override void OnTrigger(GameObject source)
    {
        PuzzleManager.instance.restartPuzzle();
    }

}
