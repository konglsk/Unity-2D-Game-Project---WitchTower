using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
    [SerializeField] private GameObject winImage; // 全屏圖片

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) // 玩家到達終點
        {
            winImage.SetActive(true); // 顯示全屏圖片
            Time.timeScale = 0f; // 可選：暫停遊戲
        }
    }
}