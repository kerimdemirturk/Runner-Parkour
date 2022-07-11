using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameStartCountDown : MonoBehaviour
{
    public int timer;
    public Text timerDisplay;
    GameManager gameManager;
    public Text controlText;
    public Image mouse;

    private void Start()
    {
        StartCoroutine(countDownToStart());
    }

    IEnumerator countDownToStart()
    {
        while(timer>0)
        {
            timerDisplay.text = timer.ToString();
            yield return new WaitForSeconds(1f);
            timer--;
            controlText.gameObject.SetActive(true);
            mouse.gameObject.SetActive(true);
            
        }
        timerDisplay.text = "START!";

        yield return new WaitForSeconds(1f);
        timerDisplay.gameObject.SetActive(false);
        controlText.gameObject.SetActive(false);
        mouse.gameObject.SetActive(false);
        
       
    }


    
   
}
