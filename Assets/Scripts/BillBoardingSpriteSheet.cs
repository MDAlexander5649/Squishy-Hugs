using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BillBoardingSpriteSheet : MonoBehaviour
{
    public Transform toFace;
    public SpriteRenderer toManipulate;
    public Sprite[] mySprites;
    private float theta;
    private Vector3 a;
    void Update()
    {
        toManipulate.sprite = mySprites[GetAngleIndex()];
        toManipulate.gameObject.transform.LookAt(toFace);
    }
    int GetAngleIndex()
    {
        Vector3 targetDir = toFace.position - transform.position;
        float angle = Vector3.SignedAngle(targetDir, transform.forward, Vector3.up);

        Debug.Log(angle);

        if (angle >= 30.0f && angle < 90.0f)
            return 5; // Looking forward right
        else if (angle >= 90.0f && angle < 150.0f)
            return 4; // looking back right// looking back left
        else if ((angle >= 150.0f && angle <= 180.0f) || (angle <= -150.0f && angle >= -180.0f))
            return 3; // back
        else if (angle <= -90.0f && angle > -150.0f)
            return 2; // looking back left
        else if (angle <= -30.0f && angle > -90.0f)
            return 1; // looking forwar left
        else if (angle > -30.0f || angle < 30.0f)
            return 0; // front
        else return 0;
    }
}
