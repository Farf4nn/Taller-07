using UnityEngine;

public class GamepadControlador : MonoBehaviour, IPlayerController
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Move();
        Attack();
    }
    public virtual void Move()
    {
        Debug.Log("Gamepad: Movimiento con joystick");
    }
    public virtual void Attack()
    {
        Debug.Log("Gamepad: Ataque con boton R");
    }
}
