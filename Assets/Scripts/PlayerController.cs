using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Called from StagStationManager to set the new Player Position
    public void SetPlayerPosition(Vector2 newPlayerPosition)
    {
        this.transform.position = newPlayerPosition;
    }
}
