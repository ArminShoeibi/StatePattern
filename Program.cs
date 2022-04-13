using StatePattern;
using System;

Canvas canvas = new(new SelectionTool());
canvas.OnMouseDown();
canvas.OnMouseUp();
Console.WriteLine($"Current Tool is {canvas.GetCurrentTool.GetType().Name}");

canvas.SetNewTool(new BrushTool());
canvas.OnMouseDown();
canvas.OnMouseUp();
Console.WriteLine($"Current Tool is {canvas.GetCurrentTool.GetType().Name}");

/*
 * In State pattern a class behavior changes based on its state.
 * This type of design pattern comes under behavior pattern.
 * In State pattern, we create objects which represent various states and
 * a context object whose behavior varies as its state object changes.
 */


public class Canvas
{
    private ITool _currentTool;
    public Canvas(ITool firstTool)
    {
        _currentTool = firstTool;
    }
    public void SetNewTool(ITool newTool) => _currentTool = newTool;
    public ITool GetCurrentTool => _currentTool;
    public void OnMouseDown() => _currentTool.OnMouseDown();
    public void OnMouseUp() => _currentTool.OnMouseUp();

}

public interface ITool
{
    void OnMouseDown();
    void OnMouseUp();
}


public class SelectionTool : ITool
{
    public void OnMouseDown() => Console.WriteLine("Selection Icon");
    public void OnMouseUp() => Console.WriteLine("Draw a dashed rectangle");
}
public class BrushTool : ITool
{
    public void OnMouseDown() => Console.WriteLine("Brush Icon");
    public void OnMouseUp() => Console.WriteLine("Draw a line");
}
