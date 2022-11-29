using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipControls : MonoBehaviour
{

    [SerializeField]
    private float _moveSpeed, _currentSpeed;

    [SerializeField]
    private GameObject _shipModel;

    private float _vertical;
    private float _horizontal;

    // Start is called before the first frame update
    void Start()
    {
        _currentSpeed = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        ShipSpeed();
        ShipMovement();
    }

    private void ShipSpeed()
    {
        //Increase Speed
        if (Input.GetKeyDown(KeyCode.T))
        {
            _currentSpeed++;
            if (_currentSpeed > 10)
            {
                _currentSpeed = 10;
            }
        }

        //Decrease Speed
        if (Input.GetKeyDown(KeyCode.G))
        {
            _currentSpeed--;
            if (_currentSpeed < 1)
            {
                _currentSpeed = 1;
            }
        }

        transform.position += transform.forward * _currentSpeed * Time.deltaTime;
    }

    private void ShipMovement()
    {
        Vector3 rotateH = new Vector3(0, _horizontal, 0);
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _horizontal++;
        }
    }
}
