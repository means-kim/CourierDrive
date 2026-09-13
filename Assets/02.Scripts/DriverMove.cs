using System;
using UnityEngine;

public class DriverMove : MonoBehaviour
{
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private float  _moveSpeed;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        float steerAmount = Input.GetAxis("Horizontal") * _rotationSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * _moveSpeed * Time.deltaTime;
        
        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"으악!!");
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"거제 야호~!");
    }
}
