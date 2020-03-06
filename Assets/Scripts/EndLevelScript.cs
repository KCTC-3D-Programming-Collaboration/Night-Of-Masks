using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevelScript : MonoBehaviour
{
    public int levelNum;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))//only end level when player enters the end zone
        {
        //    PlayerPositionSaveLoader.SavePlayerPosition(new Vector3(0, 1, 0));
        //    int levelsBeat = LevelSaveLoader.LoadLevelsBeat();
        //    if(levelNum > levelsBeat)
        //    {
        //        LevelSaveLoader.SaveLevelBeat(levelNum);
        //    }

            if (levelNum == 1)
            {
                SceneManager.LoadScene("Level_2");
            }
            else if (levelNum == 2)
            {
                SceneManager.LoadScene("Level_3");
            }
            else if (levelNum == 3)
            {
                SceneManager.LoadScene("Main_Menu");
            }
            //SceneManager.LoadScene("Main_Menu");
        }
    }
}
