using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampController : MonoBehaviour
{
    public GameObject[] LampArray;
    public bool LampBoolFirst = false;
    public bool LampBoolSecond = false;
    public bool LampBoolThird = false;

    public bool RuleFirst = false;
    public bool RuleSecond = false;
    public bool RuleThird = false;



    public Material OnMaterial;
    public Material OffMaterial;

    //public GameObject[] ButtonArray;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (RuleFirst == true)
            {
                if (LampBoolFirst == true)
                {
                    LampBoolFirst = false;
                    //print(LampArray[0].GetComponent<Renderer>().material);
                    LampArray[0].GetComponent<Renderer>().material = OffMaterial;
                }
                else
                {
                    LampBoolFirst = true;
                    //print(LampArray[0].GetComponent<Renderer>().material);
                    LampArray[0].GetComponent<Renderer>().material = OnMaterial;
                }
            }
            if (RuleSecond == true)
            {
                if (LampBoolSecond == true)
                {
                    LampBoolSecond = false;
                    //print(LampArray[1].GetComponent<Renderer>().material);
                    LampArray[1].GetComponent<Renderer>().material = OffMaterial;
                }
                else
                {
                    LampBoolSecond = true;
                    //print(LampArray[1].GetComponent<Renderer>().material);
                    LampArray[1].GetComponent<Renderer>().material = OnMaterial;
                }
            }
            if (RuleThird == true)
            {
                if (LampBoolThird == true)
                {
                    LampBoolThird = false;
                    //print(LampArray[2].GetComponent<Renderer>().material);
                    LampArray[2].GetComponent<Renderer>().material = OffMaterial;
                }
                else
                {
                    LampBoolThird = true;
                    //print(LampArray[2].GetComponent<Renderer>().material);
                    LampArray[2].GetComponent<Renderer>().material = OnMaterial;
                }
            }
        }
    }
}


                

