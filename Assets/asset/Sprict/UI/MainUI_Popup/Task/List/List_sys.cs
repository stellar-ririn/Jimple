using UnityEngine;
using System.Collections.Generic;

public class List_sys : MonoBehaviour
{
    public GameObject listOb; // �^�X�N�ꗗ�̐e�I�u�W�F�N�g
    public List<GameObject> objects; // �^�X�N�̃��X�g�I�u�W�F�N�g

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
 obj.SetActive(false); // ��\��
 obj.SetActive(true);  // �\��

 */