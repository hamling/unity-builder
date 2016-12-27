using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Canvas : MonoBehaviour, IBeginDragHandler, IDragHandler, IPointerDownHandler, IPointerClickHandler, IPointerUpHandler {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnBeginDrag(PointerEventData eventData)
	{
		Debug.Log("Begin: " + gameObject.name);
	}

	public void OnDrag(PointerEventData data)
	{
		Debug.Log("OnDrag: " + gameObject.name);
	}

	public void OnPointerDown(PointerEventData data)
	{
		Debug.Log("Down: " + gameObject.name);
	}

	public void OnPointerUp(PointerEventData data)
	{
		Debug.Log("Up: " + gameObject.name);
	}

	public void OnPointerClick(PointerEventData data)
	{
		Debug.Log("Click: " + gameObject.name);
	}
}
