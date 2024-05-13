using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]

public class GameData
{   
    private static GameData _current;
    public static GameData current{
        get{
            if(_current == null){
                _current = new GameData();
            }
            return _current;
        }
    }

    
}
