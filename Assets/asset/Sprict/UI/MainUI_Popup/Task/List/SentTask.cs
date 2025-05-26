using UnityEngine;
using TMPro;

public class SentTask : MonoBehaviour
{
    public int tasknum;
    public int taskpoint;
    public string taskInfo;

    [SerializeField] TextMeshProUGUI taskText;

    [SerializeField] GameObject system;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        taskText.text = taskInfo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Send_task()
    {
        Sys_Task tasks = system.GetComponent<Sys_Task>();
        Sys_nowDoing nowsys = system.GetComponent<Sys_nowDoing>();

        tasks._taskInfo = taskInfo;
        tasks._tasknum = tasknum;
        tasks._taskpoint = taskpoint;
        nowsys.nowDoing = 1;
    }

    public string change(string text)
    {
        taskText.text = text;
        taskInfo = text;
        return "0";
    }
    
}

/*
public int Send_Task(int tasknum, int taskpoint, int chara)
{

    return 0;
}
*/
