using UnityEngine;
using System.Collections.Generic;

public class Sys_Task : MonoBehaviour
{
    [SerializeField] List<GameObject> charas;
    [SerializeField] GameObject systems_num;

    public int _taskpoint;
    public int _tasknum;
    public string _taskInfo;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int sendTask(int charaNum)
    {
        GameObject obj = charas[charaNum];
        Chara01sp chara = obj.GetComponent<Chara01sp>();
        chara.taskInfo = _taskInfo;
        chara.tasknum = _tasknum;
        chara.taskpoint = _taskpoint;

        chara.setTask();

        return 0;
    }

    public int SendAllow(int num)
    {
        GameObject obj = charas[num];
        Chara01sp chara = obj.GetComponent<Chara01sp>();
        chara.start_work();

        systems_num.GetComponent<Sys_nowDoing>().nowDoing = 0;
        return 0;
    }
}
