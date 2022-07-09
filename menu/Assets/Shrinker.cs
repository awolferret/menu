using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof (Transform))]

public class Shrinker : MonoBehaviour
{
    private Transform _transform;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    public void OnButtonClick()
    {
        _transform.localScale = new Vector2(0.95f,0.95f);
    }

    public void OnButtonUp()
    {
        _transform.localScale = new Vector2(1, 1);
        Debug.Log("refe");
    }
}