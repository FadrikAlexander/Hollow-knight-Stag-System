using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StagStationsUIManager : MonoBehaviour
{
    public GameObject UIStagPanel;
    public GameObject UIStagStationsButtonsParentObject;
    List<GameObject> UIStagStationsButtons;
    [SerializeField] GameObject UIButtonPrefab;
    StagStationsManager stagStationsManager;

    void Awake()
    {
        UIStagStationsButtons = new List<GameObject>();
        stagStationsManager = FindObjectOfType<StagStationsManager>();
    }

    void ResetUI()
    {
        //Reset List
        foreach (GameObject button in UIStagStationsButtons)
            Destroy(button);

        UIStagStationsButtons = new List<GameObject>();

        UIStagPanel.SetActive(true);
    }

    public void ShowStagStationUI(List<StagStation> stagStationsList)
    {
        ResetUI();

        for (int i = 0; i < stagStationsList.Count; i++)
        {
            SetUIButton(stagStationsList[i], i);
        }
    }

    void SetUIButton(StagStation stagStation, int index)
    {
        GameObject button = Instantiate(UIButtonPrefab, UIStagStationsButtonsParentObject.transform);

        button.GetComponent<Button>().onClick.AddListener(() => stagStationsManager.GoToStation(index));
        button.GetComponent<Button>().onClick.AddListener(() => CloseUI());

        button.GetComponentInChildren<Text>().text = stagStation.stationName;

        UIStagStationsButtons.Add(button);
    }

    public void CloseUI()
    {
        UIStagPanel.SetActive(false);
    }
}
