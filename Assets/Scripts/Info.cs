using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Info : MonoBehaviour
{
    
    [SerializeField] Text text;
    [SerializeField] Text text2;
    [SerializeField] Player Player;

    int counter = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(counter == 0)
        {
            

        StartCoroutine(ActiveText());
        }
        counter++;
        
        

    }
    IEnumerator ActiveText()
    {
        
        text.enabled = true;
        text2.enabled = true;
        Player.SetAlive(false);
        yield return new WaitForSeconds(10);
        text.enabled = false;
        text2.enabled = false;
        Player.SetAlive(true);

    }
}
