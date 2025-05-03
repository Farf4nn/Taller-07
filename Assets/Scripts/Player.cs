using UnityEngine;

public interface IPlayerController
{
    public void Move();

    public void Attack();
}
public class Player : MonoBehaviour
{
    private IPlayerController controller;
    private bool state = true;

    [SerializeField] private GamepadControlador gamepad;
    [SerializeField] private TecladoControlador teclado;

    void Start()
    {
        controller = teclado;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (state)
            {
                controller = gamepad;
                Debug.Log("Cambiado a Gamepad");
                state = false;
            }
            else
            {
                controller = teclado;
                Debug.Log("Cambiado a Teclado");
                state = true;
            }
            if (Input.GetKeyDown(KeyCode.R))
            {
                if (controller != null)
                {
                    controller.Move();
                }
            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                if (controller != null)
                {
                    controller.Attack();
                }
            }
        }
    }
}
