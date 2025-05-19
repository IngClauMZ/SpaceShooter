using UnityEngine;

public class DisparadorEnemigo : MonoBehaviour
{
    public GameObject proyectil;
    public float ritmo = 1.5f; // tiempo entre disparos en segundos
    public Transform puntoDisparo;   // punto desde donde dispara

    void Start()
    {
        InvokeRepeating(nameof(Disparo), ritmo, ritmo);
    }

    void Disparo()
    {
        if (proyectil != null && puntoDisparo != null)
        {
            Instantiate(proyectil, puntoDisparo.position, Quaternion.identity);
        }
    }
}
