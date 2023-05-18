using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public static Move move;

    [SerializeField]    private enum Control
    {
        mobil,
        pc
    }

    [SerializeField] private Control _controls;

    [SerializeField] private float _goForward;

    [SerializeField] private float _turnSpeed;

    [SerializeField] private float _limitX;

    [SerializeField] private float _currentSpeed;

    [SerializeField] private float _xSpeed;
    private void Awake()
    {
        if (move==null)
        {
            move = this;
        }
    }    
    void Update()
    {
        switch(_controls)
        {
            case Control.mobil://mobil kontrol için
                float newX = 0;
                float touchxDelta = 0;
                if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
                {
                    touchxDelta = Input.GetTouch(0).deltaPosition.x / Screen.width;
                }
                else if (Input.GetMouseButton(0))
                {
                    touchxDelta = Input.GetAxis("Mouse X");
                }
                newX = transform.position.x + _xSpeed * touchxDelta * Time.deltaTime;
                newX = Mathf.Clamp(newX, -_limitX, _limitX);
                Vector3 newPosition = new Vector3(newX, transform.position.y, transform.position.z + _currentSpeed * Time.deltaTime);
                transform.position = newPosition;
                break;

            case Control.pc://pc kontrol için
                float yatayeksen = Input.GetAxis("Horizontal") * _turnSpeed * Time.deltaTime;
                this.transform.Translate(yatayeksen, 0, _goForward * Time.deltaTime);
                break;
                
        }              
        
    }
}
