namespace MauiStarbucks.Views.ControlViews;

public partial class CustomStepperView : Microsoft.Maui.Controls.ContentView
{
	int count;
	public CustomStepperView()
	{
		InitializeComponent();
		count = 0;
	}
    private void Substract_Tapped(object sender, EventArgs e)
    {
		if (count <= 0) return;
		this.CountLabel.Text = Convert.ToString(--count);
    }
    private void Add_Tapped(object sender, EventArgs e)
	{
        this.CountLabel.Text = Convert.ToString(++count);
    }
}