using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : Switchable {
    public Transform ballStart;
    public Cinemachine.CinemachineVirtualCamera puzzleCamera;
    
    public override void Off(GameObject origin)
    {
        gameObject.SetActive(false);
    }

    public override void On(GameObject origin)
    {
        gameObject.SetActive(true);
    } 
}
