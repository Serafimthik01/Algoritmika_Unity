using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public Animator button;
    public Animator toOpen;
    public Enemy enemy;

    void Start()
    {
        button.enabled = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        button.enabled = true;
        toOpen.enabled = true;
        enemy.enabled = true;
    }
}
