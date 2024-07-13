﻿namespace ScottPlot.Interactivity.UserActions;

public record struct MiddleMouseUp(Pixel Pixel) : IMouseInput
{
    public DateTime DateTime { get; set; } = DateTime.Now;
}
