using UnityEngine;
using System.Collections;

public class Reflector : MonoBehaviour
{

    public GameObject grid;
    public GameObject moveBtn;

    public void clickReflector()
    {
        if (moveBtn.activeSelf)
        {
            grid.SetActive(true);
            Global.Reflector = this.gameObject;
        }
        else
        {
            transform.Rotate(Vector3.forward * 90);
        }
    }

    void Update()
    {
        float speed = 0.5F;
        if (Global.Reflector && Global.ReflectorPosition)
        {
            Global.Reflector.transform.position = Vector3.Lerp(Global.Reflector.transform.position, Global.ReflectorPosition.transform.position, speed);
            grid.SetActive(false);
        }
    }
}
