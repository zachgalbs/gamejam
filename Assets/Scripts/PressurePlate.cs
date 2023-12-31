using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public GameObject player;
    public Animator animator;
    public CameraBehavior cameraBehavior;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("ball"))
        {
            StartCoroutine(cameraBehavior.ShakeScreen(0.2f, 0.05f));
            player.transform.position = new Vector3(9, -2, 0);
            animator.SetTrigger("plateActive");
            //Destroy(wall);
        }
        
    }

}
