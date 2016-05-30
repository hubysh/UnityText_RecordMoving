using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour
{

	public bool moving;

	Vector3 pos;
	Quaternion rot;

	void Awake()
	{
		moving = false;

		pos = new Vector3();
		rot = new Quaternion();

	}

	void Update()
	{
		if (moving)
		{
			pos = Singleton.Instance.txtObject.transform.position;
			rot = Singleton.Instance.txtObject.transform.rotation;

			pos.x += Time.deltaTime * 100f;
			pos.y += Time.deltaTime * 100f;
			Singleton.Instance.txtObject.transform.position = pos;

			rot.y += Time.deltaTime * 1f;
			Singleton.Instance.txtObject.transform.rotation = rot;
			Debug.Log("MoveObject");
		}

		if(Singleton.Instance.txtObject.transform.position.y > 400.0f)
		{
			StopMoving();
		}

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
