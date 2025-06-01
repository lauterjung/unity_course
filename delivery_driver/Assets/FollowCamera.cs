using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    private static readonly Vector3 Offset = new Vector3(0, 0, -20);

    void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + Offset;
    }
}
