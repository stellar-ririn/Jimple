using UnityEngine;

public class Employ_screen : MonoBehaviour
{
    // �A�o�^�[�Ɋ���U��ꂽ�^�X�N�̋L���B
    public int taskpoint;
    public int tasknum;
    public string taskInfo;

    public int nowtype; //���݉�ʂ̊Ǘ���


    [SerializeField] GameObject taskscreen;
    [SerializeField] GameObject endScreen;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        taskscreen.SetActive(false);
        endScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InTask() // �^�X�N������U��ꂽ����
    {
        taskscreen.SetActive(true);
    }

    public void InEnd() // �^�X�N�I�������
    {
        endScreen.SetActive(true);
    }
}
