using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SyncMap : MonoBehaviour
{
    Quaternion worldCompass;
    public Quaternion localCompass;
    public GameObject Player;
    public GameObject origin;

    // Start is called before the first frame update
    void Start()
    {
        worldCompass= Quaternion.Euler(0, 180, 0);
        //transform.rotation = worldCompass;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(origin.transform.position.x, 0, origin.transform.position.z);
        //180 - a
        localCompass = (origin.transform.rotation);
        transform.rotation = Quaternion.Euler(0, worldCompass.eulerAngles.y - localCompass.eulerAngles.y, 0);
    }
}
