using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BacktoLoading : MonoBehaviour
{
    [SerializeField] private Button _problem10;
   

    private void Start()
    {
        _problem10.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            
            SceneManager.LoadScene(0);
        });

     

        // Button didisable agar mencegah tidak terjadinya spam klik ketika
        // proses onclick pada button sedang berjalan
    }

    // Mendisable button agar tidak bisa ditekan
    private void SetButtonInteractable(bool interactable)
    {
        _problem10.interactable = interactable;
      
    }
}
