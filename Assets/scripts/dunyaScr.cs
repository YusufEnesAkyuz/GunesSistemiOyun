using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dunyaScr : MonoBehaviour
{
    public Vector3 dunyayon;
    public GameObject dunya;
    void Start()
    {
        dunyayon = new Vector3(0, 0.15f, 0);
        dunya.GetComponent<dunyaScr>().dunyayon = new Vector3(0, 2, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(dunyayon);
    }
}
