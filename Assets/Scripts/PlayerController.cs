using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private ExcelData excelData; // ÉfÅ[É^Çäiî[

    bool Jump = false;
    Rigidbody2D rigid2D;
    float junp;
    float junpTime;
    float Maxspeed;
    float speed;


    void Start()
    {
        this.rigid2D = GetComponent<Rigidbody2D>();
        junpTime = excelData.PlayerMaster[0].JumpTime;
        Maxspeed = excelData.PlayerMaster[0].DistanceX;
        junp = excelData.PlayerMaster[0].DistanceY;
    }
    void Update()
    {
        if (UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject != null)
            return;

        if (Input.GetMouseButtonDown(0)&& Jump == false)
        {
            this.rigid2D.AddForce(transform.up * this.junp * 3.5f);
            Jump = true;
            Debug.Log("aaa");
        }
    }

    public void LButtonDown()
    {
        Vector2 PlayerPos = transform.position;
        PlayerPos.x -= Maxspeed / 50;
        if (PlayerPos.x  <= -8)
        {
            PlayerPos.x = -8;
        }
        transform.position = PlayerPos;
    }

    public void RButtonDown()
    {
        Vector2 PlayerPos = transform.position;
        PlayerPos.x += Maxspeed / 50;
        if (PlayerPos.x >= 8)
        {
            PlayerPos.x = 8;
        }
        transform.position = PlayerPos;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("aaa");
        if (collision.gameObject.CompareTag("Ground"))
        {
            Jump = false;
        }
    }
}
