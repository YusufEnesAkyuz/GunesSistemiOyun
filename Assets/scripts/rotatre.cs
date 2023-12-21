using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotatre : MonoBehaviour
{
    public Vector3 rotatyon;
    public GameObject merkur;
    void Start()
    {
        rotatyon = new Vector3(0, 0.3f, 0);
        merkur.GetComponent<rotatre>().rotatyon = new Vector3(0, 4, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotatyon);
    }
}
