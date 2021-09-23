using Godot;
using System;

public class lblHex : Label
{
    protected int total = 0;
    private CustomSignals cs;

    public override void _Ready() {
        cs = GetNode<CustomSignals>("/root/CS");
        cs.Connect("BitChanged", this, "UpdateTotal");
    }


    public void UpdateTotal(int amt) {
        total += amt;
        UpdateDisplay();
    }


    protected virtual void UpdateDisplay() {
        this.Text = total.ToString("X");
    }
}
