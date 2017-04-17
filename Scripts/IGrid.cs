using UnityEngine;

namespace foxfluff.GridSystem
{
	public interface IGrid
	{
		GameObject GetObject(Point coordinate);
		void SetObject(Point coordinate, GameObject gObject);
		void RemoveObject(Point coordinate);
	}
}