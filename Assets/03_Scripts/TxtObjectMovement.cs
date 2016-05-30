using UnityEngine;
using System.Collections;

public struct TxtObjectMovement
{
	public int sequence;
	public Vector3 pos;
	public Quaternion rot;

	TxtObjectMovement(int _sequence = 0, Vector3 _pos = new Vector3(), Quaternion _rot = new Quaternion())
	{
		sequence = _sequence;
		pos = _pos;
		rot = _rot;
	}

}
