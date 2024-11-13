using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRotator : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(25, 50, 75) * Time.deltaTime);
    }
}
