using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject onestarPanel;
    public GameObject twostarPanel;
    public GameObject treestarPanel;
    public GameObject scoreText;
    public int score = 0;
    public float minYAxisValue;
    public float winGameXPoint;
    //public AudioSource collectSound;

    private void Start()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Star")
        {
            score += 1;
            scoreText.GetComponent<Text>().text = "SCORE: " + score;
            Debug.Log(score);
            Destroy(other.gameObject);
        }
   
    }



    private void Update()
    {
        GameOver();
        WinGame();
          
        
    }
    
    

    public void GameOver()
    {     
        if (transform.position.y < minYAxisValue)
        {  
            gameOverPanel.SetActive(true);
            Time.timeScale = 0f;
        }
        
    }

    public void WinGame()
    {
        if(transform.position.x >= winGameXPoint)
        {
           
            Debug.Log(score);
            if (score >= 7)
            {
                treestarPanel.SetActive(true);
                

            }
            if (score <= 6 && score >= 3)
            {
               
                twostarPanel.SetActive(true);

            }
            if (score <= 2 && score >= 0) { 
            
                onestarPanel.SetActive(true);

            }
            Time.timeScale = 0f;
        }
    }
}
