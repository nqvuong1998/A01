using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 10f; // Set movement speed
    public float jumpSpeed = 10f; // Set jump speed
    //public AudioClip jumpSound; // Set jump sound when player press space
    Rigidbody2D rb2d;  // Get current rigidbody for physics
    Animator anim; // Get current animator for animation

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>(); // Get the Rigidbody component
        anim = GetComponent<Animator>(); // Get the Animation component
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) // When player press space
        {
            rb2d.AddForce(new Vector2(0, jumpSpeed)); // Add force to get character up (x = 0, y = jumpSpeed)
            anim.Play("MarioMove"); // Call animator for playing animation with name MarioMove
            //GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>().PlaySoundOneTime(jumpSound); // Get global SoundManager object to play sound
        }
        if (Input.GetKey(KeyCode.RightArrow)) // When player press right arrow
        {
            rb2d.AddForce(new Vector2(moveSpeed, 0f)); // Add force to get character move to right ( x = moveSpeed, y = 0)
            anim.Play("MarioMove"); // Call animator for playing animation with name MarioMove
            transform.localEulerAngles = Vector3.zero; // Rotate Mario to face right with Euler Angle
        }
        else
        {
            if (Input.GetKey(KeyCode.LeftArrow)) // When player press left arrow
            {
                rb2d.AddForce(new Vector2(-moveSpeed, 0f)); // Add force to get character move to left ( x = - moveSpeed, y = 0)
                anim.Play("MarioMove"); // Call animator for playing animation with name MarioMove
                transform.localEulerAngles = new Vector3(0, 180f, 0); // Rotate Mario to face left (180 degress in y axis) with Euler Angle
            }
            else
                anim.Play("MarioIdle"); // Call animator for playing animation with name MarioIdle when Mario not moving

        }
    }
}
