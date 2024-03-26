using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnviroMovement : MonoBehaviour
{
    [SerializeField] private float speed = 1f;
    void Update()
    {
        transform.position -= Vector3.right * speed * Time.deltaTime;
    }
}
