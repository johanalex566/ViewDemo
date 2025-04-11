namespace ViewDemo.Views;

public partial class SettingPage : ContentPage
{
    public SettingPage()
    {
        InitializeComponent();

        datePicker.Date = new(2022, 05, 23);
        datePicker.MinimumDate = datePicker.Date.AddMonths(-12);
        datePicker.MaximumDate = datePicker.Date.AddMonths(12);

    }

    private void CheckBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (label != null)
        {
            label.Text = $"CheckBox: {e.Value}";
        }
    }

    private void datePicker_DateSelected(object sender, DateChangedEventArgs e)
    {
        if (label != null)
        {
            label.Text = $"DatePicker: {e.NewDate}\n";
        }
    }

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        image!.Rotation = e.NewValue;
        label!.Text = $"Slider: {e.NewValue:F2}°";
    }

    private void Stepper_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        slider!.Value = e.NewValue;
    }
}