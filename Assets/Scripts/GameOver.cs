using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    Collision other;
    // Start is called before the first frame update
    void Start()
    {
        ScoringSystem score = GetComponent<ScoringSystem>();
 
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.gameObject);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "plane")
        {
            Debug.Log("Çarptı");
        }
   
     }

}
