using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uranusScr : MonoBehaviour
{
    public Vector3 uranusyon;
    public GameObject uranus;
    void Start()
    {
        uranusyon = new Vector3(0, 0.03f, 0);
        uranus.GetComponent<uranusScr>().uranusyon = new Vector3(0, 1.7f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(uranusyon);
    }
}
