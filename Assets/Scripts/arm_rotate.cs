using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class arm_rotate : MonoBehaviour
{
    
    [SerializeField] Transform arm_pivot;
    [SerializeField] [Range(0,180)] int temp = 0;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    float Lerp( float a, float b, float t ) {
        return ( 1.0f - t ) * a + b * t;
        }

    float InvLerp( float a, float b, float v ) {
        return ( v - a ) / ( b - a );
    }
    float Remap ( float iMin, float iMax, float oMin, float oMax, float v ) 
        {
        float t = InvLerp( iMin, iMax, v );
        return Lerp( oMin, oMax, t );
        }

    // Update is called once per frame
    void Update()
    {
        int y = temp;
        arm_pivot.localRotation = Quaternion.Euler(0, Remap(0, 180, 140, -140, temp), 0);    
    }
}
