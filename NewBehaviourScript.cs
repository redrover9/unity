using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.GetComponent<Rigidbody>().AddForce(transform.up * 50f);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            this.GetComponent<Rigidbody>().AddForce(transform.up * -50f);
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            this.GetComponent<Rigidbody>().AddForce(transform.right * -50f);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            this.GetComponent<Rigidbody>().AddForce(transform.right * 50f);
        }


    }
}

