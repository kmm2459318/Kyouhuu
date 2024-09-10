using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour
{
    public float jumpProbability = 0.1f; // ジャンプする確率（0から1までの間で設定）

    private bool Jump = true; // ジャンプが既に行われたかどうか
    void Update()
    {
        transform.Translate(-0.03f, 0, 0);
        
        if (transform.position.x > 11)
        {
            Destroy(gameObject);
        }
        if (Random.Range(0, 100) >= 99 && Jump == false)
        {
            transform.Translate(0, 5f, 0);
            Jump = true;
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Jump = false;
        }
        if (collision.gameObject.CompareTag("Player"))
        {
            // 衝突したオブジェクトが指定したタグを持っている場合に削除
            Destroy(gameObject);
            GameManager.Instance.Damage(2);
        }
    }
}
