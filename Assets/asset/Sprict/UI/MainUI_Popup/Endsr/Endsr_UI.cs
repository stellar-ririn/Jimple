using UnityEngine;
using TMPro;

public class Endsr_UI : MonoBehaviour
{
    [SerializeField] GameObject endUI;

    [SerializeField] TextMeshProUGUI title;
    [SerializeField] TextMeshProUGUI text;

    [SerializeField] GameObject systems;

    [SerializeField] GameObject charaA;
    [SerializeField] GameObject charaB;
    [SerializeField] GameObject charaC;


    public string taskname;
    public string charanameA;
    public string charanameB;
    public string charanameC;

    bool endBool = false;
    int chara_namber;
    int tasknums = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        endUI.SetActive(false);
    }
    
    public int endCatch(int charanum,int tasknum)
    {
        endBool = true;
        tasknums = tasknum;
        string charaname = "";
        switch (charanum)
        {
            case 0:
                charaname = charanameA;
                chara_namber = 1;
                break;
            case 1:
                charaname = charanameB;
                chara_namber = 2;
                break;
            case 2:
                charaname = charanameC;
                chara_namber = 3;
                break;
                
        }
        endUI.SetActive(true);
        title.text = "完了報告";
        text.text = charaname + "が、タスク【" + taskname + "】の完了報告をしました。";
        endBool = true;
        return 0;
    }

    public int sendAns(int num)
    {
        if (num == 0)
        {
            systems.GetComponent<Sys_nowDoing>().EndTask(tasknums);
            systems.GetComponent<Sys_nowDoing>().nowDoing = 0;
        }
        else
        {
            switch (chara_namber)
            {
                case 1:
                    charaA.GetComponent<Taskinfo_Employ>().Putout();
                    break;
                case 2:
                    charaB.GetComponent<Taskinfo_Employ>().Putout();
                    break;
                case 3:
                    charaC.GetComponent<Taskinfo_Employ>().Putout();
                    break;


            }
        }
        return 0;
    }

}
