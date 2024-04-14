using UnityEngine;

public class Crossbow : MonoBehaviour
{
    public GameObject arrowPrefab;

    public float shootInterval = 0.75f;
    public float shootTimer = 0;
     
    void Update()
    {
        if (shootTimer > 0)
        {
            shootTimer -= Time.deltaTime;
        }

        if (Input.GetMouseButton(0))
        {
            Vector2 mouseScreenPos = Input.mousePosition;

            Vector2 mouseScenePos = Camera.main.ScreenToWorldPoint(mouseScreenPos);

            Vector2 bowPos = transform.position;

            Vector2 wantedDirection = mouseScenePos - bowPos;

            Vector2 defaultDirection = Vector2.up;

            float angle = Vector2.SignedAngle(defaultDirection, wantedDirection);

            Vector3 newEuler = new Vector3(0f, 0f, angle);

            transform.localEulerAngles = newEuler;

            if (shootTimer <= 0)
            {
                Instantiate(arrowPrefab, transform.position, transform.rotation);
                shootTimer = shootInterval;
            }
        }
    }
}