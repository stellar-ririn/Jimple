using UnityEngine;
using TMPro;

public class InfoUI : MonoBehaviour
{

    public int type; // ���݂̏�
    public int chara_num = 0;
    [SerializeField] TextMeshProUGUI taskText;
    public string texts;

    [SerializeField] GameObject systems;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        texts = "�ҋ@���c";
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

        if (type == 1) // �w����
        {
            texts = "���蓖�Ă�l��I�����Ă�������";
            taskText.text = texts;
        } else if (type == 2) //�w���ҋ@
        {
            texts = "���[�U�̎d���m�F��ҋ@���Ă��܂�";
            taskText.text = texts;
        } else if (type == 3) //���[�U���L�����Z����
        {
            texts = "���[�U���d�����L�����Z�����܂���";
            taskText.text = texts;
        } else if (type == 4) //�w����L�����Z��
        {
            texts = "�w����L�����Z�����܂���";
            taskText.text = texts;
        }else if (type == 5)
        {
            texts = "�����񍐂��͂��܂���";
            taskText.text = texts;
        } 
        else
        {
            texts = "�ҋ@���c";
            taskText.text = texts;
        }
    }
}
