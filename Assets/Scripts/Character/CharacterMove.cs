using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour, IMove
{
    private float speed;
    private IInput input;

    private void Start(){
        this.input = InputWindows.Instance;
        this.speed = 5f;
    }

    private void FixedUpdate(){
        Moving();
    }

    public void Moving(){
        Move();
    }
    private void Move(){

        if(input.GetInput() == DIRECTION.NONE){
            Debug.Log(DIRECTION.NONE);
        }
        else if(input.GetInput() == DIRECTION.LEFT){
            Debug.Log(DIRECTION.LEFT);
        }
        else if(input.GetInput() == DIRECTION.RIGHT){
            Debug.Log(DIRECTION.RIGHT);
        }
        else if(input.GetInput() == DIRECTION.JUMP){
            Debug.Log(DIRECTION.JUMP);
        }
    }
}
