using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Missile : MonoBehaviour
{
    public float speed;

    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other) {

        Enemy enemy = other.GetComponent<Enemy>();
        Destroy(enemy.gameObject);

        Destroy(gameObject);
    }

}
