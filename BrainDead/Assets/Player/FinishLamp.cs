using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishLamp : MonoBehaviour
{
    public GameObject[] LampArray;
    public Material OnMaterial;
    public Material OffMaterial;
    public GameObject Finish;

    void Start()
    {
        //print(LampArray[0].GetComponent<Renderer>().material);
    }

    // Update is called once per frame
    void Update()
    {
        if (LampArray[0].GetComponent<Renderer>().material.name == "LampOn (Instance)")
        {
            if (LampArray[1].GetComponent<Renderer>().material.name == "LampOn (Instance)")
            {
                if (LampArray[2].GetComponent<Renderer>().material.name == "LampOn (Instance)")
                {
                    Finish.SetActive(false);
                }
            }
                    
        }
        if (LampArray[0].GetComponent<Renderer>().material.name == "LampOff (Instance)")
        {
            if (LampArray[1].GetComponent<Renderer>().material.name == "LampOff (Instance)")
            {
                if (LampArray[2].GetComponent<Renderer>().material.name == "LampOff (Instance)")
                {
                    Finish.SetActive(true);
                }
            }

        }

    }
}
