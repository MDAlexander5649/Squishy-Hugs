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

        if (angle >= 45.0f && angle < 135.0f)
            return 1; // Looking forward right
        
        else if ((angle >= 135.0f && angle <= 180.0f) || (angle <= -135.0f && angle >= -180.0f))
            return 2; // back
        else if (angle <= -45.0f && angle > -135.0f)
            return 3; // looking left
        
        else if (angle > -45.0f || angle < 45.0f)
            return 0; // front
        else return 0;
    }
}
