using UnityEngine;
using TMPro;

public class InfoUI : MonoBehaviour
{

    public int type; // 現在の状況
    public int chara_num = 0;
    [SerializeField] TextMeshProUGUI taskText;
    public string texts;

    [SerializeField] GameObject systems;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        texts = "待機中…";
        taskText.text = texts;
    }

    // Update is called once per frame
    void Update()
    {
        int nowtype = systems.GetComponent<Sys_nowDoing>().nowDoing;
        if (nowtype == 1)
        {
            type = 1;
        } else if (nowtype == 2)
        {
            type = 2;
        } else if (nowtype == 3)
        {
            type = 3;
        } else if (nowtype == 4)
        {
            type = 4;
        } else
        {
            type = 0;
        }

        if (type == 1) // 指定状態
        {
            texts = "割り当てる人を選択してください";
            taskText.text = texts;
        } else if (type == 2) //指定後待機
        {
            texts = "ユーザの仕事確認を待機しています";
            taskText.text = texts;
        } else if (type == 3) //ユーザがキャンセル時
        {
            texts = "ユーザが仕事をキャンセルしました";
            taskText.text = texts;
        } else if (type == 4) //指定をキャンセル
        {
            texts = "指定をキャンセルしました";
            taskText.text = texts;
        }else if (type == 5)
        {
            texts = "完了報告が届きました";
            taskText.text = texts;
        } 
        else
        {
            texts = "待機中…";
            taskText.text = texts;
        }
    }
}
