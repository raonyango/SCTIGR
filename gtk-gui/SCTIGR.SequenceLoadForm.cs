
// This file has been generated by the GUI designer. Do not modify.
namespace SCTIGR
{
	public partial class SequenceLoadForm
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView textview1;

		private global::Gtk.HBox hbox1;

		private global::Gtk.Button button1;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget SCTIGR.SequenceLoadForm
			this.Name = "SCTIGR.SequenceLoadForm";
			this.Title = global::Mono.Unix.Catalog.GetString ("SequenceLoadForm");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Container child SCTIGR.SequenceLoadForm.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.textview1 = new global::Gtk.TextView ();
			this.textview1.CanFocus = true;
			this.textview1.Name = "textview1";
			this.GtkScrolledWindow.Add (this.textview1);
			this.vbox1.Add (this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.GtkScrolledWindow]));
			w2.Position = 0;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.button1 = new global::Gtk.Button ();
			this.button1.CanFocus = true;
			this.button1.Name = "button1";
			this.button1.UseUnderline = true;
			this.button1.Label = global::Mono.Unix.Catalog.GetString ("Wczytaj");
			this.hbox1.Add (this.button1);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.button1]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w4.Position = 1;
			w4.Expand = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 300;
			this.Show ();
			this.button1.Activated += new global::System.EventHandler (this.OnButton1Activated);
		}
	}
}
