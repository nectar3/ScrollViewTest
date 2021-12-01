using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraTo : MonoBehaviour
{

    public float moveSpeed = 1f;
    Vector3 initOffset;


    private void Start()
    {
        initOffset = transform.position - Vector3.zero;
    }


    public void MoveTo(Vector3 target)
    {
        var to = initOffset + target;
        StopAllCoroutines();
        StartCoroutine(MoveTo__(to));
    }

    IEnumerator MoveTo__(Vector3 target)
    {
        while (true)
        {
            transform.position = Vector3.Lerp(transform.position, target, Time.deltaTime * moveSpeed);
            if (Vector3.Distance(target, transform.position) < 0.02f)
            {
                transform.position = target;
                break;
            }
            yield return null;
        }
    }


}
