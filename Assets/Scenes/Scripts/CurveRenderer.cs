using UnityEngine;

public class CurveRenderer : MonoBehaviour
{
    public Transform controlPoint1;
    public Transform controlPoint2;
    public Transform endPoint;
    public int numberOfPoints = 50; // Number of line segments

    private LineRenderer lineRenderer;

    private void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.positionCount = numberOfPoints;

        // Calculate and set points for the curve
        Vector3[] curvePoints = CalculateCurvePoints();
        lineRenderer.SetPositions(curvePoints);
    }

    private Vector3[] CalculateCurvePoints()
    {
        Vector3[] points = new Vector3[numberOfPoints];

        for (int i = 0; i < numberOfPoints; i++)
        {
            float t = i / (float)(numberOfPoints - 1);
            // Calculate points on your quadratic or cubic curve using controlPoint1, controlPoint2, and endPoint
            // For example, for a quadratic curve: points[i] = CalculateQuadraticPoint(t);
            // For a cubic curve: points[i] = CalculateCubicPoint(t);
        }

        return points;
    }

    // Implement CalculateQuadraticPoint and CalculateCubicPoint methods to calculate curve points.
}
