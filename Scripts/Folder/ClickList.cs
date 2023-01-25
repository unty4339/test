
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ClickList : MonoBehaviour, IPointerDownHandler
{
	public void OnPointerDown(PointerEventData pointerData)
	{
		Debug.Log(gameObject.name + " がクリックされた!");
		Folders.instance.Check(gameObject);
	}
}