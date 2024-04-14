using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int health;
    public float speed = 1f;

    public int price;

    public float attackInterval = 0.75f;
    public float attackTimer = 0;

    float borderPosX;

    public Animator animator;

    public float speedPerLevel = 0.2f;

    void Start()
    {
        borderPosX = Corn.singleton.transform.position.x;

        speed += speedPerLevel * GameController.level;
    }

    void Update()
    {
        if (attackTimer > 0)
        {
            attackTimer -= Time.deltaTime;
        }

        float enemyPosX = transform.position.x;

        if (enemyPosX > borderPosX)
        {
            transform.position += -transform.right * speed * Time.deltaTime;

            animator.SetBool("isMoving", true);
        }
        else
        {
            if (attackTimer <= 0)
            {
                Attack();

                attackTimer = attackInterval;
            }

            animator.SetBool("isMoving", false);
        }
    }

    public void Attack()
    {
        Corn.singleton.TakeDamage();
    }

    public void TakeDamage()
    {
        health -= 1;

        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Corn.singleton.AddCrystals(price);
        Destroy(gameObject);
    }
}