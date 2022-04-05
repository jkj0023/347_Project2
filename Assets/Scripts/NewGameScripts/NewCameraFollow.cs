using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCameraFollow : MonoBehaviour
{
    public Transform target;

    private void LateUpdate()
    {
        //player pos vs camera pos
        if (target.position.y > transform.position.y || target.position.y < transform.position.y)
        {
            Vector3 newPosition = new Vector3(transform.position.x, target.position.y, transform.position.z);
            transform.position = newPosition;
        }
        else if (target.position.x > transform.position.x || target.position.x < transform.position.x)
        {
            Vector3 newPosition = new Vector3(target.position.x, transform.position.y, transform.position.z);
            transform.position = newPosition;
        }
    }
}
