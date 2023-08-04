using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlaye : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            player.transform.position = new Vector3(9, -2, 0);
        }
        
    }

}
