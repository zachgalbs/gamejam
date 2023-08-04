using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    // movement horizontal
    float mH;
    float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mH = Input.GetAxis("Horizontal");

        transform.position = new Vector3(transform.position.x + mH * speed * Time.deltaTime, transform.position.y);
    }
}
