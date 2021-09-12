namespace StatePattern;

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