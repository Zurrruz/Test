using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountTextController : MonoBehaviour
{
    [SerializeField]
    private Text _contText;

    void Start()
    {
        CounterController.addCount += CountText;
    }
    private void OnDestroy()
    {
        CounterController.addCount -= CountText;
    }

    private void CountText(float count)
    {
        _contText.text = count.ToString();
    }    
}
