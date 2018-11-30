// Sean Anderson
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_BGMusic : MonoBehaviour
{
        // Creating a singleton class for the background music
        private static Game_BGMusic saSingletonPattern;
        public static Game_BGMusic Instance
        {
            get { return saSingletonPattern; }
        }

        void Awake()
        {
            // Check for an existing instance
            if (saSingletonPattern != null && saSingletonPattern != this)
            {
                // If instance exists, destroy self
                Destroy(this.gameObject);
                return;
            }
            else
            {
                // If instance does not exist, store this one as an instance
                saSingletonPattern = this;
            }
            // Persist through menu changes
            DontDestroyOnLoad(this.gameObject);
        }
}
// https://answers.unity.com/questions/11314/audio-or-music-to-continue-playing-between-scene-c.html