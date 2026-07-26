using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    [SerializeField] private Transform targetPosition; // 傳送目的地

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // 確保只傳送玩家
        {
            other.transform.position = targetPosition.position;
        }
    }
}
