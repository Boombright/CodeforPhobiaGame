using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddReduceplayerMoney : MonoBehaviour
{
    public GameObject cam;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown(""))
        {
            cam.GetComponent<playerMoney>().AddMoney(5);
        }
        if(Input.GetButtonDown(""))
        {
            cam.GetComponent<playerMoney>().subtractMoney(5);
        }
    }
}
