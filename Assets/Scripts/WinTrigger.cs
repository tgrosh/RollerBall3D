using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : Triggerable {
    public override void OnTrigger(GameObject source)
    {
        PuzzleManager.instance.loadNextPuzzle();
    }

}
