using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate2 : MonoBehaviour
{
    public GameObject player;
    public Animator animator;
    public CameraBehavior cameraBehavior;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(cameraBehavior.ShakeScreen(0.2f, 0.05f));
            animator.SetTrigger("plateActive");
        }
    }
}
