using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float forceJump;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y < 0)
        {
            Bird.instance.BirdRigid.velocity = Vector2.up * forceJump;
        }

    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.name == "DeadZone")
        {
            float RandX = Random.Range(-5.5f, 5.5f);
            float RandY = Random.Range(transform.position.y + 25f, transform.position.y + 25f);

            transform.position = new Vector3(RandX, RandY, 0);


        }
    }

}
