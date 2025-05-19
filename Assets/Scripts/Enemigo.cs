using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public float velocidad = 2f;

    private Camera camaraPrincipal;

    void Start()
    {
        camaraPrincipal = Camera.main;
    }

    void Update()
    {
        transform.Translate(Vector2.down * velocidad * Time.deltaTime);

        // Eliminar cuando está fuera del campo de visión por abajo
        if (transform.position.y < camaraPrincipal.transform.position.y - camaraPrincipal.orthographicSize - 1f)
        {
            Destroy(gameObject);
        }
    }
}
