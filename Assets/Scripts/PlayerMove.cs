using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public KeyCode walkU;
    public KeyCode walkD;
    public KeyCode walkL;
    public KeyCode walkR;

    public KeyCode lookU;
    public KeyCode lookD;
    public KeyCode lookL;
    public KeyCode lookR;

    public float walkSpeed;
    public float pov;

    Transform player;
    Vector3 position;

    void Start()
    {
        player = GetComponent<Transform>();
    }



    void FixedUpdate()
    {
        position = player.position;
    }

   void Update()
    {
        Move();
        ChangeViewPoint();
    }

    void Move()
    {
        if (Input.GetKey(walkD))
        {
            player.position = new Vector3(position.x , position.y-walkSpeed);
        }
        if (Input.GetKey(walkU))
        {
            player.position = new Vector3(position.x , position.y+walkSpeed);
        }
        if (Input.GetKey(walkL))
        {
            player.position = new Vector3(position.x-walkSpeed , position.y);
        }
        if (Input.GetKey(walkR))
        {
            player.position = new Vector3(position.x+walkSpeed, position.y);
        }
    }

    void ChangeViewPoint()
    {
        if (Input.GetKeyDown(lookD))
        {

        }
        if (Input.GetKeyDown(lookU))
        {

        }
        if (Input.GetKeyDown(lookL))
        {

        }
        if (Input.GetKeyDown(lookR))
        {

        }

        player.eulerAngles = new Vector3(0, 0, pov);
    }
}
