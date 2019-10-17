using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private int health = 100;

    [SerializeField]
    [Range(1, 10)]
    private int speed = 1;

    [SerializeField]
    private Rigidbody2D rigidBody;

    [HideInInspector]
    public Sword weapon;

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");

        rigidBody.velocity = new Vector2(horizontal * speed, rigidBody.velocity.y);
    }
}
