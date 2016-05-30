using UnityEngine;
using System.Collections;

public struct TxtObjectMovement
{
	public int sequence;
	public Vector3 pos;
	public Quaternion rot;

	//TxtObjectMovement(int _sequence = 0, Vector3 _pos = new Vector3(), Quaternion _rot = new Quaternion())
	//{
	//	sequence = _sequence;
	//	pos = _pos;
	//	rot = _rot;
	//}
}


//// 오브젝트 속성 저장 xml 파일
//XmlDocument xmlTxtInventory = new XmlDocument();

//XmlElement txtObject = xmlTxtInventory.CreateElement("Object");
//xmlTxtInventory.AppendChild(txtObject);

//		XmlElement position = xmlTxtInventory.CreateElement("Position");
//txtObject.AppendChild(position);


//		foreach (Inventory ivt in lstInventory)
//		{
//			XmlElement posX = xmlTxtInventory.CreateElement("x");
//posX.InnerText = ivt.value.ToString();
//			position.AppendChild(posX);
//		}

//		xmlTxtInventory.Save("C:/Users/ysh/Desktop/xmlTxtInventory.xml");        // XML 파일 저장