using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConeController : MonoBehaviour
{
    private GameObject mainCamobj;
    private GameObject unitychan;
    public GameObject conePrefab;
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        mainCamobj = Camera.main.gameObject;
        this.unitychan = GameObject.Find("unitychan");
        this.difference = unitychan.transform.position.z - mainCamobj.transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.position.z < unitychan.transform.position.z - difference)
        {
            Destroy(this.gameObject);
        }
    }
}
