using UnityEngine;
using UnityEngine.SceneManagement;

public class MapLoader : MonoBehaviour
{
    public MapData mapData;
    public GameObject currentMap;
    public GameObject homePanel;

    public void LoadMap(string mapName)
    {
        if (currentMap != null)
        {
            Destroy(currentMap);
        }

        foreach (var map in mapData.maps)
        {
            if (map.mapName == mapName)
            {
                currentMap = Instantiate(map.mapPrefab);
                return;
            }
        }

        Debug.LogWarning("Map not found: " + mapName);
    }
    public void FalsePanel()
    {
        Debug.Log("FalsePanel method called!");
        if (homePanel != null)
        {
            homePanel.SetActive(false);
        }
        else
        {
            Debug.LogError("homePanel is not assigned!");
        }
    }
}
