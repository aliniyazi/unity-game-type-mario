using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameSession : MonoBehaviour
{
    [SerializeField] int PlayerLifes = 3;
    [SerializeField] int PlayerScore = 0;

    [SerializeField] Text lives;
    [SerializeField] Text score;

    private void Awake()
    {
        int numberOfGameSessions = FindObjectsOfType<GameSession>().Length;
        if(numberOfGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        lives.text = PlayerLifes.ToString();
        score.text = PlayerScore.ToString();
    }
    private void Update()
    {
        score.text = PlayerScore.ToString();

    }

    // Update is called once per frame
    public void ProsessPlayerDeath()
    {
        if(PlayerLifes > 1)
        {
            StartCoroutine(WaitAfterDeath());
            
        }
        else
        {
            
            LoadMainScene();
        }
    }
    IEnumerator WaitAfterDeath()
    {
        PlayerLifes--;
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        lives.text = PlayerLifes.ToString();
        PlayerScore = 0;

    }
    private void LoadMainScene()
    {
        
        SceneManager.LoadScene("Level 2");
        Destroy(gameObject);
    }
    public void AddScore(int value)
    {
        this.PlayerScore += value;
        this.score.text = PlayerScore.ToString();
    }
    public void ResetScore()
    {
        this.PlayerScore = 0;
        this.score.text = PlayerScore.ToString();
    }
    public void RemoveScore(int value)
    {
        
            this.PlayerScore -= value;
            this.score.text = PlayerScore.ToString();
        
    }
    public void AddLives()
    {
        this.PlayerLifes++;
    }
    public int GetScore()
    {
        return this.PlayerScore;
    }
    public void ProcessAdingLives()
    {
        AddLives();
        lives.text = this.PlayerLifes.ToString();
    }
    
}
