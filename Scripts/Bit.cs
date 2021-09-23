using Godot;
using System;

public class Bit : ColorRect
{
    [Export]Color onColor = Colors.Yellow;
    [Export]Color offColor = Colors.Red;
    [Export]int value = 0;

    private Label bitValue;
    private CustomSignals cs;



    public override void _Ready()
    {
        cs = GetNode<CustomSignals>("/root/CS");
        bitValue = GetNode<Label>("BitValue");
        this.Color = offColor;
    }



    public void _on_Bit_gui_input(InputEventMouseButton e) {
        if(e.Pressed) {
            if(this.Color == offColor) {
                this.Color = onColor;
                bitValue.Text = "1";
                cs.EmitSignal(nameof(CustomSignals.BitChanged), value);
            }
            else {
                this.Color = offColor;
                bitValue.Text = "0";
                cs.EmitSignal(nameof(CustomSignals.BitChanged), -value);
            }
        }
    }
}
