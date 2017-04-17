using System;
using UnityEngine;

namespace foxfluff.GridSystem
{
	/// <summary>
	/// Grid will 
	/// </summary>
	public class Grid : MonoBehaviour, IGrid
	{
		[SerializeField] private GridDimension length; //x
		[SerializeField] private GridDimension width; //y
		[SerializeField] private GridDimension height; //z

		public GridDimension Length { get { return length; } }
		public GridDimension Width { get { return width; } }
		public GridDimension Height { get { return height; } }

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
			GridEntry entry = new GridEntry(gObject);
			entry.Wrapper.name = string.Format("({0},{1},{2})", coordinate.X, coordinate.Y, coordinate.Z);
			entry.Wrapper.transform.SetParent(transform);
			entry.Wrapper.transform.localPosition = calcPosition(coordinate);

			grid[coordinate.X, coordinate.Y, coordinate.Z] = entry;
		}

		void Awake()
		{
			grid = new GridEntry[length.CellCount, width.CellCount, height.CellCount];
		}

		private Vector3 calcPosition(Point coordinate)
		{
			return new Vector3(
				coordinate.X * (length.CellDistance / length.CellCount),
				coordinate.Y * (width.CellDistance / width.CellCount),
				coordinate.Z * (height.CellDistance / height.CellCount)
			);
		}
	}
}