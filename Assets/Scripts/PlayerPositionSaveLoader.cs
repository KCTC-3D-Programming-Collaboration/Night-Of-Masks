using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class PlayerPositionSaveLoader : MonoBehaviour
{

    public static void SavePlayerPosition(Vector3 playerpos)
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream stream = new FileStream(Application.persistentDataPath + "/position.data", FileMode.Create);

        PlayerPosition data = new PlayerPosition(playerpos);

        bf.Serialize(stream, data);
        stream.Close();

    }

    public static Vector3 LoadPlayerPosition()
    {
        if (File.Exists(Application.persistentDataPath + "/position.data"))
        {
            //File.Delete(Application.persistentDataPath + "/position.data");
            BinaryFormatter bf = new BinaryFormatter();
            FileStream stream = new FileStream(Application.persistentDataPath + "/position.data", FileMode.Open);

            PlayerPosition location = bf.Deserialize(stream) as PlayerPosition;
            Vector3 returnable = new Vector3(location.PositionX, location.PositionY, location.PositionZ);

            stream.Close();
            return returnable;
        }
        else
        {
            return new Vector3(0, 1, 0);
        }
        Debug.LogError("HOW THE HECK DID YOU GET THIS MESSAGE?");
        return new Vector3(0, 1, 0); //"Just incase something goes REALLY wrong"

    }





    [Serializable]
    public class PlayerPosition
    {
        public float PositionX;
        public float PositionY;
        public float PositionZ;
        public PlayerPosition(Vector3 pos)
        {
            PositionX = pos.x;
            PositionY = pos.y;
            PositionZ = pos.z;
        }
    }
}
