using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class LuckWheelManager: MonoBehaviour{
	/*stuffset*/
	private bool _beStarted;
	private float[] _angleSector;
	private float _angleFinal;
	private float _angleBegin;
	
	private float _lerpRotateTimeNow;
	/*message_how much*/
	public int PressCost = 250; //pay how much on playing
	public int MoneyPrevTotal;
	public int MoneyNowTotal = 1000;
	/*ui_basuc*/
	public Button buttonPress;
	public GameObject circleWheel;
	/*message_win or lose*/
	public Text MoneyDeltaText;
	public Text MoneyNowText;
	/*action*/
	private void Awake(){
		
	}
	
	public void SpinWheel(){
	
	}
	
	void RewardByAngle(){
	
	}
	
	void Update(){}
}