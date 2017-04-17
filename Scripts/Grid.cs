using System;
using UnityEngine;

namespace foxfluff.GridSystem
{
	public class Grid : MonoBehaviour, IGrid
	{
		[SerializeField] private GridDimension length;
		[SerializeField] private GridDimension width;
		[SerializeField] private GridDimension height;

		private GridEntry[,,] grid; // should be part of the interface

		public GameObject GetObject(Point coordinate)
		{
			return grid[coordinate.X, coordinate.Y, coordinate.Z].Entry;
		}

		public void RemoveObject(Point coordinate)
		{
			Destroy(grid[coordinate.X, coordinate.Y, coordinate.Z].Entry);
			grid[coordinate.X, coordinate.Y, coordinate.Z] = null;
		}

		public void SetObject(Point coordinate, GameObject gObject)
		{
			#warning Need to change transform on new objects to be placed properly
			grid[coordinate.X, coordinate.Y, coordinate.Z] = new GridEntry(gObject);
		}

		void Start()
		{
			grid = new GridEntry[length.CellCount, width.CellCount, height.CellCount];
		}
	}
}