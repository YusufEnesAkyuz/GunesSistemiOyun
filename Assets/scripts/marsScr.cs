using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class marsScr : MonoBehaviour
{
    public Vector3 marsyon;
    public GameObject mars;
    void Start()
    {
        marsyon = new Vector3(0, 0.11f, 0);
        mars.GetComponent<marsScr>().marsyon = new Vector3(0, 1.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(marsyon);
    }
}
