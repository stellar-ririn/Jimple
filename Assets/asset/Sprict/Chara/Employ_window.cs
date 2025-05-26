using UnityEngine;
using TMPro;

public class Employ_window : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI title;
    [SerializeField] TextMeshProUGUI infoText;

    [SerializeField] GameObject systems;

    int charaNum = 0; // 社員番号

    [SerializeField] GameObject taskscreen;
    [SerializeField] GameObject endScreen;


    // アバターに割り振られたタスクの記憶。
    public int taskpoint;
    public int tasknum;
    public string taskInfo;

    //社員の名前
    public string charaA;
    [SerializeField] GameObject A;
    public string charaB;
    [SerializeField] GameObject B;
    public string charaC;
    [SerializeField] GameObject C;

    private void Start()
    {
        taskscreen.SetActive(false);
        endScreen.SetActive(false);
    }

    public void InEnd() // タスク終わったら
    {
        endScreen.SetActive(true);
    }


    public int showInfo(int num)
    {
        string charaName = "";
        switch (num)
        {
            case 0:
                charaName = charaA;
                break;
            case 1:
                charaName = charaB;
                break;
            case 2:
                charaName = charaC;
                break;
        }
        taskscreen.SetActive(true);
        infoText.text = "対象：" + charaName + "\nこの仕事を受けますか？";
        charaNum = num;
        return 0;
    }

    public void Allow()
    {
        title.text = taskInfo;
        systems.GetComponent<Sys_Task>().SendAllow(charaNum);
        switch (charaNum)
        {
            case 0:
                A.GetComponent<ENDs>().tasknum = tasknum;
                break;
            case 1:
                B.GetComponent<ENDs>().tasknum = tasknum;
                break;
            case 2:
                C.GetComponent<ENDs>().tasknum = tasknum;
                break;
        }
        taskscreen.SetActive(false);
    }
}
