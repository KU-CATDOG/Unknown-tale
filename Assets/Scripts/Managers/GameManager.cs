﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager inst;

    private MapCode currentMap;     // 인게임에서 현재 위치(맵)
    public State currentState;

    void Awake()
    {
        if (GameManager.inst == null)
            GameManager.inst = this;

        ChangeLocation(MapCode.MAP1);
        ChangeState(State.Search);
    }

    /// <summary>
    /// 플레이어의 맵 이동
    /// </summary>
    public void ChangeLocation(MapCode nextLocation)
    {
        currentMap = nextLocation;

        Debug.Log("Change Map: " + currentMap);

        // 이후 지도 UI가 생기면 처음 접근했을때 활성화시키는 코드
        // 각 Map에 맞는 UI 생성 or destroy
    }

    public void ChangeState(State nextState)
    {
        currentState = nextState;

        Debug.Log("Change State: " + currentState);

        // 각 State에 맞는 UI or 동작제어 <- UI Manager function 호출
    }
}