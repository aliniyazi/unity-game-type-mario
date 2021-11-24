using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Upgrade : MonoBehaviour
{
    [SerializeField] Text Speed;
    [SerializeField] Text Jump;
    [SerializeField] Image[] images;

    
    float speed = 10f;
    float jump = 25f;
    private void Start()
    {
        
    }
    public void UpgradeLives()
    {
        var obj = FindObjectOfType<GameSession>();
        int score = obj.GetScore();
        if(score < 150)
        {
            return;
        }
        else
        {
            obj.RemoveScore(150);
            obj.ProcessAdingLives();

        }
    }
    public void UpgradeSpeed()
    {
        speed += 1f;
        PlayerPrefs.SetFloat("PlayerSpeed", speed);
    }
    public void UpgradeJump()
    {
        
        jump += 1f;
        PlayerPrefs.SetFloat("PlayerJump", jump);
        

    }
    
}
