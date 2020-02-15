using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    string scene ;
    private void Update()
    {


    }
    private void Start()
    {
       scene = SceneManager.GetActiveScene().name;

    }
    public void Restart()
    {
        SceneManager.LoadScene(scene);
       
    }
    public void NewLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
   
}
