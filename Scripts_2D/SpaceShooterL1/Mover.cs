using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speed = 2f;

    void Start()
    {
        Destroy(gameObject, 5f);
    }

    void Update()
    {
        transform.position = (Vector2)transform.position + Vector2.down * (speed + GameController.gameSpeed) * Time.deltaTime;
    }
}
