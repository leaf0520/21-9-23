    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurveController : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public Transform startPoint;
    public Transform controlPoint;  // For Quadratic Curve
    public Transform endPoint;  // For Cubic Curve
    public int resolution = 10;  // Number of line segments

    private void Start()
    {
        lineRenderer.positionCount = resolution + 1;
        DrawCurve();
    }

    private void DrawCurve()
    {
        for (int i = 0; i <= resolution; i++)
        {
            float t = i / (float)resolution;

            // Calculate the position based on the curve type
            Vector3 position = QuadraticCurve(t); // Change to CubicCurve for cubic

            lineRenderer.SetPosition(i, position);
        }
    }

    // Quadratic Bézier Curve formula
    private Vector3 QuadraticCurve(float t)
    {
        float u = 1 - t;
        float tt = t * t;
        float uu = u * u;
        Vector3 p = (uu * startPoint.position) + (2 * u * t * controlPoint.position) + (tt * endPoint.position);
        return p;
    }

    // Cubic Bézier Curve formula
    private Vector3 CubicCurve(float t)
    {
        float u = 1 - t;
        float tt = t * t;
        float uu = u * u;
        float ttt = tt * t;
        float uuu = uu * u;
        Vector3 p = (uuu * startPoint.position) + (3 * uu * t * controlPoint.position) + (3 * u * tt * endPoint.position) + (ttt * endPoint.position);
        return p;
    }
}
