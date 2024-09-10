using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

   
    GameObject HPbar;
    int ID;
    float HP;

   
    void Start()
    {

        this.HPbar = GameObject.Find("HPbar");

        ID = excelData.ObstacleMaster[0].ID;
       // ID = excelData.PlayerMaster[0].ID;
        Debug.Log(ID);
        HP = excelData.PlayerMaster[0].HpMax;

    }
    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    [SerializeField] private ExcelData excelData; // データを格納


    //Damage処理を行う場所
    public void Damage(int i)
    {
        //HPを当たったオブジェクトのダメージの量減らす
        this.HPbar.GetComponent<Image>().fillAmount -= excelData.ObstacleMaster[i].Damage * 0.01f;
        this.HP -= excelData.ObstacleMaster[i].Damage;
        Debug.Log(excelData.ObstacleMaster[i].Damage);
        if (HP <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }

    }

    public void Scene()
    {
        if(HP > 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameClear");
        }
    }
}
