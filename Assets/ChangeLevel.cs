using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    [SerializeField] string Level;
    public void LoadScene()
    {
        SceneManager.LoadScene(Level);
    }
    
}
