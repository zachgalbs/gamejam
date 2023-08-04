using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlaye : MonoBehaviour
{
    public GameObject player;
    GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        wall = GameObject.Find("Wall");
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
            Destroy(wall);
        }
        
    }

}
