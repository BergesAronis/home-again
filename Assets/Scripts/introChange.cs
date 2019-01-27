using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introChange : MonoBehaviour
{
   
        public void ChangeScene(string scenename)
        {
            Application.LoadLevel(scenename);
        }

}
