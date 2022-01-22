using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Tk.Menus { 

    public class MainMenuCC : MonoBehaviour
    {
        public string PlaySceneName;
        private Scene currentScene;
        // Start is called before the first frame update
        void Start()
        {
            currentScene = SceneManager.GetActiveScene();
        }

        // Update is called once per frame
        void Update()
        {
        
        }

        public void ChangeToPlay()
        {
            SceneManager.LoadScene(PlaySceneName, LoadSceneMode.Single);
        }

    }

}
