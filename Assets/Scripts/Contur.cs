using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Contur
{
    private List<Edge> _edges = new();

    public IReadOnlyList<Edge> Edges => _edges;

    public void AddEdge(Edge newEdge)
    {
        _edges.Add(newEdge);
    }

    public void RemoveEdge(Edge edge)
    {
        _edges.Remove(edge);
    }

    public void Clean()
    {
        _edges.Clear();
    }

    public List<Vector3> GetAllNeighbours(Vector3 point)
    {
        return _edges.Where(o => o.ConnectedPoints.Contains(point)).SelectMany(o => o.ConnectedPoints).Where(o => o != point).ToList();
    }
}
