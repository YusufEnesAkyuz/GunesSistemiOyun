using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class neptunScr : MonoBehaviour
{
    public Vector3 neptunyon;
    public GameObject neptun;
    void Start()
    {
        neptunyon = new Vector3(0, 0.02f, 0);
        neptun.GetComponent<neptunScr>().neptunyon = new Vector3(0, 2.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(neptunyon);
    }
}
