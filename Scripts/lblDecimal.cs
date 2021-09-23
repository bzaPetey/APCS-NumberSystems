using Godot;
using System;

public class lblDecimal : lblHex
{
    protected override void UpdateDisplay() {
        this.Text = total.ToString();
    }
}
