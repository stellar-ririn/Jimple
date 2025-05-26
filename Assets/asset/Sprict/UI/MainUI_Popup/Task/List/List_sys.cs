using UnityEngine;
using System.Collections.Generic;

public class List_sys : MonoBehaviour
{
    public GameObject listOb; // タスク一覧の親オブジェクト
    public List<GameObject> objects; // タスクのリストオブジェクト

    public string text;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0;i < objects.Count;i++)
        {
            objects[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public int CatchInt(int num,int point)
    {
        GameObject obj = objects[0];
        obj.SetActive(true);
        obj.GetComponent<SentTask>().taskpoint = point;
        obj.GetComponent<SentTask>().tasknum = num;
        obj.GetComponent<SentTask>().change(text);
        listOb.SetActive(false);
        return 0;
    }
}



/*
 obj.SetActive(false); // 非表示
 obj.SetActive(true);  // 表示

 */