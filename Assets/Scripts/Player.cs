using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public float speed;

    Rigidbody2D rb;
    private Animator anim;
    AudioSource source;

    public int health;

    public Text healthDisplay;

    public GameObject losePanel;

    public float startDashTime;
    private float dashTime;
    public float extraSpeed;
    public bool isDashing;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        healthDisplay.text= health.ToString();
        source = GetComponent<AudioSource>();
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        float input = Input.GetAxisRaw("Horizontal");

        if (input != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else
        {
            anim.SetBool("isRunning", false);
        }

        if (input > 0)
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (input < 0)
        {
            transform.eulerAngles = new Vector3(0, 180, 0);
        }

        //moving player
        rb.velocity = new Vector2(input * speed, rb.velocity.y);

        //new
        if (Input.GetKeyDown(KeyCode.Space) && isDashing==false)
        {
            speed += extraSpeed;
            isDashing = true;
            dashTime = startDashTime;
        }

        if (dashTime <= 0 && isDashing==true)
        {
            isDashing = false;
            speed -= extraSpeed;
        }
        else
        {
            dashTime -= Time.deltaTime;
        }
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        healthDisplay.text = health.ToString();
        source.Play();

        if (health <= 0)
        {
            //destroy player
            losePanel.SetActive(true);
            Destroy(gameObject);
        }
    }

}
