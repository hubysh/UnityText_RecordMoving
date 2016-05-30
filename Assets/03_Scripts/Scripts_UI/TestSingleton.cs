using UnityEngine;
using System.Collections;

public class TestSingleton : MonoBehaviour
{
	bool isActive = true;

	void TestSingletonScript()
	{
		if (isActive)
		{
			Singleton.Instance.txtResult.SetActive(isActive);
			isActive = false;
		}
		else
		{
			Singleton.Instance.txtResult.SetActive(isActive);
			isActive = true;
		}
		
	}
}
