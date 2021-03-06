﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class labels : MonoBehaviour {
	public GameObject label;
	List<string> partList = new List<string>();

	public List<string> labelAll(){
		foreach(GameObject part in GameObject.FindGameObjectsWithTag("body")){
			GameObject temp = Instantiate(label);
			temp.transform.parent = part.transform;
			temp.transform.Find("text").GetComponent<TextMesh>().text = part.name;
			temp.transform.position = part.transform.position;
			temp.transform.rotation = new Quaternion(0f, 0f, 0f, 0f);
			temp.GetComponent<showLabel>().hide();
			partList.Add(part.name);
		}
		return partList;
	}
}
