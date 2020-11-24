﻿using UnityEngine;
using UnityEngine.XR.ARFoundation; //引用foundation api
using System.Collections.Generic; //引用系統.集合.一般.包含清單 List


//點擊地面生成物件
//RC 要求元件在第一次套用腳本時執行
[RequireComponent(typeof(ARRaycastManager))]
public class ARManager : MonoBehaviour
{
    [Header("點擊後要生成的物件")]
    public GameObject obj;
    [Header("AR管理器")]
    public ARRaycastManager arManager;

    //滑鼠座標
    private Vector2 pointMouse;
    //碰撞資訊
    private List<ARRaycastHit> hit;

    //點擊
    private void Tap()
    {
        //判斷玩家是否點擊
        if (Input.GetKeyDown(KeyCode.Mouse0))
       {
            pointMouse = Input.mousePosition;//滑鼠座標=玩家滑鼠座標
            print(pointMouse);
        }
   //判斷射線是否打到物件
   //生成物件
    }
    private void Update()
    {
        Tap();
    }
}
