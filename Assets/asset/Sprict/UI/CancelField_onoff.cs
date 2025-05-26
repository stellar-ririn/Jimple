using UnityEngine;

public class CancelField_onoff : MonoBehaviour
{
    [SerializeField] GameObject systems;
    [SerializeField] GameObject cancelobj;

    Sys_nowDoing sysnow;
    void Start()
    {
        cancelobj.SetActive(false);
        sysnow = systems.GetComponent<Sys_nowDoing>();
    }

    // Update is called once per frame
    void Update()
    {
        if (sysnow.nowDoing == 1)
        {
            cancelobj.SetActive(true);
        } else
        {
            cancelobj.SetActive(false);
        }
    }
}
