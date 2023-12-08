using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLocationS : MonoBehaviour
{
    //=========================================================== Editor
    public int nextMapNumber;
    public LocationControllerS.Side exitSide;
    float sideValue;
    //=========================================================== Editor
    private void Awake()
    {
        if (exitSide == LocationControllerS.Side.left)
        {
            sideValue = 1f;
        }
        else
        {
            sideValue = -1f;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "player")
        {
            collision.gameObject.GetComponent<CharacterMovementS>().currentMapNumber = nextMapNumber;
            Transform nextMapPosition = LocationControllerS.inst.maps[nextMapNumber].transform;

            collision.gameObject.transform.position =
                new Vector3(nextMapPosition.position.x + nextMapPosition.localScale.x/3f * sideValue,
                collision.gameObject.transform.position.y, 0f);
        }
    }
}
