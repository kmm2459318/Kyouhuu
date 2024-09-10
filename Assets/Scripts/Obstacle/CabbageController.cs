using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabbageController : MonoBehaviour
{
    void Update()
    {
        transform.Translate(0.03f, 0, 0);
        if (transform.position.x > 11)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // 衝突したオブジェクトが指定したタグを持っている場合に削除
            Destroy(gameObject);
            GameManager.Instance.Damage(1);
        }
    }
}
