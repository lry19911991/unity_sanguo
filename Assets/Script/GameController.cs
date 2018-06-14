using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class GameController : MonoBehaviour {
	
       public GameObject prefabBig;   //预制件
	 
	   public Transform originPos1;   //第一张卡片 初始化的位置


	public Transform originPos2;   //第一行 第二列张卡片 初始化的位置


	public Transform originPos3;   //第二行 第一列张卡片 初始化的位置

	   private int rangeRadomNum = 0;  //随机数

	   public Transform HintParent;//背景 transrom

	   private static List<GameObject> cards = new List<GameObject>();//15张 卡片

	   private static List<GameObject> newCards= new List<GameObject>();//15张 卡片


	public GameObject win_1;//背景 transrom



	void Awake()
	{

	}

	//开始抽奖
	public void OnStartTermClick()
	{
		//抽奖
		Debug.Log( "开启 协程 开始抽奖");
		StartCoroutine(Lottery());
	}

	IEnumerator Lottery()
	{

		win_1.SetActive (false);

		Debug.Log( "开始抽奖");

		newCards=new List<GameObject>(cards);
		int seconds = 0;
		while (seconds<=60)
		{
			for (float timer = 0; timer < 0.02; timer += Time.deltaTime)
				 yield return 0;
			     seconds++;

				foreach (var gameObj in newCards) {
					rangeRadomNum = Random.Range(1, 9);  
					gameObj.GetComponent<Card>().InitImage(rangeRadomNum+"");
				}

				//8毫秒的时候 第一列停止切换
				if (seconds == 20) {
					newCards.RemoveAt (0);
					newCards.RemoveAt (4);
					newCards.RemoveAt (8);
				}

				//12毫秒的时候 第二列停止切换
				if (seconds == 30) {
					newCards.RemoveAt (0);
					newCards.RemoveAt (3);
					newCards.RemoveAt (6);
				}

			     //16毫秒的时候 第三列停止切换
				if (seconds == 40) {
					newCards.RemoveAt (0);
					newCards.RemoveAt (2);
					newCards.RemoveAt (4);
				}
			     //20毫秒的时候 第四列停止切换
				if (seconds == 50) {
					newCards.RemoveAt (0);
					newCards.RemoveAt (1);
					newCards.RemoveAt (2);
				}

			Debug.Log(seconds + " seconds have passed since the Coroutine started.");
		}

		win_1.SetActive (true);
		win_1.transform.SetAsLastSibling();  

		//停止协程
		yield return null;
	}





	// Use this for initialization  初始化 15张动态的卡牌
	void Start () {
		print (originPos1.position);
//		print (originPos1.GetComponent<RectTransform>().position.x);
		print (originPos2.position);
		print (originPos3.position);


		print (originPos2.position.x-originPos1.position.x);

		print (originPos3.position.y-originPos1.position.y);

		// 建立一个3*5 的 数组 

		for (int row = 0; row < 3; row++)
		{
		   for (int index = 0; index < 5; index++)
		   {



//				GameObject itemclone = Instantiate(prefabBig,originPos1.position,Quaternion.identity, transform) as GameObject;
				GameObject itemclone = Instantiate(prefabBig,new Vector3 (originPos1.position.x+index*(originPos2.position.x-originPos1.position.x), originPos1.position.y+row*(originPos3.position.y-originPos1.position.y), originPos1.position.z),Quaternion.identity, transform) as GameObject;
//				GameObject itemclone=Instantiate(prefabBig) as GameObject;
				itemclone.GetComponent<RectTransform> ().sizeDelta = new Vector2(80.41f, 37.83f);
				itemclone.transform.parent = HintParent.transform;

//				itemclone.transform.localScale = Vector3.one;
//				itemclone.transform.localScale=new Vector3(1f,1f,1f);
//				itemclone.transform.position=new Vector3(originPos1.position.x+index*(originPos2.position.x-originPos1.position.x), originPos1.position.y-row*(originPos3.position.y-originPos1.position.y), originPos1.position.z);

				rangeRadomNum = Random.Range(1, 9);  
			    itemclone.GetComponent<Card>().InitImage(rangeRadomNum+"");
			    itemclone.transform.SetAsLastSibling();
				//把卡片放入 集合中
				cards.Add (itemclone);
				print (cards.Count);
		    } 	
	   }
	}
	
	// Update is called once per frame
	void Update () {


	}
}
