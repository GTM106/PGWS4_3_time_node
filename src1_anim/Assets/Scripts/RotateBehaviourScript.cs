using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviourScript : MonoBehaviour
{
    void Update()
    {
        float rotate = 360f * Time.deltaTime / 10f;

        transform.Rotate(0f, rotate, 0f);
    }
}
