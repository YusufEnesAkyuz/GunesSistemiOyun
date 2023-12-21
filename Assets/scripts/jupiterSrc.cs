using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jupiterSrc : MonoBehaviour
{
    public Vector3 jupiterYon;

    public GameObject jupiter;
    void Start()
    {
        jupiterYon = new Vector3(0, 0.07f, 0);
        jupiter.GetComponent<jupiterSrc>().jupiterYon = new Vector3(0, 0.8f, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(jupiterYon);
    }
}
