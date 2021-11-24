﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelection : MonoBehaviour
{ 
    public Button[] lvlButtons;
    
    // Start is called before the first frame update
    void Start()
    {
        int levelAt = PlayerPrefs.GetInt("levelAt",2);
        Debug.Log(levelAt);
        for (int i = 0; i < lvlButtons.Length; i++)
        {
            if (i+2 > levelAt)
                lvlButtons[i].interactable = false;
        }
    }
}
