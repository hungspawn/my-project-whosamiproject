using UnityEngine;
using System.Collections;
using UnityEngineInternal;
using UnityEditor;
using UnityEditorInternal;
using TreeEditor;
using System;



public class Main : MonoBehaviour {

	public int scoreGame = 0;
	private Boolean nextLevel = false ;
	private GameObject backGround;
	void Start () {

		backGround = GameObject.Find("Background");
	}

	void OnGUI () {


	}

	public void OnClick (int score)
	{
		if(!nextLevel)
		{
			if(!nextLevel)
			scoreGame += score;

			nextLevel = true;
			Hashtable ht = new Hashtable();
			ht.Add("x", 0);
			ht.Add("time", 2);
			ht.Add("oncomplete","onCompleteScale");
		
	
		
				//GetComponent<TweenScale>().AddOnFinished(onScaleFinished);
			if(nextLevel==true)
			{
				//iTween.moveTo(backGround, {"time": 2, "x":-25.38265, "z":16.37207, "y":20, "oncomplete":"onCompleteScale"});
				iTween.ScaleTo(backGround, iTween.Hash("x",0, "time", 2));
				//iTween.ScaleTo(backGround,iTween.Hash("x",new Vector2(1,1),"to",new Vector2(2,2),"oncomplete","ScaleButton","time",.2));
				//iTween.ScaleTo(backGround,onCompleteScale);
				//iTween.ScaleTo(backGround,ht);
				//iTween.ScaleTo(backGround, iTween.Hash("x":1 "onComplete", "oncomplete","ScaleButton","time",2));
			}
		}
	}

	public  void onCompleteScale()
	{
		iTween.ScaleTo(backGround, iTween.Hash("x",1, "oncomplete", "onCompleteScaleBack", "time", 2));
	}

	public  void onCompleteScaleBack()
	{
			
	}
	
	void Update(){
		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit(); 

		if (backGround.transform.localScale == (new Vector3(0f,1f,1f))) 
		{
			nextLevel = false;

			iTween.ScaleTo(backGround, iTween.Hash("x",1, "time", 2));
		}
	
	}
}
