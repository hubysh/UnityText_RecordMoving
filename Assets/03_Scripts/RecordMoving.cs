using UnityEngine;
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

	void FixedUpdate()
	{
		int cnt = 0;
		if (recording)
		{
			// 오브젝트 시쿼스 및 순간 위치 저장
			tempObjectMovement.sequence = cnt;
			tempObjectMovement.pos = Singleton.Instance.txtObject.transform.position;
			tempObjectMovement.rot = Singleton.Instance.txtObject.transform.rotation;

			// 리스트에 순간 위치 추가
			lstObjectMovement.Add(tempObjectMovement);
			

			Debug.Log(tempObjectMovement.pos.ToString());
			Debug.Log(lstObjectMovement.Count.ToString());

			// sequence 증가
			cnt++;
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

	void SaveList()
	{

	}


}
