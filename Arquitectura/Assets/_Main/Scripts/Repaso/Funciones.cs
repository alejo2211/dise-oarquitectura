using UnityEngine;

public class Funciones : MonoBehaviour
{
    public Clases ListaEstudiantes = new Clases();
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Mifuncion();
    }

    // Update is called once per frame
    void Update()
    {
        // no saturar
      
    }
    public void Mifuncion() 
    {
        Debug.Log(ListaEstudiantes.estudiantes[2]);
        Debug.Log(ListaEstudiantes.edadestudiantes[2]);
        Debug.Log(ListaEstudiantes.Suma(5, 6));
    }
}
