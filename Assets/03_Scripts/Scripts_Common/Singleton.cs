using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

/// <summary>
/// 전역에서 접근 가능한 클래스
/// MonoBehaviour을 상속한 이유는 Inspetor에서 정보를 실시간으로 보기 위함
/// 상속 없을 경우, 객체 핸들 얻지 못함.
/// </summary>
public class Singleton : MonoBehaviour
{
	private static Singleton instance = null;

	public GameObject txtResult;

	public static Singleton Instance
	{
		get
		{
			if (instance == null)
			{
				GameObject objSingleton = new GameObject("objSingleton");
				instance = objSingleton.AddComponent(typeof(Singleton)) as Singleton;
			}
			return instance;
		}
	}

	void Awake()
	{
		txtResult = GameObject.Find("txtResult");
	}

}