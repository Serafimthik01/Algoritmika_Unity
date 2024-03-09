using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Stopwatch time;
    public RoutePoint finishPoint;

    private void OnTriggerEnter(Collider other)
    {
        if (finishPoint.isActiveForPlayer)
        {
            if (other.tag == "Player")
            {
                time.hasFinished = true;
            }
        }
    }
}
