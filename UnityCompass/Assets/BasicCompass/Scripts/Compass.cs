using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Compass : MonoBehaviour
{
    
    public SyncMap syncMapCompass;
    public Transform playerTransform;
    Vector3 dir;

    private void Start()
    {
        playerTransform.eulerAngles = syncMapCompass.localCompass.eulerAngles;
    }

    private void Update()
    {
        
        
        dir.z = playerTransform.eulerAngles.y;
        //dir.z = syncMapCompass.localCompass.eulerAngles.y;
        transform.localEulerAngles = dir;
    }


}
