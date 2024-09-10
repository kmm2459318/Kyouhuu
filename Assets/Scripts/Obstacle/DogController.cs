using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogController : MonoBehaviour
{
    public float jumpProbability = 0.1f; // �W�����v����m���i0����1�܂ł̊ԂŐݒ�j

    private bool Jump = true; // �W�����v�����ɍs��ꂽ���ǂ���
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
            // �Փ˂����I�u�W�F�N�g���w�肵���^�O�������Ă���ꍇ�ɍ폜
            Destroy(gameObject);
            GameManager.Instance.Damage(2);
        }
    }
}
