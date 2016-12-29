using UnityEngine;
using System.Collections;

public class ReflectorPosition : MonoBehaviour
{
    public void clickPosition()
    {
        Global.ReflectorPosition = this.gameObject;

        Invoke("RemoveGlobalObjects", 0.5F);
    }

    public void RemoveGlobalObjects()
    {
        Global.ReflectorPosition = null;
        Global.Reflector = null;
    }
}
