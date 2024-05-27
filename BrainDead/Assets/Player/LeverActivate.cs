using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverActivate : MonoBehaviour
{
    public GameObject triggerOn;
    public GameObject triggerOff;
    public GameObject lever;

    public GameObject[] TargetGate;

    public Material normal;
    public Material transparent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("TriggerOff"))
        {
            print("Off");
            //HitButton.Play();
            foreach (GameObject Gate in TargetGate)
            {
                Gate.GetComponent<Renderer>().material = normal;
                Gate.GetComponent<Collider>().isTrigger = false;
            }

        }
        if (other.CompareTag("TriggerOn"))
        {
            print("On");
            //HitButton.Play();
            foreach (GameObject Gate in TargetGate)
            {
                Gate.GetComponent<Renderer>().material = transparent;
                Gate.GetComponent<Collider>().isTrigger = true;
            }

        }
    }
}

