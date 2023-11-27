using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTriggerWizard : MonoBehaviour
{
    public float speedFactor = 2.5f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<ThirdPersonMovement>().runSpeed *= speedFactor;
    }

    void OnTriggerExit(Collider other)
    {
        other.GetComponent<ThirdPersonMovement>().runSpeed /= speedFactor;
    }
}
