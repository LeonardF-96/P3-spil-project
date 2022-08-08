using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 movedirection;

    void Update() //Kører hver frame, så den er variabel og er baseret på fps i spillet
    {
        processInputs();
    }
    private void FixedUpdate() //Kører igen efter et bestemt stykke tid
    {
        Move();
    }
    void processInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); //GetAxis er et spektrum mellem 1 og 0, GetAxisRaw er en enten eller. Binder her til Horizontal under Input Manager/Axes.
        float moveY = Input.GetAxisRaw("Vertical");

        movedirection = new Vector2(moveX, moveY).normalized;
    }
    private void Move()
    {
        rb.velocity = new Vector2(movedirection.x * moveSpeed, movedirection.y * moveSpeed);
    }
}
