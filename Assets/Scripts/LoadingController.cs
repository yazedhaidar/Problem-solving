﻿using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingController : MonoBehaviour
{
    [SerializeField] private Button _problem1;
    [SerializeField] private Button _problem2;
    [SerializeField] private Button _problem3;
    [SerializeField] private Button _problem4;
    [SerializeField] private Button _problem5;
    [SerializeField] private Button _problem6;
    [SerializeField] private Button _problem7;
    [SerializeField] private Button _problem8;
    [SerializeField] private Button _problem9;

    private void Start ()
    {
        _problem1.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            //UserDataManager.LoadFromLocal ();
            SceneManager.LoadScene (1);
        });

        _problem2.onClick.AddListener (() =>
        {
            SetButtonInteractable (false);
            SceneManager.LoadScene(2);
            //StartCoroutine (UserDataManager.LoadFromCloud (() => SceneManager.LoadScene (1)));
        });

        _problem3.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            SceneManager.LoadScene(3);
            
        });

        _problem4.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            SceneManager.LoadScene(4);

        });

        _problem5.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            SceneManager.LoadScene(5);

        });

        _problem6.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            SceneManager.LoadScene(6);

        });

        _problem7.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            SceneManager.LoadScene(7);

        });

        _problem8.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            SceneManager.LoadScene(8);

        });

        _problem9.onClick.AddListener(() =>
        {
            SetButtonInteractable(false);
            SceneManager.LoadScene(9);

        });

        // Button didisable agar mencegah tidak terjadinya spam klik ketika
        // proses onclick pada button sedang berjalan
    }

    // Mendisable button agar tidak bisa ditekan
    private void SetButtonInteractable (bool interactable)
    {
        _problem1.interactable = interactable;
        _problem2.interactable = interactable;
        _problem3.interactable = interactable;
        _problem4.interactable = interactable;
        _problem5.interactable = interactable;
        _problem6.interactable = interactable;
        _problem7.interactable = interactable;
        _problem8.interactable = interactable;
        _problem9.interactable = interactable;
    }
}