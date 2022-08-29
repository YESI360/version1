using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotacion : MonoBehaviour
{
	[SerializeField]
	[Range(-10.0f, 10.0f)]
	public float velocidadAngular;
    void Start()
    {
        velocidadAngular = 0 ;
    }

        void Update()
	{
		transform.Rotate(0, velocidadAngular, 0);
	}
}