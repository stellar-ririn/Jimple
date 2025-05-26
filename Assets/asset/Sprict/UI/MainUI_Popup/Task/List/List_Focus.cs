using UnityEngine;

public class List_Focus : MonoBehaviour
{
    [SerializeField] GameObject lists;
    [SerializeField] GameObject thisTask;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void OnMouseDown()
    {
        lists.SetActive(true);
        thisTask.SetActive(false);
    }
}
