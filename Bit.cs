using Godot;
using System;

public class Bit : ColorRect
{
    [Export]Color onColor = Colors.Yellow;
    [Export]Color offColor = Colors.Red;
    [Export]int value = 0;

    private Label bitValue;
    private lblDecimal decimalDisplay;
    private lblHex hexDisplay;



    public override void _Ready()
    {
        this.Color = offColor;   
        bitValue = GetNode<Label>("BitValue");
        hexDisplay = GetNode<lblHex>("../lblHex");
        decimalDisplay = GetNode<lblDecimal>("../lblDecimal");
    }



    //on_click_signal
    public void _on_Bit_gui_input(InputEventMouseButton e) {
        if(e.Pressed) {
            GD.Print(value);
            if(this.Color == offColor) {
                this.Color = onColor;
                bitValue.Text = "1";
                decimalDisplay.UpdateTotal(value);
                hexDisplay.UpdateTotal(value);
            }
            else {
                this.Color = offColor;
                bitValue.Text = "0";
                decimalDisplay.UpdateTotal(-value);
                hexDisplay.UpdateTotal(-value);
            }
        }
    }
}
