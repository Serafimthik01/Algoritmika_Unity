using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject pickupEffect;

    public float scaleMax = 1.3f;
    public float scaleMin = 0.7f;

    public float rotationMax = 180f;
    public float rotationMin = 0f;

    private void Start()
    {
        randomSize();
        randomRotation();
    }

    void randomRotation()
    {
        float rotationFactor = Random.Range(rotationMin, rotationMax);
        transform.localEulerAngles = Vector3.forward * rotationFactor;

    }

    void randomSize()
    {
        float scaleFactor = Random.Range(scaleMin, scaleMax);
        transform.localScale = (Vector2)transform.localScale - new Vector2(scaleFactor, scaleFactor);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject effect = Instantiate(pickupEffect, transform.position, transform.rotation);
            Destroy(effect, 5);
            Destroy(collision.gameObject);
        }
    }
}