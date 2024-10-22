using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private GameObject target;

    Vector3 offset;

    void Start()
    {
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newCameraPosition = target.transform.position + offset;
        newCameraPosition.y = transform.position.y;

        transform.position = newCameraPosition;
    }
}
