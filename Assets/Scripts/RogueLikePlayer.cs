using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RogueLikePlayer : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10;


    void Start()
    {
        
    }

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Vector3 moveVector = new Vector3(h, 0, v);

        transform.position += moveVector * moveSpeed * Time.deltaTime;
    }
}
