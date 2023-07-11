using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bird : MonoBehaviour
{
    [SerializeField] private bool _lookRight;
    public float speed = 10f;
    SpriteRenderer sr;
    // Start is called before the first frame update
    public static Bird instance;

    float horizontal;
    public Rigidbody2D BirdRigid;
    
    private AudioSource audioSource;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();

        if (instance ==null)
        {
            instance = this;
        }

        
            audioSource = GetComponent<AudioSource>();
            audioSource.Play();
        
    }

    void Update()
    {
        float movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * speed * Time.deltaTime;

        sr.flipX = movement > 0 ? true : false;

        if (Music.isOn1 == true)
        {
            audioSource.enabled = true;
        }
       
    }
    // Update is called once per frame
    void Move()
    {
        

        BirdRigid.velocity = new Vector2(Input.acceleration.x * 10f, BirdRigid.velocity.y);

        CheckFlip();

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            SceneManager.LoadScene(0);
           
            audioSource.Stop();
        }
    }

    private void CheckFlip()
    {
        if (Input.acceleration.x > 0 && !_lookRight)
        {
            Flip();
        }
        else if (Input.acceleration.x < 0 && !_lookRight)
        {
            Flip();
        }
               
    }

    private void Flip()
    {
        transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
        _lookRight = !_lookRight;
    }
}
