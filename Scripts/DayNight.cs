using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNight : MonoBehaviour
{
    Vector3 rot = Vector3.zero;
    float day_cycle = 1;

    // Update is called once per frame
    void Update()
    {
        rot.x = day_cycle * Time.deltaTime;
        transform.Rotate(rot, Space.World);

    }
}
