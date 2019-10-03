
using System;
using UnityEngine;
using UnityEngine.XR;

public class CharacterController2D : MonoBehaviour
{
    public Rigidbody2D rb;
    private float curAxeX;
    private float curAxeY;
    public float playerSpeed = 0.5f;
    private Camera _camera;
    public Material mask;
    private void Start()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        curAxeX = Input.GetAxisRaw("Horizontal");
        curAxeY = Input.GetAxisRaw("Vertical");
        
        var objectPos = _camera.WorldToScreenPoint(transform.position);
        var dir = Input.mousePosition - objectPos; 
        transform.rotation = Quaternion.Euler (new Vector3(0,0,Mathf.Atan2 (dir.y,dir.x) * Mathf.Rad2Deg - 90));
    }

    private void FixedUpdate()
    { 
        Vector2 movement = new Vector2(curAxeX, curAxeY).normalized;
        movement *= playerSpeed;
        rb.velocity = movement;
    }
}
