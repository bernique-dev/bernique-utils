using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorUtils {

    public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Vector3 angles) {
        return RotatePointAroundPivot(point, pivot, Quaternion.Euler(angles));
    }

    public static Vector3 RotatePointAroundPivot(Vector3 point, Vector3 pivot, Quaternion rotation) {
        Vector3 dir = point - pivot; // get point direction relative to pivot
        dir = rotation * dir; // rotate it
        point = dir + pivot; // calculate rotated point
        return point; // return it
    }

}
