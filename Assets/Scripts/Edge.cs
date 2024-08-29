using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Edge
{
    private List<Vector3> _connectedPoints;

    public IReadOnlyList<Vector3> ConnectedPoints => _connectedPoints;

    public Edge(List<Vector3> connectedPoints)
    {
        _connectedPoints = connectedPoints;
    }

    public void AddPoint(Vector3 point)
    {
        _connectedPoints.Add(point);
    }

    public void RemovePoint(Vector3 point)
    {
        _connectedPoints.Remove(point);
    }
}
