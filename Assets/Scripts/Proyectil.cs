using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float speed = 5f;

    void Update()
    {
        transform.Translate(Vector2.down * speed * Time.deltaTime);

        // Destruir cuando ya no se vea
        if (transform.position.y < Camera.main.transform.position.y - Camera.main.orthographicSize - 1f)
        {
            Destroy(gameObject);
        }
    }
}
