using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    float rotatePeriod = 3, rotate = 0;
    
    void Update()
    {
        rotate += Time.deltaTime / rotatePeriod;
        transform.localRotation = Quaternion.Euler(0, (rotate * 360) - 90, 0);
    }

    void OnTriggerEnter(Collider other) {

        CoinsCounter coins = other.GetComponent<CoinsCounter>();

        coins.CollectCoins();

        Destroy(gameObject);
    }
}
