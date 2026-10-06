using UnityEngine;

using UnityEngine.InputSystem;

public class HumanMovement : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float x = 0;
        float y = 0;

        if (Keyboard.current.wKey.isPressed)
        {
            y = 1;
        }


        if (Keyboard.current.sKey.isPressed)
        {
            y = -1;
        }


        if (Keyboard.current.aKey.isPressed)
        {
            x = -1;
        }


        if (Keyboard.current.dKey.isPressed)
        {
            x = 1;
        }

        Vector2 movement = new Vector2(x, y).normalized;

        rb.linearVelocity = movement * speed;
    }
}
