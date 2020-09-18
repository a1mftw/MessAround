using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablePopUp : MonoBehaviour
{
    public GameObject popup;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Reached Entrance!");
            popup.SetActive(true);
        }
    }
}
