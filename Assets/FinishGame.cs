using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{
    [SerializeField] Player player;
    public int nextSceneLoad;

    // Start is called before the first frame update
    void Start()
    {
        nextSceneLoad = SceneManager.GetActiveScene().buildIndex+1;
        Debug.Log(nextSceneLoad);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {


        if (SceneManager.GetActiveScene().buildIndex == 6)
        {

            return;
           
        }
        else
        {
            if (player.Gems > 0)
            {
                SceneManager.LoadScene(nextSceneLoad);
                if (nextSceneLoad > PlayerPrefs.GetInt("levelAt"))
                {
                    PlayerPrefs.SetInt("levelAt", nextSceneLoad);
                }


            }
            else
            {
                return;

            }

        }

    }
}
