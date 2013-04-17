using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{  
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}
	
	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}

	protected void OnBotsumClicked (object sender, EventArgs e)
	{

		int res1 = int.Parse(this.res1.Text);
		int res2 = int.Parse (this.res2.Text);
		int resultado = res1 + res2;
		this.resultado.Text = resultado.ToString();

	}

	protected void OnBotresClicked (object sender, EventArgs e)
	{
		int res1 = int.Parse(this.res1.Text);
		int res2 = int.Parse (this.res2.Text);
		int resultado = res1 - res2;
		this.resultado.Text = resultado.ToString();
	}

	protected void OnBotmultiClicked (object sender, EventArgs e)
	{
		int res1 = int.Parse(this.res1.Text);
		int res2 = int.Parse (this.res2.Text);
		int resultado = res1 * res2;
		this.resultado.Text = resultado.ToString();
	}

	protected void OnBotdivClicked (object sender, EventArgs e)
	{
		int res1 = int.Parse(this.res1.Text);
		int res2 = int.Parse (this.res2.Text);
		int resultado = res1 / res2;
		this.resultado.Text = resultado.ToString();
	}
}
