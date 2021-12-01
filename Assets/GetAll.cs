using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAll : MonoBehaviour
{

    //TODO: Ŭ�� ������Ʈ�� ī�޶� �̵�
    //TODO: ����Ʈ ����� 

    void Start()
    {




    }



    void GetAllObj()
    {

        foreach (GameObject obj in Object.FindObjectsOfType(typeof(GameObject)))
        {
            if (obj.transform.parent == null)
            {
                Traverse(obj);
            }
        }
    }


    void Traverse(GameObject obj)
    {
        foreach (Transform child in obj.transform)
        {
            Debug.Log(child.name);
            Traverse(child.gameObject);
        }
    }
}
