using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using TMPro;
using UnityEngine;

public class ballMovement : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody Ball;

    [SerializeField]
    GameObject textGameObject;

    TextMeshProUGUI textComponent;

    int lives = 3;

    void Start()
    {
        Ball = GetComponent<Rigidbody>();
        Ball.AddForce(new Vector3(0, -5, 0), ForceMode.Impulse); 
        
        textComponent = textGameObject.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 10;
        Ball.velocity = Ball.velocity.normalized * speed;

        string livesText = "Lives: " + lives;
        textComponent.text = livesText;

        if (transform.position.y <= -3)
        {
            transform.position = new Vector3(-9, 10, 0);
            Ball.AddForce(new Vector3(0, -5, 0), ForceMode.Impulse);

            lives -= 1;
        }

        if (Input.GetKey(KeyCode.Space))
        {
            transform.position = new Vector3(-9, 10, 0);
            Ball.AddForce(new Vector3(0, -5, 0), ForceMode.Impulse);
        }

        if (lives == -1)
        {
            Destroy(gameObject);
        }
    }
}
