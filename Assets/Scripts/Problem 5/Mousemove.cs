using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mousemove : MonoBehaviour
{
    // Batas atas dan bawah game scene (Batas bawah menggunakan minus (-))
    public static float yBoundary = 9.0f;

    // Batas kiri dan kanan game scene (Batas bawah menggunakan minus (-))
    public static float xBoundary = 16.8f;


    // Rigidbody 2D raket ini
    private Rigidbody2D rigidBody2D;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 CursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector2(CursorPos.x, CursorPos.y);

        if (CursorPos.x > xBoundary)
        {
            CursorPos.x = xBoundary;

            if (CursorPos.y > yBoundary)
            {
                CursorPos.y = yBoundary;
            }
            else if (CursorPos.y < -yBoundary)
            {
                CursorPos.y = -yBoundary;
            }

            transform.position = new Vector2(CursorPos.x, CursorPos.y);
        }
        else if (CursorPos.y > yBoundary)
        {
            CursorPos.y = yBoundary;

            if (CursorPos.x > xBoundary)
            {
                CursorPos.x = xBoundary;
            }
            else if (CursorPos.x < -xBoundary)
            {
                CursorPos.x = -xBoundary;
            }

            transform.position = new Vector2(CursorPos.x, CursorPos.y);
        }
        else if (CursorPos.x < -xBoundary)
        {
            CursorPos.x = -xBoundary;

            if (CursorPos.y > yBoundary)
            {
                CursorPos.y = yBoundary;
            }
            else if (CursorPos.y < -yBoundary)
            {
                CursorPos.y = -yBoundary;
            }

            transform.position = new Vector2(CursorPos.x, CursorPos.y);
        }
        else if (CursorPos.y < -yBoundary)
        {
            CursorPos.y = -yBoundary;

            if (CursorPos.x > xBoundary)
            {
                CursorPos.x = xBoundary;
            }
            else if (CursorPos.x < -xBoundary)
            {
                CursorPos.x = -xBoundary;
            }

            transform.position = new Vector2(CursorPos.x, CursorPos.y);
        }
    }
}
