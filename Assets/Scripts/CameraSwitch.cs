using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraSwitch : MonoBehaviour
{
    [SerializeField]
    private GameObject _firstPOV, _thirdPOV, _cinamaticShots;

    [SerializeField]
    private GameObject _cockpit;

    float IdleTimer = 0;

    private bool _hasMouseMoved;




    void Update()
    {
        SwitchCamera();
        CockpitActivation();

        ActivateCutScene();
        DeactivateCutScene();

        CheckMouseMovement();



    }

    void CheckMouseMovement()
    {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        if(mouseX == 0f && mouseY == 0f)
        {
            _hasMouseMoved = false;
        }
        else
        {
            _hasMouseMoved = true;
        }
    }

    void SwitchCamera()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (_thirdPOV.activeSelf == true)
            {
                _thirdPOV.SetActive(false);
            }
            else
            {
                _thirdPOV.SetActive(true);
            }
        }
    }

    void CockpitActivation()
    {
        if (_thirdPOV.activeSelf == true || _cinamaticShots.activeSelf == true)
        {
            _cockpit.SetActive(false);
        }
        else if (_thirdPOV.activeSelf == false)
        {
            _cockpit.SetActive(true);
        }
    }

    void ActivateCutScene()
    {
        if (!Input.anyKey)
        {
            IdleTimer += Time.deltaTime;
        }

        if (IdleTimer >= 5 && _hasMouseMoved == false)
        {
            _cinamaticShots.SetActive(true);
        }
    }

    void DeactivateCutScene()
    {
        if (Input.anyKey || _hasMouseMoved == true)
        {
            _cinamaticShots.SetActive(false);
            IdleTimer = 0;
        }
    }
}
