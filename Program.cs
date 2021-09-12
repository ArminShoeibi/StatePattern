using StatePattern;

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