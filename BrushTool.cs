namespace StatePattern;

public class BrushTool : ITool
{
    public void OnMouseDown() => Console.WriteLine("Brush Icon");
    public void OnMouseUp() => Console.WriteLine("Draw a line");
}
