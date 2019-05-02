using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
  private const float V = 4.25f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) && transform.position.z < V)
        {
            transform.position += transform.forward * 0.15f;
        }
        else if (Input.GetKey(KeyCode.RightArrow) && transform.position.z > -V)
        {
            transform.position -= transform.forward * 0.15f;
        }
    }
}
