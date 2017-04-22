using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	public int numA ;
	public int numB ;

	int sumThis(int sumNA, int sumNB){
		int result = sumNA + sumNB;
		return result;
	}

	// Use this for initialization
	void Start () {
		int sumCnt = sumThis (numA,numB);
		print (sumCnt);
	}
		
}
