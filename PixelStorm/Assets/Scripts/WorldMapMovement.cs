using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMapMovement : MonoBehaviour
{
    Transform transformPos;
    public float raycastRange = 0.8f;
    public float speed = 0.2f;

    void Start()
    {
        transformPos = GetComponent<Transform>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.up) * raycastRange, Color.red);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.up), raycastRange);
            if (hit && (hit.collider.tag != "Entrance"))
            {
                Debug.Log("Hit Something: " + hit.collider.name);
             
            }
            else
                transformPos.Translate(0, speed, 0);

        }
        if (Input.GetKey(KeyCode.A))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.left) * raycastRange, Color.red);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.left), raycastRange);
            if (hit && (hit.collider.tag != "Entrance"))
            {
                Debug.Log("Hit Something: " + hit.collider.name);
            }
            else
                transformPos.Translate(-speed, 0, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.down) * raycastRange, Color.red);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.down), raycastRange);
            if (hit && (hit.collider.tag != "Entrance"))
            {
                Debug.Log("Hit Something: " + hit.collider.name);
            }
            else
                transformPos.Translate(0, -speed, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector2.right) * raycastRange, Color.red);
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.TransformDirection(Vector2.right), raycastRange);
            if (hit && (hit.collider.tag != "Entrance"))
            {
                Debug.Log("Hit Something: " + hit.collider.name);
            }
            else
                transformPos.Translate(speed, 0, 0);
        }


    }
}
