using UnityEngine;
using System.Collections;

public class RecordMoving : MonoBehaviour
{

	private bool moving = false;

	//Vector3 pos = new Vector3();

	void Update()
	{
		if (moving)
		{
			Vector3 pos = Singleton.Instance.txtObject.transform.position;
			pos.x += Time.deltaTime * 100f;
			pos.y += Time.deltaTime * 100f;
			Singleton.Instance.txtObject.transform.position = pos;

			//pos.x += Time.deltaTime * 1f;
			//pos = Singleton.Instance.txtObject.transform.position;
			//Singleton.Instance.transform.position = pos;

			//pos = Singleton.Instance.txtObject.transform.position;

			Debug.Log(/*Singleton.Instance.transform.position*/pos.ToString());
		}

		// 2초 후 변화 멈춤
		Invoke("StopMoving", 3);
	}

	void StopMoving()
	{
		moving = false;
	}

	void StartMoving()
	{
		
		moving = true;
	}

}
