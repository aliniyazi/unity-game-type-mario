using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    int counter = 0;
    [SerializeField] GameObject PauseMenuUI;
    bool GameisPaused = false;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameisPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }

        }
        
    }
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        GameisPaused = false;
        Time.timeScale = 1f;
    }
    private void Pause()
    {
        PauseMenuUI.SetActive(true);
        GameisPaused = true;
        Time.timeScale = 0f;
    }
}
