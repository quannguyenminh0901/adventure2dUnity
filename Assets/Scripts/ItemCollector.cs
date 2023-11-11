using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int fruits = 0;

    [SerializeField] private Text fruitsText;

    // Clame Sound Effect
    [SerializeField] private AudioSource clame;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Fruits"))
        {   
            clame.Play();
            Destroy(collision.gameObject);
            fruits++;
            fruitsText.text = "Fruits: " + fruits;
        }
    }
}
