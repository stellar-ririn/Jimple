using UnityEngine;

public class Pages : MonoBehaviour
{
    public int page;//�y�[�W�w��

    [SerializeField] GameObject taskpage;
    [SerializeField] GameObject mainpage;
    private void Awake()
    {
        if (page == 1)
        {
            taskpage.SetActive(false);
        }
    }


    private void OnMouseDown()
    {
        if (page == 1)
        {
            taskpage.SetActive(true);
            mainpage.SetActive(false);
        } else
        {
            mainpage.SetActive(true);
            taskpage.SetActive(false);
        }
    }
}
