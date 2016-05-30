using UnityEngine;
using System.Collections;

public class MoveObject : MonoBehaviour
{

	private bool moving = false;

	Vector3 pos;
	Quaternion rot;

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
		}

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
