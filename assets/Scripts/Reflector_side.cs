using UnityEngine;
using System.Collections;

public class Reflector_side : MonoBehaviour
{
    private int speed = Global.speed;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.name == "Laser(Clone)")
        {
            if (col.gameObject.GetComponent<Rigidbody2D>().velocity.y > 0)
            {
                if (this.transform.parent.transform.rotation.eulerAngles.z == 90)
                {
                    col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(speed * -1, 0);
                }

                if (this.transform.parent.transform.rotation.eulerAngles.z == 180)
                {
                    col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
                }

            }

            if (col.gameObject.GetComponent<Rigidbody2D>().velocity.y < 0)
            {
                if (this.transform.parent.transform.rotation.eulerAngles.z == 0)
                {
                    col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(speed * -1, 0);
                }

                if (this.transform.parent.transform.rotation.eulerAngles.z == 270)
                {
                    col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
                }

            }

            if (col.gameObject.GetComponent<Rigidbody2D>().velocity.x > 0)
            {
                if (this.transform.parent.transform.rotation.eulerAngles.z == 90)
                {
                    col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed * -1);
                }

                if (this.transform.parent.transform.rotation.eulerAngles.z == 0)
                {
                    col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
                }

            }

            if (col.gameObject.GetComponent<Rigidbody2D>().velocity.x < 0)
            {
                if (this.transform.parent.transform.rotation.eulerAngles.z == 180)
                {
                    col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed * -1);
                }

                if (this.transform.parent.transform.rotation.eulerAngles.z == 270)
                {
                    col.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0, speed);
                }

            }
        }
    }
}