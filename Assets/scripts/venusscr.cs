using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class venusscr : MonoBehaviour
{
    public Vector3 venusyon;
    public GameObject venus;
    void Start()
    {
        venusyon = new Vector3(0, -0.2f, 0);
        venus.GetComponent<venusscr>().venusyon = new Vector3(0, -3.5f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(venusyon);
    }
}
