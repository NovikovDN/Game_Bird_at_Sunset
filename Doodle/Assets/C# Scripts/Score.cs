using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
      public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            float RandX = Random.Range(-4.5f, 4.5f);
            float RandY = Random.Range(transform.position.y + 30f, transform.position.y + 40f);

            transform.position = new Vector3(RandX, RandY, 0);
        }

        if (collision.collider.name == "Bird")
        {
            ScoreManager.score += 1;

            float RandXX = Random.Range(-4.5f, 4.5f);
            float RandYY = Random.Range(transform.position.y + 20f, transform.position.y + 30f);

            transform.position = new Vector3(RandXX, RandYY, 0);

        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            ScoreManager.score += 1;
            
            float RandXX = Random.Range(-4.5f, 4.5f);
            float RandYY = Random.Range(transform.position.y + 20f, transform.position.y + 30f);

            transform.position = new Vector3(RandXX, RandYY, 0);

        }
        if (collision.CompareTag("Deadzone"))
        {
            Destroy(gameObject);


        }
    }
}
