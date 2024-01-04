using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputWindows : MonoBehaviour, IInput
{
    private static InputWindows instance;
    public static InputWindows Instance {get => instance; }

    private DIRECTION _deriction;

    private void Awake(){
        if(instance) Debug.LogError("Ton tai 1 InputWindows");
        instance = this;
    }
    private void Start(){
        _deriction = DIRECTION.NONE;
    }

    private void Update(){
        SetInput();
    }

    private void SetInput(){
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            _deriction = DIRECTION.LEFT;
        }
        else if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            _deriction = DIRECTION.RIGHT;
        }
        else if(Input.GetKeyDown(KeyCode.Space))
        {
            _deriction = DIRECTION.JUMP;
        }
        else
        {
        _deriction = DIRECTION.NONE;
        }
    }

    public DIRECTION GetInput(){
        return _deriction;
    }
}