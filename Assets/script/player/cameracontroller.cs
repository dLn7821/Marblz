using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameracontroller : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private float cameraSpeed;

    private void Update()
    {
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
       
    }
}
