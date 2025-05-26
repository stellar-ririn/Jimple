using UnityEngine;

public class ListMaterial : MonoBehaviour
{
    public int num; // É^ÉXÉNÇÃî‘çÜ

    [SerializeField] Material nomalmate;
    [SerializeField] Material endmate;

    [SerializeField] GameObject systems;
 
    void OnEnable()
    {
        switch (num)
        {
            case 0:
                if (systems.GetComponent<Sys_nowDoing>().task0 == true)
                {
                    gameObject.GetComponent<MeshRenderer>().material = nomalmate;
                } else
                {
                    gameObject.GetComponent<MeshRenderer>().material = endmate;
                }
                break;
            case 1:
                if (systems.GetComponent<Sys_nowDoing>().task1 == true)
                {
                    gameObject.GetComponent<MeshRenderer>().material = nomalmate;
                }
                else
                {
                    gameObject.GetComponent<MeshRenderer>().material = endmate;
                }
                break;
            case 2:
                if (systems.GetComponent<Sys_nowDoing>().task2 == true)
                {
                    gameObject.GetComponent<MeshRenderer>().material = nomalmate;
                }
                else
                {
                    gameObject.GetComponent<MeshRenderer>().material = endmate;
                }
                break;
            case 3:
                if (systems.GetComponent<Sys_nowDoing>().task3 == true)
                {
                    gameObject.GetComponent<MeshRenderer>().material = nomalmate;
                }
                else
                {
                    gameObject.GetComponent<MeshRenderer>().material = endmate;
                }
                break;
            case 4:
                if (systems.GetComponent<Sys_nowDoing>().task4 == true)
                {
                    gameObject.GetComponent<MeshRenderer>().material = nomalmate;
                }
                else
                {
                    gameObject.GetComponent<MeshRenderer>().material = endmate;
                }
                break;
            case 5:
                if (systems.GetComponent<Sys_nowDoing>().task5 == true)
                {
                    gameObject.GetComponent<MeshRenderer>().material = nomalmate;
                }
                else
                {
                    gameObject.GetComponent<MeshRenderer>().material = endmate;
                }
                break;
            case 6:
                if (systems.GetComponent<Sys_nowDoing>().task6 == true)
                {
                    gameObject.GetComponent<MeshRenderer>().material = nomalmate;
                }
                else
                {
                    gameObject.GetComponent<MeshRenderer>().material = endmate;
                }
                break;
            case 7:
                if (systems.GetComponent<Sys_nowDoing>().task7 == true)
                {
                    gameObject.GetComponent<MeshRenderer>().material = nomalmate;
                }
                else
                {
                    gameObject.GetComponent<MeshRenderer>().material = endmate;
                }
                break;
            case 8:
                if (systems.GetComponent<Sys_nowDoing>().task8 == true)
                {
                    gameObject.GetComponent<MeshRenderer>().material = nomalmate;
                }
                else
                {
                    gameObject.GetComponent<MeshRenderer>().material = endmate;
                }
                break;
        }
    }
}
