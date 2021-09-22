using Godot;
using System;

public class lblHex : Label
{
    private int total = 0;

    public void UpdateTotal(int amt) {
        total += amt;
        UpdateDisplay();
    }


    private void UpdateDisplay() {
        this.Text = total.ToString("X");
    }
}
