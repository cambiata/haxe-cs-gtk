
#pragma warning disable 109, 114, 219, 429, 168, 162
public class EntryPoint__Main {
	public static void Main() {
		global::cs.Boot.init();
		global::Main.main();
	}
}

public class Main {
	
	public Main() {
	}
	
	
	public static void main() {
		unchecked {
			global::Gtk.Application.Init();
			global::Gtk.Window win = new global::Gtk.Window(((string) ("Hello") ));
			win.Resize(((int) (200) ), ((int) (200) ));
			global::Gtk.DeleteEventHandler __temp_stmt1 = null;
			{
				global::Gtk.DeleteEventHandler this1 = null;
				this1 = ((global::Gtk.DeleteEventHandler) (( (( global::Main_main_22__Fun.__hx_current != null )) ? (global::Main_main_22__Fun.__hx_current) : (global::Main_main_22__Fun.__hx_current = ((global::Main_main_22__Fun) (new global::Main_main_22__Fun()) )) ).Delegate) );
				__temp_stmt1 = ((global::Gtk.DeleteEventHandler) (this1) );
			}
			
			( win as global::Gtk.Widget ).DeleteEvent += ((global::Gtk.DeleteEventHandler) (__temp_stmt1) );
			global::Gtk.Button btn = new global::Gtk.Button();
			btn.Label = ((string) ("Press me") );
			global::System.EventHandler __temp_stmt2 = null;
			{
				global::System.EventHandler this2 = null;
				this2 = ((global::System.EventHandler) (( (( global::Main_main_49__Fun.__hx_current != null )) ? (global::Main_main_49__Fun.__hx_current) : (global::Main_main_49__Fun.__hx_current = ((global::Main_main_49__Fun) (new global::Main_main_49__Fun()) )) ).Delegate) );
				__temp_stmt2 = ((global::System.EventHandler) (this2) );
			}
			
			btn.Clicked += ((global::System.EventHandler) (__temp_stmt2) );
			global::PrettyDrawing a = new global::PrettyDrawing();
			global::Gtk.HBox box = new global::Gtk.HBox(true, 0);
			( box as global::Gtk.Container ).Add(((global::Gtk.Widget) (a) ));
			( box as global::Gtk.Container ).Add(((global::Gtk.Widget) (btn) ));
			( win as global::Gtk.Container ).Add(((global::Gtk.Widget) (box) ));
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "line", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"main", "Main", "Main.hx"}, new int[]{1981972957}, new double[]{((double) (64) )}));
			( win as global::Gtk.Widget ).ShowAll();
			global::System.Drawing.Bitmap bitmap = new global::System.Drawing.Bitmap(((int) (300) ), ((int) (300) ));
			global::System.Drawing.Graphics gr = global::System.Drawing.Graphics.FromImage(((global::System.Drawing.Image) (bitmap) ));
			gr.FillEllipse(((global::System.Drawing.Brush) (global::System.Drawing.Brushes.Red) ), ((global::System.Drawing.RectangleF) (new global::System.Drawing.RectangleF(((float) (0) ), ((float) (0) ), ((float) (100) ), ((float) (100) ))) ));
			global::Svg.SvgDocument svg1 = global::Svg.SvgDocument.Open<global::Svg.SvgDocument>(((string) ("F:\\tiger.svg") ));
			svg1.Draw(((global::System.Drawing.Graphics) (gr) ));
			gr.Save();
			( bitmap as global::System.Drawing.Image ).Save(((string) ("test.png") ));
			global::Gtk.Application.Run();
		}
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Main_main_22__Fun : global::haxe.lang.Function {
	
	public Main_main_22__Fun() : base(2, 0) {
	}
	
	
	public static global::Main_main_22__Fun __hx_current;
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::Gtk.DeleteEventArgs e = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::Gtk.DeleteEventArgs) (((object) (__fn_float2) )) )) : (((global::Gtk.DeleteEventArgs) (__fn_dyn2) )) );
		object t = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(t, e);
		return null;
	}
	
	
	public void Delegate(object t, global::Gtk.DeleteEventArgs e) {
		global::Gtk.Application.Quit();
		( e as global::GLib.SignalArgs ).RetVal = ((object) (true) );
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Main_main_49__Fun : global::haxe.lang.Function {
	
	public Main_main_49__Fun() : base(2, 0) {
	}
	
	
	public static global::Main_main_49__Fun __hx_current;
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e1 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object obj = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(obj, e1);
		return null;
	}
	
	
	public void Delegate(object obj, global::System.EventArgs e1) {
		unchecked {
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "Thanks!", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"main", "Main", "Main.hx"}, new int[]{1981972957}, new double[]{((double) (50) )}));
		}
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class PrettyDrawing : global::Gtk.DrawingArea {
	
	public PrettyDrawing() : base() {
		unchecked {
			( this as global::Gtk.Widget ).SetSizeRequest(((int) (200) ), ((int) (200) ));
		}
	}
	
	
	protected override bool OnExposeEvent(global::Gdk.EventExpose e) {
		unchecked {
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "PrettyDrawing redraw", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"OnExposeEvent", "PrettyDrawing", "Main.hx"}, new int[]{1981972957}, new double[]{((double) (96) )}));
			global::System.Drawing.Pen pen = new global::System.Drawing.Pen(((global::System.Drawing.Color) (global::System.Drawing.Color.Blue) ));
			global::System.Drawing.Graphics g = global::Gtk.DotNet.Graphics.FromDrawable(((global::Gdk.Drawable) (( e as global::Gdk.Event ).Window) ));
			g.DrawLine(((global::System.Drawing.Pen) (pen) ), ((int) (0) ), ((int) (0) ), ((int) (100) ), ((int) (100) ));
			return true;
		}
	}
	
	
}


