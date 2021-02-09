using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StagStationsManager : MonoBehaviour
{
    public List<StagStation> stagStationsList;

    StagStationsUIManager stagStationsUIManager;

    void Awake()
    {
        stagStationsUIManager = FindObjectOfType<StagStationsUIManager>();
    }

    //Called from UI button or if in the game by hitting the bell
    public void RequestStagStationTravel()
    {
        //Pause Game
        stagStationsUIManager.ShowStagStationUI(stagStationsList);

    }

    //Called when a station name is pressed
    public void GoToStation(int stagStationIndex)
    {
        FindObjectOfType<PlayerController>().SetPlayerPosition(stagStationsList[stagStationIndex].stationSpawnPosition);

        /*
            if the stagStation changes scene
            1- make sure this object is set to DontDestroyOnLoad
            2- load the scene
            3- when the scene is loaded continue to set the player position
        */

    }
}
