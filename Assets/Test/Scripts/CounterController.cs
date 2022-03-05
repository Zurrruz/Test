using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterController : MonoBehaviour
{
    private float _count = 0;

    public delegate void AddCount(float count);
    public static event AddCount addCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        _count++;
        addCount(_count);
    }
}
