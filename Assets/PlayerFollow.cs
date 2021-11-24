using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class PlayerFollow : MonoBehaviour
{
    public GameObject[] Charakters;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<CinemachineVirtualCamera>().Follow = Charakters[PlayerPrefs.GetInt("CharacterSelected")].transform;
    }

    
}
