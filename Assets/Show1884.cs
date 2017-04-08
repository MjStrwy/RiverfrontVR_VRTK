namespace VRTK.Examples
{
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using System.Collections;

    public class Show1884: VRTK_InteractableObject
    {
        public GameObject go_Time;


        public override void StartUsing(GameObject usingObject)
        { 
            GameObject timePeriod = go_Time.gameObject;

            bool timePeriodState = timePeriod.activeSelf;
            if (timePeriodState)
            {
                timePeriod.SetActive(false);
            }
            else
            {
                timePeriod.SetActive(true);
            }



            Debug.Log("Show 1884");

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