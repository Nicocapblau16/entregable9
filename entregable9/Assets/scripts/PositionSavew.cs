using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionSavew : MonoBehaviour
{

    private float PlayerX;
    private float PlayerY;
    private float PlayerZ;

    void Start()
    {
        transform.position = new Vector3(PlayerPrefs.GetFloat("PlayerX"), PlayerPrefs.GetFloat("PlayerY"), PlayerPrefs.GetFloat("PlayerZ"));
    }


    void Update()
    {
        PlayerPrefs.SetFloat("PlayerX", transform.position.x);
        PlayerPrefs.SetFloat("PlayerY", transform.position.y);
        PlayerPrefs.SetFloat("PlayerZ", transform.position.z);
    }
}
