using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
  public Transform target;
    public float Smoothing;
    public  Vector2 minPos;
    public Vector2 maxPos;

    void Start()
    {
        

    }

    void LateUpdate()
    {
        

        if(transform.position != target.position)
        {

            Vector3 TargetPos = new Vector3(target.position.x, target.position.y, transform.position.z);

            TargetPos.x = Mathf.Clamp(TargetPos.x, minPos.x, maxPos.x);
            TargetPos.y = Mathf.Clamp(TargetPos.y, minPos.y, maxPos.y);


            transform.position = Vector3.Lerp(transform.position, TargetPos, Smoothing);
           
        }

        

    }
}
