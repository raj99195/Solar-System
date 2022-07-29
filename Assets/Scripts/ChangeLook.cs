using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLook : MonoBehaviour
{

    public GameObject target;
    void OnMouseDown()
    {
    // change the target of the LookAtTarget script to be this gameobject.
        LookAt.target = target;
    // change the field of view on the perspective camera based on the distance from center of world, clamp it to a reasonable field of view
        Camera.main.fieldOfView = Mathf.Clamp(60 * target.transform.localScale.x, 1, 100);
    }
}
