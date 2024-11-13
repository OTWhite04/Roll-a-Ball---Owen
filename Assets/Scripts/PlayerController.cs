using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(Rigidbody))]

public class PlayerController : MonoBehaviour
{
    public float speed = 0;
    public TextMeshProUGUI countText;
    public TextMeshProUGUI livesText;
    public GameObject winTextObject;
    public Transform respawnPoint;
    public Vector3 jump;
    public float jumpForce = 2.5f;
    public bool isGrounded;

    private Rigidbody rb;
    private int count;
    private int lives;
    private float movementX;
    private float movementY;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.5f, 0.0f);
        
        count = 0;
        lives = 3;

        SetCountText();
        winTextObject.SetActive(false);
        SetLivesText();
    }

    void OnCollisionStay()
    {
        isGrounded = true;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(jump * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }
        
        if(transform.position.y < -25)
        {
            Respawn();
            lives = lives - 1;
            SetLivesText();
        }
    }

   
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();

        movementX = movementVector.x;
        movementY = movementVector.y;
    }


    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);

        rb.AddForce(movement * speed);
    }

    void SetCountText()
    {
        countText.text = "Count:" + count.ToString();
        if (count >= 22)
        {
            winTextObject.SetActive(true);
        }
        
   
    }

    void SetLivesText()
    {
        livesText.text = "Lives:" + lives.ToString();

        if (lives == 0)
        {
            rb.Sleep();
            SceneManager.LoadScene("GameOver_Screen");
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
        }

        if(other.gameObject.CompareTag("Health Pickup"))
        {
            other.gameObject.SetActive(false);
            lives = lives + 1;
            SetLivesText();
        }

    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Respawn();
            lives = lives - 1;
            SetLivesText();
        }
    }


    void Respawn()
    {
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        rb.Sleep();
        transform.position = respawnPoint.position;
        
       
    }


   







}



