using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody paddle;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-7, 0, 0);
        paddle = GetComponent<Rigidbody>();
    }

        // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            paddle.AddForce(new Vector3(15, 0, 0), ForceMode.Force);
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            paddle.AddForce(new Vector3(-15, 0, 0), ForceMode.Force);
        }
    }
}
