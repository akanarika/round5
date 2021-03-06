﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class InputController : Singleton<InputController> {

    private Dictionary<KeyCode, Utility.Pair<int, int>> _keyMap;

    private Player[] _playerList;

    void Awake()
    {
        _playerList = new Player[4];
        _keyMap = new Dictionary<KeyCode, Utility.Pair<int, int>>();
    }

    public void registerPlayer(Player player)
    {
        _playerList[player.index] = player;
    }

    public void registerPlayerControls(int playerIndex, KeyCode[] keys)
    {
        for (int i = 0; i < keys.Length; i++)
        {
            _keyMap.Add(keys[i], new Utility.Pair<int, int>(playerIndex, i));
        }
    }

    // Use this for initialization
    void Start()
    {
	
	}
	
	// Update is called once per frame
	void Update () {
        Utility.Pair<int, int> triggerKey = new Utility.Pair<int, int> (-1, -1);

        if (Input.GetKeyDown("q") && _keyMap.ContainsKey(KeyCode.Q))
        {
            triggerKey = _keyMap[KeyCode.Q];
        }
        else if (Input.GetKeyDown("w") && _keyMap.ContainsKey(KeyCode.W))
        {
            triggerKey = _keyMap[KeyCode.W];
        }
        else if (Input.GetKeyDown("e") && _keyMap.ContainsKey(KeyCode.E))
        {
            triggerKey = _keyMap[KeyCode.E];
        }
        else if (Input.GetKeyDown("r") && _keyMap.ContainsKey(KeyCode.R))
        {
            triggerKey = _keyMap[KeyCode.R];
        }
        else if (Input.GetKeyDown("t") && _keyMap.ContainsKey(KeyCode.T))
        {
            triggerKey = _keyMap[KeyCode.T];
        }
        else if (Input.GetKeyDown("y") && _keyMap.ContainsKey(KeyCode.Y))
        {
            triggerKey = _keyMap[KeyCode.Y];
        }
        else if (Input.GetKeyDown("a") && _keyMap.ContainsKey(KeyCode.A))
        {
            triggerKey = _keyMap[KeyCode.A];
        }
        else if (Input.GetKeyDown("s") && _keyMap.ContainsKey(KeyCode.S))
        {
            triggerKey = _keyMap[KeyCode.S];
        }
        else if (Input.GetKeyDown("d") && _keyMap.ContainsKey(KeyCode.D))
        {
            triggerKey = _keyMap[KeyCode.D];
        }
        else if (Input.GetKeyDown("f") && _keyMap.ContainsKey(KeyCode.F))
        {
            triggerKey = _keyMap[KeyCode.F];
        }
        else if (Input.GetKeyDown("g") && _keyMap.ContainsKey(KeyCode.G))
        {
            triggerKey = _keyMap[KeyCode.G];
        }
        else if (Input.GetKeyDown("h") && _keyMap.ContainsKey(KeyCode.H))
        {
            triggerKey = _keyMap[KeyCode.H];
        }
        else if (Input.GetKeyDown("z") && _keyMap.ContainsKey(KeyCode.Z))
        {
            triggerKey = _keyMap[KeyCode.Z];
        }
        else if (Input.GetKeyDown("x") && _keyMap.ContainsKey(KeyCode.X))
        {
            triggerKey = _keyMap[KeyCode.X];
        }
        else if (Input.GetKeyDown("c") && _keyMap.ContainsKey(KeyCode.C))
        {
            triggerKey = _keyMap[KeyCode.C];
        }
        else if (Input.GetKeyDown("v") && _keyMap.ContainsKey(KeyCode.V))
        {
            triggerKey = _keyMap[KeyCode.V];
        }
        else if (Input.GetKeyDown("b") && _keyMap.ContainsKey(KeyCode.B))
        {
            triggerKey = _keyMap[KeyCode.B];
        }
        else if (Input.GetKeyDown("n") && _keyMap.ContainsKey(KeyCode.N))
        {
            triggerKey = _keyMap[KeyCode.N];
        }
        else if (Input.GetKeyDown("i") && _keyMap.ContainsKey(KeyCode.I))
        {
            triggerKey = _keyMap[KeyCode.I];
        }
        else if (Input.GetKeyDown("o") && _keyMap.ContainsKey(KeyCode.O))
        {
            triggerKey = _keyMap[KeyCode.O];
        }
        else if (Input.GetKeyDown("p") && _keyMap.ContainsKey(KeyCode.P))
        {
            triggerKey = _keyMap[KeyCode.P];
        }
        else if (Input.GetKeyDown("j") && _keyMap.ContainsKey(KeyCode.J))
        {
            triggerKey = _keyMap[KeyCode.J];
        }
        else if (Input.GetKeyDown("k") && _keyMap.ContainsKey(KeyCode.K))
        {
            triggerKey = _keyMap[KeyCode.K];
        }
        else if (Input.GetKeyDown("l") && _keyMap.ContainsKey(KeyCode.L))
        {
            triggerKey = _keyMap[KeyCode.L];
        }
        else if (Input.GetKeyDown("down") && _keyMap.ContainsKey(KeyCode.DownArrow))
        {
            triggerKey = _keyMap[KeyCode.DownArrow];
        }
        else if (Input.GetKeyDown("up") && _keyMap.ContainsKey(KeyCode.UpArrow))
        {
            triggerKey = _keyMap[KeyCode.UpArrow];
        }
        else if (Input.GetKeyDown("left") && _keyMap.ContainsKey(KeyCode.LeftArrow))        
        {
            triggerKey = _keyMap[KeyCode.LeftArrow];
        }
        else if (Input.GetKeyDown("right") && _keyMap.ContainsKey(KeyCode.RightArrow))
        {
            triggerKey = _keyMap[KeyCode.RightArrow];
        }
        else if (Input.GetMouseButtonDown(1) && _keyMap.ContainsKey(KeyCode.Mouse1))
        {
            triggerKey = _keyMap[KeyCode.Mouse1];
        }
        else if (Input.GetMouseButtonDown(0) && _keyMap.ContainsKey(KeyCode.Mouse0))
        {
            triggerKey = _keyMap[KeyCode.Mouse0];
        }

        if (triggerKey != null && triggerKey.first >= 0)
        {
            _playerList[triggerKey.first].trigger(triggerKey.second);
        }
	}

    public KeyCode parseString(string key)
    {
        switch (key)
        {
            case "Q":
            case "q":
                return KeyCode.Q;
            case "W":
            case "w":
                return KeyCode.W;
            case "E":
            case "e":
                return KeyCode.E;
            case "R":
            case "r":
                return KeyCode.R;
            case "T":
            case "t":
                return KeyCode.T;
            case "Y":
            case "y":
                return KeyCode.Y;
            case "A":
            case "a":
                return KeyCode.A;
            case "S":
            case "s":
                return KeyCode.S;
            case "D":
            case "d":
                return KeyCode.D;
            case "F":
            case "f":
                return KeyCode.F;
            case "G":
            case "g":
                return KeyCode.G;
            case "H":
            case "h":
                return KeyCode.H;
            case "Z":
            case "z":
                return KeyCode.Z;
            case "X":
            case "x":
                return KeyCode.X;
            case "C":
            case "c":
                return KeyCode.C;
            case "V":
            case "v":
                return KeyCode.V;
            case "B":
            case "b":
                return KeyCode.B;
            case "N":
            case "n":
                return KeyCode.N;
            case "I":
            case "i":
                return KeyCode.I;
            case "O":
            case "o":
                return KeyCode.O;
            case "P":
            case "p":
                return KeyCode.P;
            case "J":
            case "j":
                return KeyCode.J;
            case "K":
            case "k":
                return KeyCode.K;
            case "L":
            case "l":
                return KeyCode.L;
            case "DOWN":
            case "Down":
            case "down":
                return KeyCode.DownArrow;
            case "UP":
            case "Up":
            case "up":
                return KeyCode.UpArrow;
            case "LEFT":
            case "Left":
            case "left":
                return KeyCode.LeftArrow;
            case "RIGHT":
            case "Right":
            case "right":
                return KeyCode.RightArrow;
            case "MOUSE RIGHT":
            case "Mouse Right":
            case "mouse right":
                return KeyCode.Mouse1;
            case "MOUSE LEFT":
            case "Mouse Left":
            case "mouse left":
                return KeyCode.Mouse0;
            default:
                return KeyCode.Q;
        }
    }
}
