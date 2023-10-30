using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GridDebugObject : MonoBehaviour
{
    [SerializeField] private TMP_Text gridText;
    private GridObject gridObject;
    public void SetGridObject(GridObject gridObject)
    {
        this.gridObject = gridObject;
    }
    

    private void Start()
    {
        gridText.text = gridObject.ToString();
    }
}
