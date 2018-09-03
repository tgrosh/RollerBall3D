using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleManager : MonoBehaviour {
    public Puzzle[] puzzles;
    public static PuzzleManager instance;
    public Ball ballPrefab;
    [HideInInspector] public Ball ball;

    private int currentPuzzleIndex = -1;
    private Puzzle currentPuzzle;

    // Use this for initialization
    void Start () {
        if (instance == null)
        {
            instance = this;
        }

        loadNextPuzzle();
    }

    public void loadNextPuzzle()
    {
        if (puzzles.Length > currentPuzzleIndex + 1)
        {
            currentPuzzleIndex++;
            loadPuzzle(currentPuzzleIndex);
        }
    }

    private void loadPuzzle(int puzzleIndex)
    {
        if (currentPuzzle != null)
        {
            Destroy(currentPuzzle.gameObject);
        }
        currentPuzzle = Instantiate(puzzles[puzzleIndex]);

        if (ball != null)
        {
            Destroy(ball.gameObject);
        }
        ball = Instantiate(ballPrefab, currentPuzzle.ballStart.position, Quaternion.identity);

        currentPuzzle.puzzleCamera.Follow = ball.transform;
        currentPuzzle.puzzleCamera.LookAt = ball.transform;
    }

    public void restartPuzzle()
    {        
        loadPuzzle(currentPuzzleIndex);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
