using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AbilityBehavior : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("bruh");
        Destroy(gameObject);
        PlayerPrefs.SetInt("MyBool", 1);
    }
}
