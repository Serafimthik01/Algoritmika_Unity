using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = other.GetComponent<Jump>().jumpStrength * 1.5f;

    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = other.GetComponent<Jump>().jumpStrength / 1.5f;

    }
}
