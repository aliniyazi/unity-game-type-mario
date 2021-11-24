using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public void LoadNextScene()
    {
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(CurrentScene + 1);
    }
    public void ExitGame()
    {
        Application.Quit();
    }
    public void LoadUpgradeScene()
    {
        SceneManager.LoadScene("UpgradeMenu");
    }
    public void LoadGameMenu()
    {
        SceneManager.LoadScene("PlayMenu");
    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level 2");
    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level 3");
    }
    public void LoadLevel4()
    {
        SceneManager.LoadScene("Level 4");
    }
    public void LoadOptionsMenu()
    {
        SceneManager.LoadScene("Options");
    }
    public void LoadChoisePlayer()
    {
        SceneManager.LoadScene("ChoisePlayer");
    }
    public void LoadLevelMenu()
    {
        SceneManager.LoadScene("LevelMenu");
    }
    public void LoadStartMenu()
    {
        SceneManager.LoadScene("StartMenu");
    }
    public void LoadNewGame()
    {
        SceneManager.LoadScene("Level 2");
        ResetPlayerStats();
    }
    private void ResetPlayerStats()
    {
        PlayerPrefs.DeleteKey("PlayerJump");
        PlayerPrefs.DeleteKey("PlayerSpeed");
        PlayerPrefs.DeleteKey("levelAt");
        PlayerPrefs.DeleteKey("SavedLevel");
    }
    public void STartGameInLoadedLevel()
    {
        SceneManager.LoadScene(PlayerPrefs.GetInt("SavedLevel"));
    }
}
