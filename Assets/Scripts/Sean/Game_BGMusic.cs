using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_BGMusic : MonoBehaviour
{

    // Use this for initialization
    void Start() {

    }
    /*
        private static Game_BGMusic instance = null;
        public static Game_BGMusic Instance {
            get { return instance; }
        }
   

    void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

*/

        private static Game_BGMusic saSingletonPattern;
        public static Game_BGMusic Instance
        {
            get { return saSingletonPattern; }
        }

        void Awake()
        {
            if (saSingletonPattern != null && saSingletonPattern != this)
            {
                Destroy(this.gameObject);
                return;
            }
            else
            {
                saSingletonPattern = this;
            }
            DontDestroyOnLoad(this.gameObject);
        }
    

    void Update()
    {
        
    }
}
// https://answers.unity.com/questions/11314/audio-or-music-to-continue-playing-between-scene-c.html