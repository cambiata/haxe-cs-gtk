
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
			win.SetDefaultSize(((int) (300) ), ((int) (400) ));
			win.SetPosition(((global::Gtk.WindowPosition) (global::Gtk.WindowPosition.Center) ));
			global::Gtk.DeleteEventHandler __temp_stmt1 = null;
			{
				global::Gtk.DeleteEventHandler this1 = null;
				this1 = ((global::Gtk.DeleteEventHandler) (( (( global::Main_main_24__Fun.__hx_current != null )) ? (global::Main_main_24__Fun.__hx_current) : (global::Main_main_24__Fun.__hx_current = ((global::Main_main_24__Fun) (new global::Main_main_24__Fun()) )) ).Delegate) );
				__temp_stmt1 = ((global::Gtk.DeleteEventHandler) (this1) );
			}
			
			( win as global::Gtk.Widget ).DeleteEvent += ((global::Gtk.DeleteEventHandler) (__temp_stmt1) );
			global::Gtk.VBox vboxOuter = new global::Gtk.VBox(false, 2);
			( win as global::Gtk.Container ).Add(((global::Gtk.Widget) (vboxOuter) ));
			global::Gtk.MenuBar menubar = new global::Gtk.MenuBar();
			global::Gtk.Menu filemenu = new global::Gtk.Menu();
			global::Gtk.MenuItem file = new global::Gtk.MenuItem(((string) ("File") ));
			file.Submenu = ((global::Gtk.Widget) (filemenu) );
			global::Gtk.MenuItem exit = new global::Gtk.MenuItem(((string) ("Exit") ));
			( filemenu as global::Gtk.MenuShell ).Append(((global::Gtk.Widget) (exit) ));
			global::System.EventHandler __temp_stmt2 = null;
			{
				global::System.EventHandler this2 = null;
				this2 = ((global::System.EventHandler) (( (( global::Main_main_39__Fun.__hx_current != null )) ? (global::Main_main_39__Fun.__hx_current) : (global::Main_main_39__Fun.__hx_current = ((global::Main_main_39__Fun) (new global::Main_main_39__Fun()) )) ).Delegate) );
				__temp_stmt2 = ((global::System.EventHandler) (this2) );
			}
			
			exit.Activated += ((global::System.EventHandler) (__temp_stmt2) );
			( menubar as global::Gtk.MenuShell ).Append(((global::Gtk.Widget) (file) ));
			( vboxOuter as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (menubar) ), ((bool) (false) ), ((bool) (false) ), ((uint) (0) ));
			global::Gtk.Toolbar upper = new global::Gtk.Toolbar();
			upper.ToolbarStyle = ((global::Gtk.ToolbarStyle) (global::Gtk.ToolbarStyle.Icons) );
			global::Gtk.ToolButton newtb = new global::Gtk.ToolButton(((string) (global::Gtk.Stock.New) ));
			global::Gtk.ToolButton opentb = new global::Gtk.ToolButton(((string) (global::Gtk.Stock.Open) ));
			global::Gtk.ToolButton savetb = new global::Gtk.ToolButton(((string) (global::Gtk.Stock.Save) ));
			upper.Insert(((global::Gtk.ToolItem) (newtb) ), ((int) (0) ));
			upper.Insert(((global::Gtk.ToolItem) (opentb) ), ((int) (1) ));
			upper.Insert(((global::Gtk.ToolItem) (savetb) ), ((int) (2) ));
			( vboxOuter as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (upper) ), ((bool) (false) ), ((bool) (false) ), ((uint) (0) ));
			global::Gtk.Button btn = new global::Gtk.Button();
			btn.Label = ((string) ("Create test.png") );
			global::System.EventHandler __temp_stmt3 = null;
			{
				global::System.EventHandler this3 = null;
				this3 = ((global::System.EventHandler) (( (( global::Main_main_59__Fun.__hx_current != null )) ? (global::Main_main_59__Fun.__hx_current) : (global::Main_main_59__Fun.__hx_current = ((global::Main_main_59__Fun) (new global::Main_main_59__Fun()) )) ).Delegate) );
				__temp_stmt3 = ((global::System.EventHandler) (this3) );
			}
			
			btn.Clicked += ((global::System.EventHandler) (__temp_stmt3) );
			global::Gtk.TreeView list = new global::Gtk.TreeView();
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
			global::Gtk.VBox vbox = new global::Gtk.VBox();
			( vbox as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (btn) ), ((bool) (false) ), ((bool) (false) ), ((uint) (8) ));
			( vbox as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (list) ), ((bool) (true) ), ((bool) (true) ), ((uint) (8) ));
			global::Gtk.Entry textEntry = new global::Gtk.Entry();
			textEntry.Text = ((string) ("Hello world") );
			global::System.EventHandler __temp_stmt4 = null;
			{
				global::System.EventHandler this4 = null;
				this4 = ((global::System.EventHandler) (new global::Main_main_97__Fun(textEntry).Delegate) );
				__temp_stmt4 = ((global::System.EventHandler) (this4) );
			}
			
			textEntry.Changed += ((global::System.EventHandler) (__temp_stmt4) );
			( vbox as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (textEntry) ), ((bool) (false) ), ((bool) (false) ), ((uint) (2) ));
			global::Gtk.Button btnListAdd = new global::Gtk.Button();
			btnListAdd.Label = ((string) ("Add") );
			global::System.EventHandler __temp_stmt5 = null;
			{
				global::System.EventHandler this5 = null;
				this5 = ((global::System.EventHandler) (new global::Main_main_104__Fun(store, textEntry).Delegate) );
				__temp_stmt5 = ((global::System.EventHandler) (this5) );
			}
			
			btnListAdd.Clicked += ((global::System.EventHandler) (__temp_stmt5) );
			( vbox as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (btnListAdd) ), ((bool) (false) ), ((bool) (false) ), ((uint) (8) ));
			global::Gtk.Button btnListDelete = new global::Gtk.Button();
			btnListDelete.Label = ((string) ("Delete") );
			global::System.EventHandler __temp_stmt6 = null;
			{
				global::System.EventHandler this6 = null;
				this6 = ((global::System.EventHandler) (new global::Main_main_112__Fun(store, list).Delegate) );
				__temp_stmt6 = ((global::System.EventHandler) (this6) );
			}
			
			btnListDelete.Clicked += ((global::System.EventHandler) (__temp_stmt6) );
			( vbox as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (btnListDelete) ), ((bool) (false) ), ((bool) (false) ), ((uint) (2) ));
			global::Gtk.Button btnMessageDialog = new global::Gtk.Button();
			btnMessageDialog.Label = ((string) ("Message dialog") );
			global::System.EventHandler __temp_stmt7 = null;
			{
				global::System.EventHandler this7 = null;
				this7 = ((global::System.EventHandler) (new global::Main_main_126__Fun(win).Delegate) );
				__temp_stmt7 = ((global::System.EventHandler) (this7) );
			}
			
			btnMessageDialog.Clicked += ((global::System.EventHandler) (__temp_stmt7) );
			( vbox as global::Gtk.Box ).PackStart(((global::Gtk.Widget) (btnMessageDialog) ), ((bool) (false) ), ((bool) (false) ), ((uint) (2) ));
			( vboxOuter as global::Gtk.Container ).Add(((global::Gtk.Widget) (vbox) ));
			( win as global::Gtk.Widget ).ShowAll();
			global::Gtk.Application.Run();
		}
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Main_main_24__Fun : global::haxe.lang.Function {
	
	public Main_main_24__Fun() : base(2, 0) {
	}
	
	
	public static global::Main_main_24__Fun __hx_current;
	
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
public class Main_main_39__Fun : global::haxe.lang.Function {
	
	public Main_main_39__Fun() : base(2, 0) {
	}
	
	
	public static global::Main_main_39__Fun __hx_current;
	
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
public class Main_main_59__Fun : global::haxe.lang.Function {
	
	public Main_main_59__Fun() : base(2, 0) {
	}
	
	
	public static global::Main_main_59__Fun __hx_current;
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e2 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object obj1 = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(obj1, e2);
		return null;
	}
	
	
	public void Delegate(object obj1, global::System.EventArgs e2) {
		unchecked {
			global::System.Drawing.Bitmap bitmap = new global::System.Drawing.Bitmap(((int) (200) ), ((int) (200) ));
			global::System.Drawing.Graphics gr = global::System.Drawing.Graphics.FromImage(((global::System.Drawing.Image) (bitmap) ));
			gr.FillEllipse(((global::System.Drawing.Brush) (global::System.Drawing.Brushes.Red) ), ((global::System.Drawing.RectangleF) (new global::System.Drawing.RectangleF(((float) (0) ), ((float) (0) ), ((float) (100) ), ((float) (100) ))) ));
			gr.Save();
			( bitmap as global::System.Drawing.Image ).Save(((string) ("test.png") ));
		}
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Main_main_97__Fun : global::haxe.lang.Function {
	
	public Main_main_97__Fun(global::Gtk.Entry textEntry) : base(2, 0) {
		this.textEntry = textEntry;
	}
	
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e3 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object obj2 = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(obj2, e3);
		return null;
	}
	
	
	public void Delegate(object obj2, global::System.EventArgs e3) {
		unchecked {
			global::haxe.Log.trace.__hx_invoke2_o(default(double), this.textEntry.Text, default(double), new global::haxe.lang.DynamicObject(new int[]{302979532, 1547539107, 1648581351}, new object[]{"main", "Main", "Main.hx"}, new int[]{1981972957}, new double[]{((double) (98) )}));
		}
	}
	
	
	public global::Gtk.Entry textEntry;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Main_main_104__Fun : global::haxe.lang.Function {
	
	public Main_main_104__Fun(global::Gtk.ListStore store, global::Gtk.Entry textEntry) : base(2, 0) {
		this.store = store;
		this.textEntry = textEntry;
	}
	
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e4 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object obj3 = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(obj3, e4);
		return null;
	}
	
	
	public void Delegate(object obj3, global::System.EventArgs e4) {
		string text = this.textEntry.Text;
		if ((  ! (string.Equals(text, null))  && ( text.Length > 0 ) )) {
			this.store.AppendValues(((object[]) (new string[]{text, text.ToUpperInvariant()}) ));
		}
		
	}
	
	
	public global::Gtk.ListStore store;
	
	public global::Gtk.Entry textEntry;
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Main_main_112__Fun : global::haxe.lang.Function {
	
	public Main_main_112__Fun(global::Gtk.ListStore store, global::Gtk.TreeView list) : base(2, 0) {
		this.store = store;
		this.list = list;
	}
	
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e5 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object obj4 = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(obj4, e5);
		return null;
	}
	
	
	public void Delegate(object obj4, global::System.EventArgs e5) {
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
public class Main_main_126__Fun : global::haxe.lang.Function {
	
	public Main_main_126__Fun(global::Gtk.Window win) : base(2, 0) {
		this.win = win;
	}
	
	
	public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
		global::System.EventArgs e6 = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((global::System.EventArgs) (((object) (__fn_float2) )) )) : (((global::System.EventArgs) (__fn_dyn2) )) );
		object obj5 = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
		this.Delegate(obj5, e6);
		return null;
	}
	
	
	public void Delegate(object obj5, global::System.EventArgs e6) {
		global::Gtk.MessageDialog dialog = new global::Gtk.MessageDialog(this.win, global::Gtk.DialogFlags.Modal, global::Gtk.MessageType.Error, global::Gtk.ButtonsType.Close, "Hey", new object[0]);
		( dialog as global::Gtk.Window ).Title = ((string) ("Hello Message!") );
		global::Gtk.ResponseType response = ((global::Gtk.ResponseType) (((object) (( dialog as global::Gtk.Dialog ).Run()) )) );
		if (( ( response == global::Gtk.ResponseType.Close ) || ( response == global::Gtk.ResponseType.DeleteEvent ) )) {
			( dialog as global::Gtk.Object ).Destroy();
		}
		
	}
	
	
	public global::Gtk.Window win;
	
}


