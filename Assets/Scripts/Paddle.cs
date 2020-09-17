using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] float unitMultiplyer = 16f;
    [SerializeField] float clampBoundsMin = 1f;
    [SerializeField] float clampBoundsMax = 15f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //PlayerPaddle.transform.position = vector2(2, 0);
        //Get mouse position coordinates
        //We do this ratio so that we ensure consistency whatever 4:3 resolution a player might have
        Debug.Log(Input.mousePosition.x / Screen.width * unitMultiplyer);
        float mousePosInUnits = Input.mousePosition.x / Screen.width * unitMultiplyer;
        //We use Mathf.Clamp(startVal, min, max) to limit our paddle's x-position in a range corresponding to the screen
        Vector2 paddlePos = new Vector2(transform.position.x, 0.5f);
        paddlePos.x = Mathf.Clamp(mousePosInUnits, clampBoundsMin, clampBoundsMax);
        transform.position = paddlePos;
    }
}
