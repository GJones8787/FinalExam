using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Points : MonoBehaviour
{
    public Transform increasePoints;
    public Text pointsText;
    // Update is called once per frame
    void Update()
    {
        pointsText.text = increasePoints.ToString();
    }
}
