using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateUIPosition : MonoBehaviour
{
    private Camera _mainCamera;
    [SerializeField] private RectTransform playerUI;
    [SerializeField] private RectTransform enemyUI;

    private GameObject playerObject;
    private GameObject enemyObject;

    private void Awake()
    {
        playerObject = GameObject.Find("Player");
        enemyObject = GameObject.Find("Enemy");
        _mainCamera = Camera.main;

        playerUI.transform.position = playerObject.transform.position;
        enemyUI.transform.position = enemyObject.transform.position;
    }
}
