using UnityEngine;
using System.Collections.Generic;
using System.Xml;
using System.Linq;

public class RecordMoving : MonoBehaviour
{
	// txtObject의 움직임 정보가 저장될 리스트
	//public List<TxtObjectMovement> lstObjectMovement;
	// txtObjectd의 순간 움직임이 저장될 구조체
	public TxtObjectMovement tempObjectMovement;

	bool recording;
	
	int sequenceCnt = 0;

	void Awake()
	{
		//lstObjectMovement = new List<TxtObjectMovement>();
		tempObjectMovement = new TxtObjectMovement();

		recording = false;
	}

	void FixedUpdate()
	{
		if (recording)
		{
			// 오브젝트 시쿼스 및 순간 위치 저장
			tempObjectMovement.sequence = sequenceCnt;
			tempObjectMovement.pos = Singleton.Instance.txtObject.transform.position;
			tempObjectMovement.rot = Singleton.Instance.txtObject.transform.rotation;

			// 리스트에 순간 위치 추가
			Singleton.Instance.lstObjectMovement.Add(tempObjectMovement);
			
			Debug.Log("시퀀스 : "+tempObjectMovement.sequence.ToString() + " / 위치 : " + tempObjectMovement.pos.ToString() + " / 각도 : "+tempObjectMovement.rot.ToString() + "list 개수 : " + Singleton.Instance.lstObjectMovement.Count.ToString());

			// sequence 증가
			sequenceCnt++;

			// 정지조건
			if (tempObjectMovement.pos.y > 400.0f)
			{
				StopRecording();
				Debug.Log("리스트에 저장 중지");
			}
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


	/// <summary>
	/// 기록된 List를 XML 파일로 저장
	/// </summary>
	void SaveListToXml()
	{

		Debug.Log(Singleton.Instance.lstObjectMovement.Count.ToString());

		// 움직임 기록 xml 파일
		XmlDocument xmlMovements = new XmlDocument();

		XmlElement lv1Main = xmlMovements.CreateElement("Main");
		xmlMovements.AppendChild(lv1Main);

		foreach (TxtObjectMovement src in Singleton.Instance.lstObjectMovement)
		{
			Debug.Log("foreach");
			XmlElement lv2Sequence = xmlMovements.CreateElement("Sequence");
			lv2Sequence.InnerText = src.sequence.ToString();
			lv1Main.AppendChild(lv2Sequence);

			XmlElement lv3Position = xmlMovements.CreateElement("Position");
			lv3Position.InnerText = src.pos.ToString();
			lv2Sequence.AppendChild(lv3Position);

			XmlElement lv3Rotation = xmlMovements.CreateElement("Rotation");
			lv3Rotation.InnerText = src.rot.ToString();
			lv2Sequence.AppendChild(lv3Rotation);
		}


		xmlMovements.Save("C:/Users/ysh/Desktop/xmlMovements.xml");        // XML 파일 저장
	}

}
