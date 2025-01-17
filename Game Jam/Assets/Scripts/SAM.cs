﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAM : MonoBehaviour
{
    public Transform target;
    private Rigidbody2D rb;
    public float thrust = 3.0f;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.up * thrust);
        /*Vector2 direction = target.position - transform.position;
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, speed * Time.deltaTime);*/
    }
}