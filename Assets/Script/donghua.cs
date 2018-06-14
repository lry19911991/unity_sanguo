using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class donghua : MonoBehaviour {
	private UISprite card_1;
	public Sprite[] Sprites;  
	public float speed;  

	// Use this for initialization
	void Start () {
		card_1 = GetComponent<UISprite>();  

	}
	
	// Update is called once per frame
	void Update () {
		int index = (int)(Time.time * speed) % Sprites.Length;  
		card_1.spriteName = Sprites[index].name;  
	}
}
