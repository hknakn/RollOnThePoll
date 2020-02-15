using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public int score = 0;
    //public AudioSource collectSound;

    
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject.tag);
        if (other.gameObject.tag == "Star")
        {
            score += 1;
            scoreText.GetComponent<Text>().text = "SCORE: " + score;
            Destroy(other.gameObject);
        }
    }
    
}
