using UnityEngine;

public class Chara01sp : MonoBehaviour
{

    public int CharaNum = 0; // 社員の番号

    [SerializeField] GameObject chara_star;
    [SerializeField] GameObject system;
    [SerializeField] GameObject icon;
    [SerializeField] GameObject Uesr_view;

    [SerializeField] GameObject slaveView1;
    [SerializeField] GameObject slaveView2;
    [SerializeField] GameObject slaveView3;


    // アバターに割り振られたタスクの記憶。
    public int taskpoint;
    public int tasknum;
    public string taskInfo;

    Vector3 target;
    Vector3 nowpoint;
    public float speed = 2f;

    bool ifMove = false;
    public bool ifWork = false;
    public bool ifwork_end = true;

    bool inWait = false;

    // -------------指定座標----------------
    public Vector3 task_target0 = new Vector3(0, 0.5f, 0);  // point0 - エントランス
    public Vector3 task_target1 = new Vector3(0, 0.5f, 0);  // point1 - 録音室
    public Vector3 task_target2 = new Vector3(0, 0.5f, 0);  // point2 - スタジオ
    public Vector3 task_target3 = new Vector3(0, 0.5f, 0);  // point3 - オフィス
    public Vector3 task_target4 = new Vector3(0, 0.5f, 0);  // point4 - 休憩室

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        chara_star.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (ifMove == true && ifwork_end == true)
        {
            transform.position = Vector3.Lerp(transform.position, target, speed * Time.deltaTime);
            icon.GetComponent<Chara01_icon>().inMove = true;

            if (transform.position == nowpoint)
            {
                ifMove = false;
                icon.GetComponent<Chara01_icon>().inMove = false;
                ifWork = true;
            }
        }

        if (ifWork == true)
        {
            ifwork_end = false;
            icon.GetComponent<Chara01_icon>().inWork = true;
        } else
        {
            icon.GetComponent<Chara01_icon>().inWork = false;
            
            if (ifwork_end == false)
            {
                ifMove = true;
                transform.position = Vector3.Lerp(transform.position, task_target0, speed * Time.deltaTime);
                icon.GetComponent<Chara01_icon>().inMove = true;

                if (transform.position == nowpoint)
                {
                    ifMove = false;
                    icon.GetComponent<Chara01_icon>().inMove = false;
                    ifwork_end = true;
                }
            }
        }

        nowpoint = transform.position;
    }

    void OnMouseDown()
    {
        int nowtype = system.GetComponent<Sys_nowDoing>().nowDoing;

        switch (nowtype) {
            case 1: // タスク指定時
                system.GetComponent<Sys_Task>().sendTask(CharaNum);
                break;
            case 2:
                break;
            default: // タスク非選択時
                slaveView1.SetActive(false);
                slaveView2.SetActive(false);
                slaveView3.SetActive(false);

                if (chara_star.active == false) chara_star.SetActive(true);
                else chara_star.SetActive(false);
                break;
        }
    }

    public void setTask()
    {
        Debug.Log("Num[" + CharaNum + "] tasknom:" + tasknum + " taskpoint:" + taskpoint + "\ntasktext:" + taskInfo);
        /*
        while (true)
        {

        }*/
        Uesr_view.GetComponent<Employ_window>().taskInfo = taskInfo;
        Uesr_view.GetComponent<Employ_window>().showInfo(CharaNum);
        //ifMove = true;
        inWait = true;

        system.GetComponent<Sys_nowDoing>().nowDoing = 2;
    }

    public void start_work()
    {
        ifMove = false;
        ifWork = false;
        ifwork_end = true;
        switch (taskpoint)
        {
            case 0:
                target = task_target0;
                break;
            case 1:
                target = task_target1;
                break;
            case 2:
                target = task_target2;
                break;
            case 3:
                target = task_target3;
                break;
            case 4:
                target = task_target4;
                break;
        }
        slaveView3.SetActive(false);

        inWait = false;
        
        ifMove = true;
    }

}
