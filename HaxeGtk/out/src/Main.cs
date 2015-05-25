
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
			global::Gtk.Window win = new global::Gtk.Window(((string) ("Haxe, C# and GTK") ));
			win.Resize(((int) (600) ), ((int) (400) ));
			global::Gtk.DeleteEventHandler __temp_stmt1 = null;
			{
				global::Gtk.DeleteEventHandler this1 = null;
				this1 = ((global::Gtk.DeleteEventHandler) (( (( global::Main_main_18__Fun.__hx_current != null )) ? (global::Main_main_18__Fun.__hx_current) : (global::Main_main_18__Fun.__hx_current = ((global::Main_main_18__Fun) (new global::Main_main_18__Fun()) )) ).Delegate) );
				__temp_stmt1 = ((global::Gtk.DeleteEventHandler) (this1) );
			}
			
			( win as global::Gtk.Widget ).DeleteEvent += ((global::Gtk.DeleteEventHandler) (__temp_stmt1) );
			global::Gtk.Button btn = new global::Gtk.Button();
			btn.Label = ((string) ("Button") );
			global::System.EventHandler __temp_stmt2 = null;
			{
				global::System.EventHandler this2 = null;
				this2 = ((global::System.EventHandler) (( (( global::Main_main_25__Fun.__hx_current != null )) ? (global::Main_main_25__Fun.__hx_current) : (global::Main_main_25__Fun.__hx_current = ((global::Main_main_25__Fun) (new global::Main_main_25__Fun()) )) ).Delegate) );
				__temp_stmt2 = ((global::System.EventHandler) (this2) );
			}
			
			btn.Clicked += ((global::System.EventHandler) (__temp_stmt2) );
			( win as global::Gtk.Container ).Add(((global::Gtk.Widget) (btn) ));
			( win as global::Gtk.Widget ).ShowAll();
			global::Gtk.Application.Run();
		}
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Main_main_18__Fun : global::haxe.lang.Function {
	
	public Main_main_18__Fun() : base(2, 0) {
	}
	
	
	public static global::Main_main_18__Fun __hx_current;
	
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
public class Main_main_25__Fun : global::haxe.lang.Function {
	
	public Main_main_25__Fun() : base(2, 0) {
	}
	
	
	public static global::Main_main_25__Fun __hx_current;
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e1 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object obj = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(obj, e1);
		return null;
	}
	
	
	public void Delegate(object obj, global::System.EventArgs e1) {
		unchecked {
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "Hello world!", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"main", "Main", "Main.hx"}, new int[]{1981972957}, new double[]{((double) (26) )}));
		}
	}
	
	
}


