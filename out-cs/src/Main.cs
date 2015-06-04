
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
			win.SetDefaultSize(((int) (600) ), ((int) (400) ));
			win.SetPosition(((global::Gtk.WindowPosition) (global::Gtk.WindowPosition.Center) ));
			global::Gtk.DeleteEventHandler __temp_stmt3 = null;
			{
				global::Gtk.DeleteEventHandler this1 = null;
				this1 = ((global::Gtk.DeleteEventHandler) (( (( global::Main_main_25__Fun.__hx_current != null )) ? (global::Main_main_25__Fun.__hx_current) : (global::Main_main_25__Fun.__hx_current = ((global::Main_main_25__Fun) (new global::Main_main_25__Fun()) )) ).Delegate) );
				__temp_stmt3 = ((global::Gtk.DeleteEventHandler) (this1) );
			}
			
			( win as global::Gtk.Widget ).DeleteEvent += ((global::Gtk.DeleteEventHandler) (__temp_stmt3) );
			global::Gtk.VBox vboxOuter = new global::Gtk.VBox(false, 2);
			( win as global::Gtk.Container ).Add(((global::Gtk.Widget) (vboxOuter) ));
			global::Gtk.MenuBar menubar = new global::Gtk.MenuBar();
			global::Gtk.Menu filemenu = new global::Gtk.Menu();
			global::Gtk.MenuItem file = new global::Gtk.MenuItem(((string) ("File") ));
			file.Submenu = ((global::Gtk.Widget) (filemenu) );
			global::Gtk.MenuItem exit = new global::Gtk.MenuItem(((string) ("Exit") ));
			( filemenu as global::Gtk.MenuShell ).Append(((global::Gtk.Widget) (exit) ));
			global::System.EventHandler __temp_stmt4 = null;
			{
				global::System.EventHandler this2 = null;
				this2 = ((global::System.EventHandler) (( (( global::Main_main_40__Fun.__hx_current != null )) ? (global::Main_main_40__Fun.__hx_current) : (global::Main_main_40__Fun.__hx_current = ((global::Main_main_40__Fun) (new global::Main_main_40__Fun()) )) ).Delegate) );
				__temp_stmt4 = ((global::System.EventHandler) (this2) );
			}
			
			exit.Activated += ((global::System.EventHandler) (__temp_stmt4) );
			( menubar as global::Gtk.MenuShell ).Append(((global::Gtk.Widget) (file) ));
			( vboxOuter as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (menubar) ), ((bool) (false) ), ((bool) (false) ), ((uint) (0) ));
			global::Gtk.Toolbar upper = new global::Gtk.Toolbar();
			upper.ToolbarStyle = ((global::Gtk.ToolbarStyle) (global::Gtk.ToolbarStyle.Icons) );
			global::Gtk.ToolButton newtb = new global::Gtk.ToolButton(((string) (global::Gtk.Stock.New) ));
			global::Gtk.ToolButton opentb = new global::Gtk.ToolButton(((string) (global::Gtk.Stock.Open) ));
			global::Gtk.ToolButton savetb = new global::Gtk.ToolButton(((string) (global::Gtk.Stock.Save) ));
			global::System.EventHandler __temp_stmt5 = null;
			{
				global::System.EventHandler this3 = null;
				this3 = ((global::System.EventHandler) (( (( global::Main_main_50__Fun.__hx_current != null )) ? (global::Main_main_50__Fun.__hx_current) : (global::Main_main_50__Fun.__hx_current = ((global::Main_main_50__Fun) (new global::Main_main_50__Fun()) )) ).Delegate) );
				__temp_stmt5 = ((global::System.EventHandler) (this3) );
			}
			
			newtb.Clicked += ((global::System.EventHandler) (__temp_stmt5) );
			upper.Insert(((global::Gtk.ToolItem) (newtb) ), ((int) (0) ));
			upper.Insert(((global::Gtk.ToolItem) (opentb) ), ((int) (1) ));
			upper.Insert(((global::Gtk.ToolItem) (savetb) ), ((int) (2) ));
			( vboxOuter as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (upper) ), ((bool) (false) ), ((bool) (false) ), ((uint) (0) ));
			global::Gtk.HBox hboxInner = new global::Gtk.HBox(false, 2);
			( vboxOuter as global::Gtk.Container ).Add(((global::Gtk.Widget) (hboxInner) ));
			global::Gtk.VBox vbox1 = new global::Gtk.VBox();
			( hboxInner as global::Gtk.Container ).Add(((global::Gtk.Widget) (vbox1) ));
			global::Gtk.CheckButton cb = new global::Gtk.CheckButton(((string) ("I\'m a checkbutton") ));
			( cb as global::Gtk.ToggleButton ).Active = ((bool) (true) );
			global::System.EventHandler __temp_stmt6 = null;
			{
				global::System.EventHandler this4 = null;
				this4 = ((global::System.EventHandler) (new global::Main_main_65__Fun(cb).Delegate) );
				__temp_stmt6 = ((global::System.EventHandler) (this4) );
			}
			
			( cb as global::Gtk.Button ).Clicked += ((global::System.EventHandler) (__temp_stmt6) );
			( vbox1 as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (cb) ), ((bool) (false) ), ((bool) (false) ), ((uint) (0) ));
			string[] items = new string[]{"Ferrari", "Lamborghini", "Porsche", "Koenigsegg"};
			global::Gtk.ComboBox combo = new global::Gtk.ComboBox(((string[]) (items) ));
			( vbox1 as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (combo) ), ((bool) (false) ), ((bool) (false) ), ((uint) (0) ));
			combo.Active = ((int) (3) );
			global::System.EventHandler __temp_stmt7 = null;
			{
				global::System.EventHandler this5 = null;
				this5 = ((global::System.EventHandler) (new global::Main_main_73__Fun(combo).Delegate) );
				__temp_stmt7 = ((global::System.EventHandler) (this5) );
			}
			
			combo.Changed += ((global::System.EventHandler) (__temp_stmt7) );
			global::Gtk.TreeView list = new global::Gtk.TreeView();
			( vbox1 as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (list) ), ((bool) (true) ), ((bool) (true) ), ((uint) (8) ));
			global::Gtk.TreeViewColumn columnA = new global::Gtk.TreeViewColumn();
			columnA.Title = ((string) ("Column A") );
			global::Gtk.CellRendererText cellA = new global::Gtk.CellRendererText();
			columnA.PackStart(((global::Gtk.CellRenderer) (cellA) ), ((bool) (true) ));
			global::Gtk.TreeViewColumn columnB = new global::Gtk.TreeViewColumn();
			columnB.Title = ((string) ("Column B") );
			global::Gtk.CellRendererText cellB = new global::Gtk.CellRendererText();
			columnB.PackStart(((global::Gtk.CellRenderer) (cellB) ), ((bool) (true) ));
			list.AppendColumn(((global::Gtk.TreeViewColumn) (columnA) ));
			list.AppendColumn(((global::Gtk.TreeViewColumn) (columnB) ));
			columnA.AddAttribute(((global::Gtk.CellRenderer) (cellA) ), ((string) ("text") ), ((int) (0) ));
			columnB.AddAttribute(((global::Gtk.CellRenderer) (cellB) ), ((string) ("text") ), ((int) (0) ));
			global::Gtk.ListStore store = new global::Gtk.ListStore(((global::System.Type[]) (new global::System.Type[]{((global::System.Type) (typeof(string)) ), ((global::System.Type) (typeof(string)) )}) ));
			store.AppendValues(((object[]) (new string[]{"Item1", "ItemA"}) ));
			list.Model = ((global::Gtk.TreeModel) (store) );
			global::Gtk.Entry textEntry = new global::Gtk.Entry();
			textEntry.Text = ((string) ("Hello world") );
			global::System.EventHandler __temp_stmt8 = null;
			{
				global::System.EventHandler this6 = null;
				this6 = ((global::System.EventHandler) (new global::Main_main_102__Fun(textEntry).Delegate) );
				__temp_stmt8 = ((global::System.EventHandler) (this6) );
			}
			
			textEntry.Changed += ((global::System.EventHandler) (__temp_stmt8) );
			( vbox1 as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (textEntry) ), ((bool) (false) ), ((bool) (false) ), ((uint) (2) ));
			global::Gtk.Button btnListAdd = new global::Gtk.Button();
			btnListAdd.Label = ((string) ("Add") );
			global::System.EventHandler __temp_stmt9 = null;
			{
				global::System.EventHandler this7 = null;
				this7 = ((global::System.EventHandler) (new global::Main_main_110__Fun(store, textEntry).Delegate) );
				__temp_stmt9 = ((global::System.EventHandler) (this7) );
			}
			
			btnListAdd.Clicked += ((global::System.EventHandler) (__temp_stmt9) );
			( vbox1 as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (btnListAdd) ), ((bool) (false) ), ((bool) (false) ), ((uint) (8) ));
			global::Gtk.Button btnListDelete = new global::Gtk.Button();
			btnListDelete.Label = ((string) ("Delete") );
			global::System.EventHandler __temp_stmt10 = null;
			{
				global::System.EventHandler this8 = null;
				this8 = ((global::System.EventHandler) (new global::Main_main_118__Fun(store, list).Delegate) );
				__temp_stmt10 = ((global::System.EventHandler) (this8) );
			}
			
			btnListDelete.Clicked += ((global::System.EventHandler) (__temp_stmt10) );
			( vbox1 as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (btnListDelete) ), ((bool) (false) ), ((bool) (false) ), ((uint) (2) ));
			global::Gtk.Button btnMessageDialog = new global::Gtk.Button();
			btnMessageDialog.Label = ((string) ("Message dialog") );
			global::System.EventHandler __temp_stmt11 = null;
			{
				global::System.EventHandler this9 = null;
				this9 = ((global::System.EventHandler) (new global::Main_main_133__Fun(win).Delegate) );
				__temp_stmt11 = ((global::System.EventHandler) (this9) );
			}
			
			btnMessageDialog.Clicked += ((global::System.EventHandler) (__temp_stmt11) );
			( vbox1 as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (btnMessageDialog) ), ((bool) (false) ), ((bool) (false) ), ((uint) (2) ));
			global::Gtk.VBox vbox2 = new global::Gtk.VBox();
			( hboxInner as global::Gtk.Container ).Add(((global::Gtk.Widget) (vbox2) ));
			global::Gtk.Button btn = new global::Gtk.Button();
			btn.Label = ((string) ("Create test.png") );
			global::System.EventHandler __temp_stmt12 = null;
			{
				global::System.EventHandler this10 = null;
				this10 = ((global::System.EventHandler) (( (( global::Main_main_148__Fun.__hx_current != null )) ? (global::Main_main_148__Fun.__hx_current) : (global::Main_main_148__Fun.__hx_current = ((global::Main_main_148__Fun) (new global::Main_main_148__Fun()) )) ).Delegate) );
				__temp_stmt12 = ((global::System.EventHandler) (this10) );
			}
			
			btn.Clicked += ((global::System.EventHandler) (__temp_stmt12) );
			( vbox2 as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (btn) ), ((bool) (false) ), ((bool) (false) ), ((uint) (0) ));
			global::Gdk.Pixbuf pixbuf = null;
			try {
				pixbuf = new global::Gdk.Pixbuf(((string) ("test.png") ));
			}
			catch (global::System.Exception __temp_catchallException1){
				global::haxe.lang.Exceptions.exception = __temp_catchallException1;
				object __temp_catchall2 = __temp_catchallException1;
				if (( __temp_catchall2 is global::haxe.lang.HaxeException )) {
					__temp_catchall2 = ((global::haxe.lang.HaxeException) (__temp_catchallException1) ).obj;
				}
				
				{
					object e10 = __temp_catchall2;
					global::haxe.Log.trace.__hx_invoke2_o(default(double), "Image not found", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"main", "Main", "Main.hx"}, new int[]{1981972957}, new double[]{((double) (165) )}));
					global::System.Environment.Exit(((int) (1) ));
				}
				
			}
			
			
			global::Gtk.Image image = new global::Gtk.Image(((global::Gdk.Pixbuf) (pixbuf) ));
			( vbox2 as global::Gtk.Container ).Add(((global::Gtk.Widget) (image) ));
			global::Gtk.ScrolledWindow scrollwin = new global::Gtk.ScrolledWindow();
			global::Gtk.Image image1 = new global::Gtk.Image(((string) ("paris.jpg") ));
			scrollwin.AddWithViewport(((global::Gtk.Widget) (image1) ));
			( hboxInner as global::Gtk.Container ).Add(((global::Gtk.Widget) (scrollwin) ));
			( win as global::Gtk.Widget ).ShowAll();
			global::Gtk.Application.Run();
		}
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Main_main_25__Fun : global::haxe.lang.Function {
	
	public Main_main_25__Fun() : base(2, 0) {
	}
	
	
	public static global::Main_main_25__Fun __hx_current;
	
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
public class Main_main_40__Fun : global::haxe.lang.Function {
	
	public Main_main_40__Fun() : base(2, 0) {
	}
	
	
	public static global::Main_main_40__Fun __hx_current;
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e1 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object obj = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(obj, e1);
		return null;
	}
	
	
	public void Delegate(object obj, global::System.EventArgs e1) {
		unchecked {
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "Exit", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"main", "Main", "Main.hx"}, new int[]{1981972957}, new double[]{((double) (40) )}));
		}
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Main_main_50__Fun : global::haxe.lang.Function {
	
	public Main_main_50__Fun() : base(2, 0) {
	}
	
	
	public static global::Main_main_50__Fun __hx_current;
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e2 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object obj1 = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(obj1, e2);
		return null;
	}
	
	
	public void Delegate(object obj1, global::System.EventArgs e2) {
		unchecked {
			global::haxe.Log.trace.__hx_invoke2_o(default(double), "new", default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"main", "Main", "Main.hx"}, new int[]{1981972957}, new double[]{((double) (50) )}));
		}
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Main_main_65__Fun : global::haxe.lang.Function {
	
	public Main_main_65__Fun(global::Gtk.CheckButton cb) : base(2, 0) {
		this.cb = cb;
	}
	
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e3 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object obj2 = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(obj2, e3);
		return null;
	}
	
	
	public void Delegate(object obj2, global::System.EventArgs e3) {
		unchecked {
			global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat("Checkbox: ", global::Std.@string(( this.cb as global::Gtk.ToggleButton ).Active)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"main", "Main", "Main.hx"}, new int[]{1981972957}, new double[]{((double) (65) )}));
		}
	}
	
	
	public global::Gtk.CheckButton cb;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Main_main_73__Fun : global::haxe.lang.Function {
	
	public Main_main_73__Fun(global::Gtk.ComboBox combo) : base(2, 0) {
		this.combo = combo;
	}
	
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e4 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object sender = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(sender, e4);
		return null;
	}
	
	
	public void Delegate(object sender, global::System.EventArgs e4) {
		unchecked {
			global::haxe.Log.trace.__hx_invoke2_o(default(double), global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("", this.combo.ActiveText), " "), global::haxe.lang.Runtime.toString(this.combo.Active)), default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"main", "Main", "Main.hx"}, new int[]{1981972957}, new double[]{((double) (73) )}));
		}
	}
	
	
	public global::Gtk.ComboBox combo;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Main_main_102__Fun : global::haxe.lang.Function {
	
	public Main_main_102__Fun(global::Gtk.Entry textEntry) : base(2, 0) {
		this.textEntry = textEntry;
	}
	
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e5 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object obj3 = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(obj3, e5);
		return null;
	}
	
	
	public void Delegate(object obj3, global::System.EventArgs e5) {
		unchecked {
			global::haxe.Log.trace.__hx_invoke2_o(default(double), this.textEntry.Text, default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"main", "Main", "Main.hx"}, new int[]{1981972957}, new double[]{((double) (103) )}));
		}
	}
	
	
	public global::Gtk.Entry textEntry;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Main_main_110__Fun : global::haxe.lang.Function {
	
	public Main_main_110__Fun(global::Gtk.ListStore store, global::Gtk.Entry textEntry) : base(2, 0) {
		this.store = store;
		this.textEntry = textEntry;
	}
	
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e6 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object obj4 = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(obj4, e6);
		return null;
	}
	
	
	public void Delegate(object obj4, global::System.EventArgs e6) {
		string text = this.textEntry.Text;
		if ((  ! (string.Equals(text, null))  && ( text.Length > 0 ) )) {
			this.store.AppendValues(((object[]) (new string[]{text, text.ToUpperInvariant()}) ));
		}
		
	}
	
	
	public global::Gtk.ListStore store;
	
	public global::Gtk.Entry textEntry;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Main_main_118__Fun : global::haxe.lang.Function {
	
	public Main_main_118__Fun(global::Gtk.ListStore store, global::Gtk.TreeView list) : base(2, 0) {
		this.store = store;
		this.list = list;
	}
	
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e7 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object obj5 = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(obj5, e7);
		return null;
	}
	
	
	public void Delegate(object obj5, global::System.EventArgs e7) {
		global::Gtk.TreeSelection selection = this.list.Selection;
		global::Gtk.TreePath[] rows = selection.GetSelectedRows();
		{
			int _g1 = 0;
			int _g = ( rows as global::System.Array ).Length;
			while (( _g1 < _g )) {
				int i = _g1++;
				global::Gtk.TreeIter iter = default(global::Gtk.TreeIter);
				this.store.GetIter(out iter, ((global::Gtk.TreePath) (rows[i]) ));
				string label = global::haxe.lang.Runtime.toString(this.store.GetValue(((global::Gtk.TreeIter) (iter) ), ((int) (0) )));
				this.store.Remove(ref iter);
			}
			
		}
		
	}
	
	
	public global::Gtk.ListStore store;
	
	public global::Gtk.TreeView list;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Main_main_133__Fun : global::haxe.lang.Function {
	
	public Main_main_133__Fun(global::Gtk.Window win) : base(2, 0) {
		this.win = win;
	}
	
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e8 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object obj6 = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(obj6, e8);
		return null;
	}
	
	
	public void Delegate(object obj6, global::System.EventArgs e8) {
		global::Gtk.MessageDialog dialog = new global::Gtk.MessageDialog(this.win, global::Gtk.DialogFlags.Modal, global::Gtk.MessageType.Error, global::Gtk.ButtonsType.Close, "Hey", new object[0]);
		( dialog as global::Gtk.Window ).Title = ((string) ("Hello Message!") );
		global::Gtk.ResponseType response = ((global::Gtk.ResponseType) (((object) (( dialog as global::Gtk.Dialog ).Run()) )) );
		if (( ( response == global::Gtk.ResponseType.Close ) || ( response == global::Gtk.ResponseType.DeleteEvent ) )) {
			( dialog as global::Gtk.Object ).Destroy();
		}
		
	}
	
	
	public global::Gtk.Window win;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Main_main_148__Fun : global::haxe.lang.Function {
	
	public Main_main_148__Fun() : base(2, 0) {
	}
	
	
	public static global::Main_main_148__Fun __hx_current;
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e9 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object obj7 = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(obj7, e9);
		return null;
	}
	
	
	public void Delegate(object obj7, global::System.EventArgs e9) {
		unchecked {
			global::System.Drawing.Bitmap bitmap = new global::System.Drawing.Bitmap(((int) (200) ), ((int) (200) ));
			global::System.Drawing.Graphics gr = global::System.Drawing.Graphics.FromImage(((global::System.Drawing.Image) (bitmap) ));
			gr.FillRectangle(((global::System.Drawing.Brush) (global::System.Drawing.Brushes.White) ), ((global::System.Drawing.RectangleF) (new global::System.Drawing.RectangleF(((float) (0) ), ((float) (0) ), ((float) (200) ), ((float) (200) ))) ));
			gr.Save();
			( bitmap as global::System.Drawing.Image ).Save(((string) ("test.png") ));
		}
	}
	
	
}


