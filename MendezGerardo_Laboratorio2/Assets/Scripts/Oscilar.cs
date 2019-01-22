using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscilar : MonoBehaviour
{
    private float distance = 1.3f;
    private float speed = 1.8f;
    private Vector3 posicionInicial;

    // Start is called before the first frame update
    void Start()
    {
        posicionInicial = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = posicionInicial;
        vector.y += distance * Mathf.Sin(Time.time * speed);
        transform.position = vector;
    }
}
