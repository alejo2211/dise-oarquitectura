using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Corrutinas : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    // tiempo entre cada spawn
    [SerializeField] private float tiempoSpawn = 5f;

    // cantidad de objetos a generar
    [SerializeField] private int cantidadSpawn = 3;

    void Start()
    {
        StartCoroutine(Spawn(2,3f));
    }

    void InstantiarEsfera()
    {
        Instantiate(prefab, new Vector3(5, 5, 0), Quaternion.identity);
    }

    IEnumerator Spawn(int tiempo, float cantidad)
    {
        for (int i = 0; i < cantidadSpawn; i++)
        {
            InstantiarEsfera();
            yield return new WaitForSeconds(tiempoSpawn);
        }
    }
}