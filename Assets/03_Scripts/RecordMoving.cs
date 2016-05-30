using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class RecordMoving : MonoBehaviour
{
	// txtObject의 움직임 정보가 저장될 리스트
	public List<TxtObjectMovement> lstObjectMovement;
	// txtObjectd의 순간 움직임이 저장될 구조체
	public TxtObjectMovement tempObjectMovement;

	bool recording;
	
	void Awake()
	{

	
		lstObjectMovement = new List<TxtObjectMovement>();
		tempObjectMovement = new TxtObjectMovement();

		recording = false;
	}

	void Update()
	{
		if (recording)
		{
			tempObjectMovement.pos = Singleton.Instance.txtObject.transform.position;

			lstObjectMovement.Add(tempObjectMovement);

			Debug.Log(tempObjectMovement.pos.ToString());


		}
	}

	void StartRecording()
	{
		recording = true;
	}

	void StopRecording()
	{
		recording = false;
	}


}
