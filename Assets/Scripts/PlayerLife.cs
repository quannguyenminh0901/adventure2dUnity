using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    private Animator a;
    private Rigidbody2D b;

    // Death Sound Effect
    [SerializeField] private AudioSource death;

    // Start is called before the first frame update
    void Start()
    {
        a = GetComponent<Animator>();
        b = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Trap"))
        {
            death.Play();
            Die();
        }
    }

    private void Die()
    {
        b.bodyType = RigidbodyType2D.Static;
        a.SetTrigger("death");
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("Terrain"))
        {
            // Kiểm tra nếu người chơi va chạm với Terrain, nghĩa là đã rơi ra khỏi terrain
            death.Play();
            Die();
        }
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
