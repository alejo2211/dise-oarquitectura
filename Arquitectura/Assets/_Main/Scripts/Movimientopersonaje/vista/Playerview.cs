using UnityEngine;

public class Playerview : MonoBehaviour
{
    [SerializeField]
    private Renderer render;
    [SerializeField]
    private Material material1;
    [SerializeField]
    private Material material2;

    [SerializeField] private PlayerController controller;
    void Start()
    {
        render = GetComponent<Renderer>(); // asignar algun componente en el primer frame
        controller = GetComponent<PlayerController>();

    }

    
    void Update()
    {
        CambiarColor();
    }
    public void CambiarColor()
    {
        if (controller.DireccionJugador().magnitude > 0)
        {
            render.material.color = Color.red;
        }
        else
        {
            render.material.color = Color.blue;
        }
    }
}
