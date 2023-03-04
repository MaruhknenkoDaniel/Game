using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

[System.Serializable]

public class PlayerData
{
    public int Level;
    public int Hp;
    public float[] position;
    public PlayerData(PlayerSave player)
    {
        Level = player.Level;
        Hp = player.Hp;
        position = new float[2];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z;


    }
        
    
}

