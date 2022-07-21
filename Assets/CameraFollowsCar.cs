using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowsCar : MonoBehaviour
{
    // Here we want camera to follow our car
    [SerializeField] GameObject MyCar;

    void LateUpdate()
    {
        transform.position = MyCar.transform.position + new Vector3(0, 0, -10f);
    }
}
