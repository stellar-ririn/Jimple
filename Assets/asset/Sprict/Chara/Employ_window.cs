using UnityEngine;
using TMPro;

public class Employ_window : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI title;
    [SerializeField] TextMeshProUGUI infoText;

    [SerializeField] GameObject systems;

    int charaNum = 0; // �Ј��ԍ�

    [SerializeField] GameObject taskscreen;
    [SerializeField] GameObject endScreen;


    // �A�o�^�[�Ɋ���U��ꂽ�^�X�N�̋L���B
    public int taskpoint;
    public int tasknum;
    public string taskInfo;

    //�Ј��̖��O
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

    public void InEnd() // �^�X�N�I�������
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
        infoText.text = "�ΏہF" + charaName + "\n���̎d�����󂯂܂����H";
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
