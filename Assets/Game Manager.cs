using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject game_start_ui;
    public GameObject game_playing_ui;
    public GameObject game_ending_ui;

    public enum GameState
    {
        Start,
        Playing,
        Ending,
    }

    public GameState state;
    void Awake()
    {
        state = GameState.Start;
    }
    void Start()
    {
        GameStart();
    }
    void GameStart()
    {
        state=GameState.Start;
        game_start_ui.SetActive(true);
        PlayerPrefs.SetInt("Score", 0);
    }

    void GamePlay()
    {
        state = GameState.Playing;
        game_start_ui.SetActive(false);
        game_playing_ui.SetActive(true);
    }
    void GameOver()
    {
        state = GameState.Ending;
        game_playing_ui.SetActive(false);
        game_ending_ui.SetActive(true);
    }
}

