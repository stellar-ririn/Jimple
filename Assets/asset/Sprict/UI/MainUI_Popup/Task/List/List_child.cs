using UnityEngine;
using TMPro;

public class List_child : MonoBehaviour
{
    public int num;
    public int point;
    public GameObject listsys;
    [SerializeField] string text;
    [SerializeField] TextMeshProUGUI Task;

    void OnMouseDown()
    {
        listsys.GetComponent<List_sys>().text = text;
        listsys.GetComponent<List_sys>().CatchInt(num,point);
    }

    void OnEnable()
    {
        Task.text = text;
    }
}
