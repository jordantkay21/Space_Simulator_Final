using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField]
    private GameObject _firstPOV, _thirdPOV;

    [SerializeField]
    private GameObject _cockpit;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_firstPOV.activeSelf == true)
            {
                _firstPOV.SetActive(false);
            }
            else
            {
                _firstPOV.SetActive(true);
            }
        }

        if (_firstPOV.activeSelf == false)
        {
            _cockpit.SetActive(false);
        }
        else if (_firstPOV.activeSelf == true)
        {
            _cockpit.SetActive(true);
        }


    }
}
