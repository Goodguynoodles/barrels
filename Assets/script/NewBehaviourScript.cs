using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
    public Rigidbody rb;
    public float thrust = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(0, 0, thrust, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
