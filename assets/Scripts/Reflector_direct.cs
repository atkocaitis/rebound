using UnityEngine;
using System.Collections;

public class Reflector_direct : MonoBehaviour
{
    private int speed = Global.speed;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Laser(Clone)")
        {
            if (col.gameObject.GetComponent<Rigidbody2D>().velocity.y != 0)
            {
                if (col.gameObject.GetComponent<Rigidbody2D>().velocity.y > 0)
                {
                    col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed * -1);
                }
                else
                {
                    col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
                }
            }
            else
            {
                if (col.gameObject.GetComponent<Rigidbody2D>().velocity.x > 0)
                {
                    col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(speed * -1, 0);
                }
                else
                {
                    col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
                }
            }
        }
    }
}