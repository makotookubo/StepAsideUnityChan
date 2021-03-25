using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    private GameObject mainCamobj;
    private GameObject unitychan;
    public GameObject coinPrefab;
    private float difference;


    // Start is called before the first frame update
    void Start()
    {
        this.transform.Rotate(0, Random.Range(0, 360), 0);

        mainCamobj = Camera.main.gameObject;
        this.unitychan = GameObject.Find("unitychan");
        this.difference = unitychan.transform.position.z - mainCamobj.transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(0, 3, 0);

        if (this.transform.position.z < unitychan.transform.position.z - difference)
        {
            Destroy(this.gameObject);
        }

    }
}
