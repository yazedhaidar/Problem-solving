﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BWPlayerControl : MonoBehaviour
{
    // Tombol untuk menggerakkan ke atas
    public KeyCode upButton = KeyCode.W;

    // Tombol untuk menggerakkan ke bawah
    public KeyCode downButton = KeyCode.S;

    // Tombol untuk menggerakkan ke bawah
    public KeyCode rightButton = KeyCode.D;

    // Tombol untuk menggerakkan ke bawah
    public KeyCode leftButton = KeyCode.A;

    //Kecepatan Gerak 
    public float speed = 25.0f;

    // Batas atas dan bawah game scene (Batas bawah menggunakan minus (-))
    public static float yBoundary = 9.0f;

    // Batas kiri dan kanan game scene (Batas bawah menggunakan minus (-))
    public static float xBoundary = 25.1f;

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
        // Dapatkan kecepatan raket sekarang.
        Vector2 velocity = rigidBody2D.velocity;

        // Jika pemain menekan tombol ke atas, beri kecepatan positif ke komponen y (ke atas).
        if (Input.GetKey(upButton))
        {
            velocity.y = speed;
        }

        // Jika pemain menekan tombol ke bawah, beri kecepatan negatif ke komponen y (ke bawah).
        else if (Input.GetKey(downButton))
        {
            velocity.y = -speed;
        }

        // Jika pemain menekan tombol ke kanan, beri kecepatan negatif ke komponen y (ke kanan).
        else if (Input.GetKey(rightButton))
        {
            velocity.x = speed;
        }

        // Jika pemain menekan tombol ke kiri, beri kecepatan negatif ke komponen y (ke kiri).
        else if (Input.GetKey(leftButton))
        {
            velocity.x = -speed;
        }

        // Jika pemain tidak menekan tombol apa-apa, kecepatannya nol.
        else
        {
            velocity.y = 0.0f;
            velocity.x = 0.0f;
        }

        // Masukkan kembali kecepatannya ke rigidBody2D.
        rigidBody2D.velocity = velocity;
        getPosition();

      
    }

    public void getPosition()
    {
        // Dapatkan posisi raket sekarang.
        Vector3 position = transform.position;

        // Jika posisi raket melewati batas atas (yBoundary), kembalikan ke batas atas tersebut.
        if (position.y > yBoundary)
        {
            position.y = yBoundary;
        }

        // Jika posisi raket melewati batas bawah (-yBoundary), kembalikan ke batas atas tersebut.
        else if (position.y < -yBoundary)
        {
            position.y = -yBoundary;
        }

        // Jika posisi raket melewati batas kiri (-xBoundary), kembalikan ke batas kiri tersebut.
        else if (position.x < -xBoundary)
        {
            position.x = -xBoundary;
        }

        // Jika posisi raket melewati batas kanan (xBoundary), kembalikan ke batas kanan tersebut.
        else if (position.x > xBoundary)
        {
            position.x = xBoundary;
        }

        // Masukkan kembali posisinya ke transform.
        transform.position = position;
    }
}
