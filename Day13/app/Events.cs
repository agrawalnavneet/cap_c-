using System;

public delegate void MyEventHandler();


class Button
{
    public event MyEventHandler Click;

    public void Press()
    {
        Console.WriteLine("Button pressed");
        Click?.Invoke(); // fire event
    }
}
class Main7
{
    public static void main7()
    {
        Button btn = new Button();
        btn.Click += OnButtonClick;

        btn.Press();
    }

    static void OnButtonClick()
    {
        Console.WriteLine("Button click event handled");
    }
}
