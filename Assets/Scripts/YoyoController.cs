using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YoyoController : MonoBehaviour
{
    public float ballSpeed = 20f;
    private Rigidbody rb;
    private int addedForceCount;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.DownArrow) || Input.touchCount > 0)
        {
            rb.mass = 0.5f;
            rb.AddForce(Vector3.right / 7, ForceMode.Impulse);
        }

        if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            rb.mass = 0.1f;
        }
    }
}
