using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class saturnScr : MonoBehaviour
{
    public Vector3 saturnYon;
    public GameObject saturn;
    void Start()
    {
        saturnYon = new Vector3(0, 0.05f, 0);
        saturn.GetComponent<saturnScr>().saturnYon = new Vector3(0, 1.2f, 0);
    }

    
    void Update()
    {
        GetComponent<Transform>().Rotate(saturnYon);
    }
}
