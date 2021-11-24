using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayersChoise : MonoBehaviour
{
    private GameObject[] Charakters;
    private int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        index = PlayerPrefs.GetInt("CharacterSelected");
        Charakters = new GameObject[3];
        for(int i = 0;i<3;i++)
        {
            Charakters[i] = transform.GetChild(i).gameObject;
        }
        foreach (GameObject charakter in Charakters)
        {
            charakter.SetActive(false);
        }
        if(Charakters[index])
        {
            Charakters[index].SetActive(true);
        }
    }

    public void ToLefft()
    {
        Charakters[index].SetActive(false);
        index--;
        if(index < 0)
        {
            index = 2;
        }
        Charakters[index].SetActive(true);

    }
    public void ToRight()
    {
        Charakters[index].SetActive(false);
        index++;
        if (index > 2)
        {
            index = 0;
        }
        Charakters[index].SetActive(true);
    }

    public void ConfigButton()
    {
        PlayerPrefs.SetInt("CharacterSelected", index);
       
    }
}
