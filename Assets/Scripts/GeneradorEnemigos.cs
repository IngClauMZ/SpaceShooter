using UnityEngine;

public class GeneradorEnemigos : MonoBehaviour
{
    public GameObject enemigo;
    public float minTiempo = 0.5f;
    public float maxTiempo = 2f;
    public float posY = 1f; // qué tan arriba de la cámara aparece

    private Camera camaraPrincipal;

    void Start()
    {
        camaraPrincipal = Camera.main;
        StartCoroutine(EnemigoRoutine());
    }

    private System.Collections.IEnumerator EnemigoRoutine()
    {
        while (true)
        {
            float tiempoEspera = Random.Range(minTiempo, maxTiempo);
            yield return new WaitForSeconds(tiempoEspera);

            Vector2 posEne = GetRandomTopPosition();
            Instantiate(enemigo, posEne, Quaternion.identity);
        }
    }

    Vector2 GetRandomTopPosition()
    {
        float screenWidth = camaraPrincipal.orthographicSize * camaraPrincipal.aspect;
        float x = Random.Range(-screenWidth, screenWidth);
        float y = camaraPrincipal.transform.position.y + camaraPrincipal.orthographicSize + posY;
        return new Vector2(x, y);
    }
}
