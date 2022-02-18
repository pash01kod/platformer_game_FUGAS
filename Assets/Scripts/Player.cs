using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 10, jumpVelocity = 10;
    public LayerMask playerMask;
    Transform myTrans, tagGround;
    Rigidbody2D myBody;
    bool isGrounded = false;

    public Camera mainCamera;
    Vector3 cameraPos;
    Transform t;

    private Vector3 respawnPoint;
    public GameObject fallDetector;



    void Start()
    {
        t = transform;
        myBody = this.GetComponent<Rigidbody2D>();
        myTrans = this.transform;
        tagGround = GameObject.Find(this.name + "/tag_ground").transform;

        if (mainCamera)
        {
            cameraPos = mainCamera.transform.position;
        }
        respawnPoint = transform.localPosition;
    }

    void Update()
    {
        isGrounded = Physics2D.Linecast(myTrans.position, tagGround.position, playerMask);

        /*
        Move(Input.GetAxisRaw("Horizontal"));
        if (Input.GetButtonDown("Jump"))
            Jump();
        */

        if (mainCamera)
        {
            mainCamera.transform.position = new Vector3(t.position.x, cameraPos.y, cameraPos.z);
        }
        fallDetector.transform.position = new Vector2(transform.position.x, fallDetector.transform.position.y);
    }

    public void Move(float horizonalInput)
    {
        

        Vector2 moveVel = myBody.velocity;
        moveVel.x = horizonalInput * speed;
        myBody.velocity = moveVel;
    }

    public void Jump()
    {
        if (isGrounded)
            myBody.velocity += jumpVelocity * Vector2.up;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "FallDetector")
        {
            HealthControl.health -= 1;
            transform.position = respawnPoint;
        }
        else if (collision.tag == "Checkpoint")
        {
            respawnPoint = transform.position;
        }
    }
}
