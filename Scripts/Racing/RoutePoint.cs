using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoutePoint : MonoBehaviour
{
    public RoutePoint nextPoint;

    public GameObject model;

    public bool isActiveForPlayer;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (isActiveForPlayer)
            {
                if (nextPoint != null)
                {
                    nextPoint.isActiveForPlayer = true;
                    nextPoint.model.SetActive(true);
                }
            }
            else
            {
                isActiveForPlayer = false;
                model.SetActive(false);
            }
        }
    }
}
