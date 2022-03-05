using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    [SerializeField]
    private GameObject _reloadGameButton;

    void Start()
    {
        _reloadGameButton.SetActive(false);
        CounterController.addCount += ReloadGameButton; 
    }
    private void OnDestroy()
    {
        CounterController.addCount -= ReloadGameButton;
    }

    private void ReloadGameButton(float count)
    {
        if(count >= 5)
            _reloadGameButton.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

}
