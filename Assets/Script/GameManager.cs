using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class GameManager : MonoBehaviour {

	private bool flag=false;

    public GameObject prefabBig;   //预制件

	private UISprite originPos1;

	private UISprite originPos2;

	private UISprite originPos3;

	private UISprite originPos4;


	private UISprite originPos5;

	private UISprite originPos6;

	// Use this for initialization
	void Start () {
		originPos1 = GameObject.Find ("origin_pos1").GetComponent<UISprite> ();
		originPos2 = GameObject.Find ("origin_pos2").GetComponent<UISprite> ();
		originPos3 = GameObject.Find ("origin_pos3").GetComponent<UISprite> ();
		originPos4 = GameObject.Find ("origin_pos4").GetComponent<UISprite> ();
     	originPos5 = GameObject.Find ("origin_pos5").GetComponent<UISprite> ();
		originPos6 = GameObject.Find ("origin_pos6").GetComponent<UISprite> ();


        for (int i = 0; i < 3; i++)
        {
        	 for (int j = 0; j < 5; j++){


            }
        }

	}
	
	// Update is called once per frame
	void Update () {

//		if (Input.GetKeyDown (KeyCode.A)) 
//		{
////
////			for (int i=1;i<=10;i++) {
////				print ("sssss");
//				if(card_1.spriteName.Equals("bg_10")){
//					card_1.spriteName = "bg_08";
//				}
//				else if(card_1.spriteName.Equals("bg_08")){
//					card_1.spriteName = "bg_11";
//				}else if(card_1.spriteName.Equals("bg_11")){
//					card_1.spriteName = "bg_12";
//				}
//				else if(card_1.spriteName.Equals("bg_11")){
//					card_1.spriteName = "bg_12";
//				}
//				else if(card_1.spriteName.Equals("bg_12")){
//					card_1.spriteName = "bg_14";
//				}
//				else if(card_1.spriteName.Equals("bg_14")){
//					card_1.spriteName = "bg_03";
//				}
//				else if(card_1.spriteName.Equals("bg_03")){
//					card_1.spriteName = "bg_04";
//				}
//				else if(card_1.spriteName.Equals("bg_04")){
//					card_1.spriteName = "bg_08";
//				}
//			
////				Thread.Sleep(1000);
//
////			}
//		
//		}


		
	}
}
