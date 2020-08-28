using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApontaNorte : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, -Input.compass.magneticHeading, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
