namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using System.Collections;

    public class highlightSphere : VRTK_InteractableObject
    {
        float spinSpeed = 0f;
        Transform rotator;

        public override void StartUsing(GameObject usingObject)
        {
            //SceneManager.LoadScene("01_Present", LoadSceneMode.Single);

            //Advance to next scene
            int level = SceneManager.GetActiveScene().buildIndex;
            level++;

            int MaxLevels = SceneManager.sceneCountInBuildSettings;

            //if level is greater than included scene indexes, reset to 0
            if(level >= MaxLevels)
            {
                level = 0;
            }
            SceneManager.LoadScene(level, LoadSceneMode.Single);
            Debug.Log("Scene changed");
            
        }

        public override void StopUsing(GameObject usingObject)
        {
            
        }

        protected void Start()
        {
            
        }

        protected override void Update()
        {
          
        }
    }
}