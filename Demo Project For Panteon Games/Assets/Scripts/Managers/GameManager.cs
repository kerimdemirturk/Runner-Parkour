using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform player;
    private float finishLine = 20.93f;


    public void Reset()
    {
        SceneManager.LoadScene(0);
        Debug.Log("basdý");
    }

   
}
