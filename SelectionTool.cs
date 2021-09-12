namespace StatePattern;

public class SelectionTool : ITool
{
    public void OnMouseDown() => Console.WriteLine("Selection Icon");
    public void OnMouseUp() => Console.WriteLine("Draw a dashed rectangle");
}
