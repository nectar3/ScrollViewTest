using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RuntimeInspectorNamespace;

public class HEventControl : MonoBehaviour
{

    public GameObject runtimeHierarchy;
    public GameObject CameraRig;

    RuntimeHierarchy hierarchy;


    void Start()
    {
        hierarchy = runtimeHierarchy.GetComponent<RuntimeHierarchy>();
        hierarchy.OnItemDoubleClicked += (clickedItem) =>
        {
            Debug.Log(clickedItem.Name);
            CameraRig.GetComponent<MoveCameraTo>().MoveTo(clickedItem.BoundTransform.position);
        };
    }


}
