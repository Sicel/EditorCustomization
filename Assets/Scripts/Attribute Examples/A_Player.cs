using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_Player : MonoBehaviour
{
    public float currentHealth = 100;

    [SerializeField] // Force Unity to (serialize) show private field in inspector
    private float maxHealth = 100;

    [HideInInspector] // Keeps your field hidden in inspector
    public Rigidbody2D rigidBody;

    [Range(1, 10)] // Creates a slider from specified range
    public int speed = 1;

    public A_Sword weapon;

    // Unity can't serialize properties
    [SerializeField] // Even with the [SerializeField] attribute
    public float JumpHeight { get; set; } = 10;

    private void Awake()
    {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        rigidBody.velocity = new Vector2(horizontal * speed, rigidBody.velocity.y);
    }
}
