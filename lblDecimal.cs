using Godot;
using System;

public class lblDecimal : Label
{
    private int total = 0;
//    private CS cs;

    public override void _Ready() {
//        cs = GetNode("/root/CS");
//        cs.Connect ("BitChanged", this, "UpdateTotal");
    }


    public void UpdateTotal(int amt) {
        total += amt;
        UpdateDisplay();
    }


    private void UpdateDisplay() {
        this.Text = total.ToString();
    }
}
