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
		MoneyPrevTotal = MoneyNowTotal;
		MoneyNowText.text = MoneyNowTotal.ToString();
	}
	
	public void SpinWheel(){
		if(MoneyNowTotal >= PressCost){
			_lerpRotateTimeNow = 0f;
			
			_angleSector =  new float[]{
				30, 60, 90, 120, 150, 180, 210, 240, 270, 300, 330, 360
			};
			int circleFull = 5;
			float randomAngleFinal = _angleSector [UnityEngine.Random.Range(0, _angleSector.Length)];
			/*angle would rotate*/
			_angleFinal = -(circleFull * 360 + randomAngleFinal);
			_beStarted = true;
			
			MoneyPrevTotal = MoneyNowTotal;
			/*Whenever I play, my wallet fades*/
			MoneyNowTotal = -PressCost;
			/*Addict to it?!*/
			MoneyDeltaText.text = PressCost + "bye!";
			MoneyDeltaText.gameObject.SetActive(true);
			
			StartCoroutine(MoneyDeltaHide());
			StartCoroutine(MoneyTotalUpdate());
		}
	}
	
	/*void RewardByAngle(){
		switch(_angleBegin){}
	}*/
	
	void Update(){
	
		/*The Poor is banned*/
		if(_beStarted || MoneyNowTotal < PressCost){
			buttonPress.interactable = false;
			/*buttonPress.GetComponent<Image>.color = new Color();*/
		}else{
			buttonPress.interactable = true;
			/*buttonPress.GetComponent<Image>.color = new Color();*/
		}
		
		if(!_beStarted){
			return;
			
		float LerpRotateTimeMax = 4f;
		
		/*calculate increment time once per frame*/	
		_lerpRotateTimeNow += Time.deltaTime;
		if(_lerpRotateTimeNow > LerpRotateTimeMax || circleWheel.transform.EulerAngles.z == _angleFinal){
			_lerpRotateTimeNow = LerpRotateTimeMax;
			_beStarted = false;
			_angleBegin = _angleFinal % 360;
			
			AwardByAngle();
			StartCoroutine(MoneyDeltaHide());
		}
			
		/**/
		}
		
	}
}
