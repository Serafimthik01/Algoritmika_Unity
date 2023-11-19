using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;

    void Update()
    {
        //ћен€ет каждый кадр позицию NPC на новую 
        transform.position = Vector3.MoveTowards(transform.position,
            target.position, speed * Time.deltaTime);

        //–азворачивает каждый кадр NPC лицом к цели
        transform.LookAt(target.position);
    }

    //ѕри столкновении врага с игроком второму наноситс€ урон
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.TakeDamage(playerDamage);
    }
}