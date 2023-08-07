using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reset : MonoBehaviour
{
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        player.GetComponent<PlayerMovement>().jumps = 20;
        PlayerPrefs.SetInt("MyBool", 0);
    }
}
