using UnityEngine;
using TMPro;

public class Taskinfo_Employ : MonoBehaviour
{
    int charaNum;
    [SerializeField] TextMeshProUGUI charaName_text;
    [SerializeField] TextMeshProUGUI nowTask;
    [SerializeField] TextMeshProUGUI nowInfo;

    [SerializeField] GameObject systems;
    [SerializeField] GameObject charas;

    public string charaName;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        charaNum = charas.GetComponent<Chara01sp>().CharaNum;
        charaName_text.text = charaName;
    }

    // Update is called once per frame
    void Update()
    {
        if (charas.GetComponent<Chara01sp>().ifWork == true && charas.GetComponent<Chara01sp>().ifwork_end == false)
        {
            nowTask.text = charas.GetComponent<Chara01sp>().taskInfo;
        } else
        {
            nowTask.text = "Ç»Çµ";
        }
    }

    public void EndTask()
    {
        systems.GetComponent<Sys_nowDoing>().nowDoing = 5;
    }

    public void Putout()
    {
        nowInfo.text = "ç∑ÇµñﬂÇµÇ≥ÇÍÇ‹ÇµÇΩÅB";
    }
}
