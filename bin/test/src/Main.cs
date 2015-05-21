
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
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "dummy", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"main", "Main", "Main.hx"}, new int[]{1981972957}, new double[]{((double) (15) )}));
			global::Gtk.Application.Init();
			global::Gtk.Window win = new global::Gtk.Window(((string) ("Hello") ));
			win.Resize(((int) (200) ), ((int) (200) ));
			global::Gtk.Button btn = new global::Gtk.Button();
			btn.Label = ((string) ("Press me") );
			global::System.EventHandler __temp_stmt1 = null;
			{
				global::System.EventHandler this1 = null;
				this1 = ((global::System.EventHandler) (( (( global::Main_main_24__Fun.__hx_current != null )) ? (global::Main_main_24__Fun.__hx_current) : (global::Main_main_24__Fun.__hx_current = ((global::Main_main_24__Fun) (new global::Main_main_24__Fun()) )) ).Delegate) );
				__temp_stmt1 = ((global::System.EventHandler) (this1) );
			}
			
			btn.Clicked += ((global::System.EventHandler) (__temp_stmt1) );
			( win as global::Gtk.Container ).Add(((global::Gtk.Widget) (btn) ));
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
public class Main_main_24__Fun : global::haxe.lang.Function {
	
	public Main_main_24__Fun() : base(2, 0) {
	}
	
	
	public static global::Main_main_24__Fun __hx_current;
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object obj = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(obj, e);
		return null;
	}
	
	
	public void Delegate(object obj, global::System.EventArgs e) {
		unchecked {
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "Thanks!", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"main", "Main", "Main.hx"}, new int[]{1981972957}, new double[]{((double) (25) )}));
		}
	}
	
	
}


