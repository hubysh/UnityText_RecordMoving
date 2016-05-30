using UnityEngine;
using System.Collections.Generic;
using System.Xml;

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
			
			Debug.Log("시퀀스 : "+tempObjectMovement.sequence.ToString() + " / 위치 : " + tempObjectMovement.pos.ToString() + " / 각도 : "+tempObjectMovement.rot.ToString());

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

	void SaveListToXml()
	{
		// 움직임 기록 xml 파일
		XmlDocument xmlMovements = new XmlDocument();

		XmlElement lv1Main = xmlMovements.CreateElement("Main");
		xmlMovements.AppendChild(lv1Main);

		XmlElement lv2Sequence= xmlMovements.CreateElement("Sequence");
		lv1Main.AppendChild(lv2Sequence);
		XmlElement lv2Position = xmlMovements.CreateElement("Position");
		lv1Main.AppendChild(lv2Position);
		XmlElement v2Rotation = xmlMovements.CreateElement("Rotation");
		lv1Main.AppendChild(v2Rotation);

		xmlMovements.Save("C:/Users/ysh/Desktop/xmlMovements.xml");        // XML 파일 저장

	}


}
