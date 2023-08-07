using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class darkness2Behavior : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x + 2 * Time.deltaTime, transform.position.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerPrefs.SetInt("MyBool", 0);
            SceneManager.LoadScene(1);
        }
    }
}
