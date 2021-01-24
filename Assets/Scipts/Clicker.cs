using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicker : MonoBehaviour
{
    public int score;
    public Text clicktext;
    

    void Start()
    {
        score = 0;
        score = PlayerPrefs.GetInt("Score+ ", score);
    }

    
    void Update()
    {
        clicktext.text = score.ToString();  
    }
    public void ClickerScore()
    {  
        
        score++;
        PlayerPrefs.SetInt("Score+ ", score);

   
    }

    public void Reset()
    {
        
        PlayerPrefs.DeleteAll();
        score = 0;
    }
}
