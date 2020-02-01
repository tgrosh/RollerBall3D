using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle : Switchable {
    [HideInInspector]
    public BallStart ballStart;
    [HideInInspector]
    public Cinemachine.CinemachineVirtualCamera puzzleCamera;

    void Awake()
    {
        ballStart = GetComponentInChildren<BallStart>();
        puzzleCamera = GetComponentInChildren<Cinemachine.CinemachineVirtualCamera>();
    }

    public override void Off(GameObject origin)
    {
        gameObject.SetActive(false);
    }

    public override void On(GameObject origin)
    {
        gameObject.SetActive(true);
    }
}
