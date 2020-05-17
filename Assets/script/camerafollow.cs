using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{

    [SerializeField]
    GameObject player;

    [SerializeField]
    float timeoffset;

    [SerializeField]
    Vector2 posoffset;

    private void Update()
    {
       

        if(player != null)
        {
            Vector3 startpost = transform.position;
            Vector3 endpos = player.transform.position;
            endpos.x += posoffset.x;
            endpos.y += posoffset.y;
            endpos.z = -10;
            transform.position = Vector3.Lerp(startpost, endpos, timeoffset * Time.deltaTime);
        }
    }
}
