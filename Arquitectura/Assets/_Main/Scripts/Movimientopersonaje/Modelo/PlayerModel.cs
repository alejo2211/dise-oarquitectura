using UnityEngine;

public class PlayerModel : MonoBehaviour
{
    [SerializeField]
    private PlayerController inputs;
    public bool isMove;
    
    public Rigidbody rb;
    float velocidad = 5;

    public void Update()
    {
        Movimiento();
    }
   private void Movimiento()
    {
        
            rb.linearVelocity = inputs.DireccionJugador() * velocidad;
        
    }
    
}
