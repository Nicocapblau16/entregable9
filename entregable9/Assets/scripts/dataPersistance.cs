using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dataPersistance : MonoBehaviour
{


    //public static dataPersistance sharedInstance;
    //public string userName;

    private void Awake()
    {
        DontDestroyOnLoad(this);
        /*if (sharedInstance == null)
        {
            //sharedInstance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(gameObject);
        }*/
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
