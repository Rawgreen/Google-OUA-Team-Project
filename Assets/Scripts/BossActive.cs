using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossActive : MonoBehaviour
{
    [SerializeField] GameObject boss;

    private void Start()
    {
        boss.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            boss.SetActive(true);
        }
    }
}
