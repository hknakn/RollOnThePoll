using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowYoyo : MonoBehaviour
{
    public GameObject YoyoObject;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = YoyoObject.transform.position;
    }
}
