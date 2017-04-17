# Unity3D Grid System
This is a simple grid system that allows you to uniformly place GameObjects in a 3 dimensional grid.
## How to use
* Attach the `Grid` script to a GameObject, this will serve as the parent for your grid system.
* Take the object you wish to place on the grid, and a `Point` object, using `SetObject(...)` of the `Grid` component to assign it.

The following example assumes that `gridGameObject` is the parent GameObject with the attached `Grid` component, and that `myObject` is the GameObject you wish to attach to the grid at the specified point (0, 0, 0)
```
Grid grid = gridGameObject.GetComponent<Grid>();
grid.SetObject(new Point(0,0,0), myObject);
```
## Problems
* Default value for a `Grid.Dimension.CellDistance` is 0, causing a divide by 0 error, if doing a 1 or 2 dimensional grid, set the appropriate distance to 1.
* There's no editor scripts for adjusting the grid dimensions in a nice editor-y way, and no way to attach objects to a grid non-dynamically.