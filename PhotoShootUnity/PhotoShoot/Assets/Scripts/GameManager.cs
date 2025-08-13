using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public enum GameState
{
    //Possible game states
    WelcomeTutorial,
    ReceiveAssignment,
    TargetSet1,
    TargetSet2,
    TargetSet3,
    TargetSet4,
    TargetSet5,
}

public class GameManager : MonoBehaviour
{
    //Only one gamemanager
    //Can be accessed from anywhere
    public static GameManager Instance;

    //What is the game's current state
    public GameState State;

    //Event system to create notificaitons when things change
    public static event Action<GameState> OnGameStateChange;

    private void Awake()
    {
        Instance = this;
    }

    private void Start()
    {
        UpdateGameState(GameState.WelcomeTutorial);
    }

    public void UpdateGameState(GameState newState)
    {
        State = newState;

        // State specific logic
        // If a new state begins, what happens?
        switch (newState)
        {
            case GameState.WelcomeTutorial:
                break;
            case GameState.ReceiveAssignment:
                break;
            case GameState.TargetSet1:
                break;
            case GameState.TargetSet2:
                break;
            case GameState.TargetSet3:
                break;
            case GameState.TargetSet4:
                break;
            case GameState.TargetSet5:
                break;
            default:
                break;
        }

        //Is anybody subscribed? If so, tell them the state has changed
        OnGameStateChange?.Invoke(newState);
    }
}
