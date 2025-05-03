using UnityEngine;

public class TecladoControlador : MonoBehaviour, IPlayerController
{

    void Start()
    {
        Move();
        Attack();
    }
    public virtual void Move()
    {
        Debug.Log("Teclado: Movimiento con WASD");
    }
    public virtual void Attack()
    {
        Debug.Log("Teclado: Ataque con F");
    }
}
