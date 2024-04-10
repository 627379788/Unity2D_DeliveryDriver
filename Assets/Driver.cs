using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]float steerSpeed = 300;
    [SerializeField]float moveSpeed = 20;
    [SerializeField]float boostSpeed = 30;
    [SerializeField]float slowSpeed = 15;

    void Start()
    {
        
    }

    
    void OnCollisionEnter2D(Collision2D other)
    {
        moveSpeed = slowSpeed;
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "boost") {
            moveSpeed = boostSpeed;
        }
    }
    // Update is called once per frame
    void Update()
    {
        float amountSteer = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float amountSpeed = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;
        transform.Translate(0,amountSpeed,0);
        transform.Rotate(0,0,-amountSteer);
    }
}
