using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointsDecrease : MonoBehaviour
{
    public Transform decreasePoints;
    public Text pointText;
    // Update is called once per frame
    void Update()
    {
        pointText.text = decreasePoints.ToString();
    }
}