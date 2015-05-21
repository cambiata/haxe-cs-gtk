
#pragma warning disable 109, 114, 219, 429, 168, 162
public class EntryPoint__Main {
	public static void Main() {
		global::cs.Boot.init();
		global::Main.main();
	}
}

public class Main : global::haxe.lang.HxObject {
	
	public Main(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public Main() {
		global::Main.__hx_ctor__Main(this);
	}
	
	
	public static void __hx_ctor__Main(global::Main __temp_me7) {
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
			global::Gtk.DrawingArea drawing = new global::Gtk.DrawingArea();
			( win as global::Gtk.Container ).Add(((global::Gtk.Widget) (drawing) ));
			( drawing as global::Gtk.Widget ).Show();
			global::Gtk.ExposeEventHandler __temp_stmt2 = null;
			{
				global::Gtk.ExposeEventHandler this2 = null;
				this2 = ((global::Gtk.ExposeEventHandler) (new global::Main_main_31__Fun(drawing).Delegate) );
				__temp_stmt2 = ((global::Gtk.ExposeEventHandler) (this2) );
			}
			
			( drawing as global::Gtk.Widget ).ExposeEvent += ((global::Gtk.ExposeEventHandler) (__temp_stmt2) );
			global::Gtk.Button btn = new global::Gtk.Button();
			btn.Label = ((string) ("Press me") );
			global::System.EventHandler __temp_stmt3 = null;
			{
				global::System.EventHandler this3 = null;
				this3 = ((global::System.EventHandler) (( (( global::Main_main_50__Fun.__hx_current != null )) ? (global::Main_main_50__Fun.__hx_current) : (global::Main_main_50__Fun.__hx_current = ((global::Main_main_50__Fun) (new global::Main_main_50__Fun()) )) ).Delegate) );
				__temp_stmt3 = ((global::System.EventHandler) (this3) );
			}
			
			btn.Clicked += ((global::System.EventHandler) (__temp_stmt3) );
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "line", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"main", "Main", "Main.hx"}, new int[]{1981972957}, new double[]{((double) (54) )}));
			( win as global::Gtk.Widget ).ShowAll();
			global::Gtk.Application.Run();
		}
	}
	
	
	public static new object __hx_createEmpty() {
		return new global::Main(global::haxe.lang.EmptyObject.EMPTY);
	}
	
	
	public static new object __hx_create(global::Array arr) {
		return new global::Main();
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
public class Main_main_31__Fun : global::haxe.lang.Function {
	
	public Main_main_31__Fun(global::Gtk.DrawingArea drawing) : base(2, 0) {
		this.drawing = drawing;
	}
	
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::Gtk.ExposeEventArgs e1 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::Gtk.ExposeEventArgs) (((object) (__fn_float2) )) )) : (((global::Gtk.ExposeEventArgs) (__fn_dyn2) )) );
		object t1 = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(t1, e1);
		return null;
	}
	
	
	public void Delegate(object t1, global::Gtk.ExposeEventArgs e1) {
		unchecked {
			global::Cairo.Context context = global::Gdk.CairoHelper.Create(((global::Gdk.Drawable) (( this.drawing as global::Gtk.Widget ).GdkWindow) ));
			context.MoveTo(((double) (10) ), ((double) (10) ));
			context.LineTo(((double) (100) ), ((double) (10) ));
			context.LineTo(((double) (100) ), ((double) (100) ));
			context.LineTo(((double) (10) ), ((double) (100) ));
			context.LineTo(((double) (10) ), ((double) (100) ));
			context.ClosePath();
			context.Color = ((global::Cairo.Color) (new global::Cairo.Color(((double) (0) ), ((double) (0) ), ((double) (0) ))) );
			context.FillPreserve();
			context.Color = ((global::Cairo.Color) (new global::Cairo.Color(((double) (1) ), ((double) (0) ), ((double) (0) ))) );
			context.Stroke();
		}
	}
	
	
	public global::Gtk.DrawingArea drawing;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Main_main_50__Fun : global::haxe.lang.Function {
	
	public Main_main_50__Fun() : base(2, 0) {
	}
	
	
	public static global::Main_main_50__Fun __hx_current;
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e2 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object obj = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(obj, e2);
		return null;
	}
	
	
	public void Delegate(object obj, global::System.EventArgs e2) {
		unchecked {
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "Thanks!", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"main", "Main", "Main.hx"}, new int[]{1981972957}, new double[]{((double) (51) )}));
		}
	}
	
	
}


