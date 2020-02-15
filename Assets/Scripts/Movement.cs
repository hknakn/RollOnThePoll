using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
 
    public Rigidbody rb;
    private bool colliderHit = false;
    public float speed = 1f;

    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        //Output the Collider's GameObject's name
       
    }

    // Update is called once per frame
    void Update()
    {
        float forceHorizontal = Input.GetAxis("Horizontal");
        float forceVertical = Input.GetAxis("Vertical");
        Vector3 moveHorizontal = new Vector3(forceHorizontal, forceVertical);
        rb.AddForce(moveHorizontal * speed);
        
    }
}
