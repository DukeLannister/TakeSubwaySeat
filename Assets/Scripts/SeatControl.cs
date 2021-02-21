using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeatControl : MonoBehaviour
{
    public GameObject[] seats;
    int status;

    // Start is called before the first frame update
    void Start()
    {
        status = 0; //0为没有人，1为有其他人，2为有玩家
    }

    void OnTriggerStay(Collider other)
    {
        if(status == 0 && other.tag == "Player" )
        {
            seats[2].SetActive(true);
            seats[1].SetActive(false);
            seats[0].SetActive(false);
            status = 2;
        }
        if(status == 0 && other.tag == "Human")
        {
            seats[1].SetActive(true);
            seats[0].SetActive(false);
            seats[2].SetActive(false);
            status = 1;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(status == 1 && other.tag == "Human")
        {
            seats[0].SetActive(true);
            seats[1].SetActive(false);
            seats[2].SetActive(false);
            status = 0;
        }
        if(status == 2 && other.tag == "Player")
        {
            seats[0].SetActive(true);
            seats[1].SetActive(false);
            seats[2].SetActive(false);
            status = 0;
        }
        
    }

}
