using UnityEngine;
using System.Collections;

public class JoystickEventHandler : MonoBehaviour {
	[SerializeField]
	private Animator animator;
	[SerializeField]
	private ThirdPersonCamera gamecam;

	void Start(){

	}

	void OnEnable(){
		EasyJoystick.On_JoystickMove += On_JoystickMove;
		EasyJoystick.On_JoystickMoveEnd += On_JoystickMoveEnd;
	}
	
	void OnDisable(){
		EasyJoystick.On_JoystickMove -= On_JoystickMove	;
		EasyJoystick.On_JoystickMoveEnd -= On_JoystickMoveEnd;
	}
	
	void OnDestroy(){
		EasyJoystick.On_JoystickMove -= On_JoystickMove;	
		EasyJoystick.On_JoystickMoveEnd -= On_JoystickMoveEnd;
	}

	void On_JoystickMoveEnd(MovingJoystick move){
		Debug.Log("MoveEnd");
	}

	void On_JoystickMove(MovingJoystick move){
		Debug.Log("MoveStart");
		float y = move.joystickAxis.y;
		float x = move.joystickAxis.x;
		Debug.Log ("x = " + x + " / " + "y = " + y);
	}
}
