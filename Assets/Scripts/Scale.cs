using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private float _scaleSpeed;

    private Vector3 newScale = Vector3.one;

    private void Update()
    {
        transform.localScale += newScale * _scaleSpeed * Time.deltaTime;
    }
}
