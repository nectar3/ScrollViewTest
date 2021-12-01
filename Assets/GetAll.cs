using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetAll : MonoBehaviour
{

    //TODO: 클릭 오브젝트로 카메라 이동
    //TODO: 리스트 만들기 

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
