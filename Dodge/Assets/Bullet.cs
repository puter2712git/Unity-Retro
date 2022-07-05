using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
	public float speed = 8f; // 탄알 이동 속력
	private Rigidbody bulletRigidbody; // 이동에 사용할 리지드바디 컴포넌트

  void Start() {
		bulletRigidbody = GetComponent<Rigidbody>();
		bulletRigidbody.velocity = transform.forward * speed;

		// 3초 뒤에 자신의 게임 오브젝트 파괴
		Destroy(gameObject, 3f);
	}

  void Update() {
  
	}
}
