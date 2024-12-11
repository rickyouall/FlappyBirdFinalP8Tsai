using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Columns : MonoBehaviour
{
    private void OTriggerEnter2D(Collision2D other)
    {
        {
            GameControl.instance.BirdScored();

        }




    }
}
