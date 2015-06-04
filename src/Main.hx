package ;

import cs.Lib;
import cs.NativeArray;
import cs.Out;
import gtk.Application;
import gtk.Window;
import gtk.Button;


/**
 * ...
 * @author 
 */
@:nativeGen class Main 
{
	static public function main() 
	{
		Application.Init();
		
		var win = new Window("Haxe, C# and GTK");
		win.SetDefaultSize(600, 400);
		win.SetPosition(gtk.WindowPosition.Center);
		
		win.add_DeleteEvent(new gtk.DeleteEventHandler(function(t:Dynamic, e:gtk.DeleteEventArgs) { 
			Application.Quit();
			e.set_RetVal(true);
		} ));
		
		var vboxOuter:gtk.VBox = new gtk.VBox(false, 2);
		win.Add(vboxOuter);		
		
		var menubar:gtk.MenuBar = new gtk.MenuBar();
		var filemenu:gtk.Menu = new gtk.Menu();
		
		var file:gtk.MenuItem = new gtk.MenuItem("File");
		file.Submenu = filemenu;
		var exit:gtk.MenuItem = new gtk.MenuItem('Exit');
		filemenu.Append(exit);
		exit.add_Activated(new cs.system.EventHandler(function(obj:Dynamic, e:cs.system.EventArgs) { 	trace('Exit'); }));
		menubar.Append(file);
		vboxOuter.PackStart(menubar, false, false, 0);		
		
		var upper:gtk.Toolbar = new gtk.Toolbar();
		upper.ToolbarStyle = gtk.ToolbarStyle.Icons;
		
		var newtb = new gtk.ToolButton(gtk.Stock.New);
		var opentb = new gtk.ToolButton(gtk.Stock.Open);
		var savetb = new gtk.ToolButton(gtk.Stock.Save);
		newtb.add_Clicked(new cs.system.EventHandler(function(obj:Dynamic, e:cs.system.EventArgs) { 	trace('new'); }));
		
		upper.Insert(newtb, 0);
		upper.Insert(opentb, 1);
		upper.Insert(savetb, 2);
		vboxOuter.PackStart(upper, false, false, 0);

		var hboxInner:gtk.HBox = new gtk.HBox(false, 2);
		vboxOuter.Add(hboxInner);		
		
		var vbox1:gtk.VBox = new gtk.VBox();
		hboxInner.Add(vbox1);
		// CheckButton
		var cb:gtk.CheckButton = new gtk.CheckButton("I'm a checkbutton");
		cb.Active = true;
		cb.add_Clicked(new cs.system.EventHandler(function(obj:Dynamic, e:cs.system.EventArgs) { trace('Checkbox: ' + Std.string(cb.Active));  } ));
		vbox1.PackStart(cb, false, false, 0);
		
		// ComboBox
		var items = NativeArray.make('Ferrari', 'Lamborghini', 'Porsche', 'Koenigsegg');
		var combo = new gtk.ComboBox(items);
		vbox1.PackStart(combo, false, false, 0);
		combo.Active = 3; // Koenigsegg rules!
		combo.add_Changed(new cs.system.EventHandler(function(sender:Dynamic, e:cs.system.EventArgs) { trace('${combo.ActiveText} ${combo.Active}');	} ));
		

		// List (TreeView)
		var list:gtk.TreeView = new gtk.TreeView();
		vbox1.PackStart(list, true, true, 8);
		
		// List columns
		var columnA:gtk.TreeViewColumn = new gtk.TreeViewColumn();
		columnA.Title = 'Column A';
		var cellA:gtk.CellRendererText = new gtk.CellRendererText();
		columnA.PackStart(cellA, true);
		var columnB:gtk.TreeViewColumn = new gtk.TreeViewColumn();
		columnB.Title = 'Column B';
		var cellB:gtk.CellRendererText = new gtk.CellRendererText();
		columnB.PackStart(cellB, true);
		list.AppendColumn(columnA);
		list.AppendColumn(columnB);		
		columnA.AddAttribute(cellA, "text", 0);
		columnB.AddAttribute(cellB, "text", 0);
		
		// ListStore (model for the list)
		var store:gtk.ListStore = new gtk.ListStore(NativeArray.make(Lib.toNativeType(String), Lib.toNativeType(String)));
		store.AppendValues(NativeArray.make('Item1', 'ItemA'));
		list.Model = store;

		// Textfield
		var textEntry:gtk.Entry = new gtk.Entry();
		textEntry.Text = 'Hello world';
		textEntry.add_Changed(new cs.system.EventHandler(function(obj:Dynamic, e:cs.system.EventArgs) {
			trace(textEntry.get_Text());
		}));
		vbox1.PackStart(textEntry, false, false, 2);
		
		
		var btnListAdd = new gtk.Button();
		btnListAdd.Label = 'Add';
		btnListAdd.add_Clicked(new cs.system.EventHandler(function(obj:Dynamic, e:cs.system.EventArgs) {
			var text = textEntry.get_Text();
			if (text != null && text.length > 0) store.AppendValues(NativeArray.make(text, text.toUpperCase()));
		}));                                                                                                                           
		vbox1.PackStart(btnListAdd, false, false, 8);
		
		var btnListDelete = new gtk.Button();
		btnListDelete.Label = 'Delete';
		btnListDelete.add_Clicked(new cs.system.EventHandler(function(obj:Dynamic, e:cs.system.EventArgs) {
			var selection:gtk.TreeSelection = list.get_Selection();
			var rows:NativeArray<gtk.TreePath> = selection.GetSelectedRows();
			for (i in 0 ... rows.Length) {
				var iter:gtk.TreeIter = null;
				store.GetIter(iter, rows[i]);
				var label:String = store.GetValue(iter, 0);
				store.Remove(iter);
			}
		}));
		vbox1.PackStart(btnListDelete, false, false, 2);

		// MessageDialog
		var btnMessageDialog = new gtk.Button();
		btnMessageDialog.Label = 'Message dialog';		
		btnMessageDialog.add_Clicked(new cs.system.EventHandler(function(obj:Dynamic, e:cs.system.EventArgs) {
			var dialog:gtk.MessageDialog = new gtk.MessageDialog(win, gtk.DialogFlags.Modal, gtk.MessageType.Error, gtk.ButtonsType.Close, "Hey", new NativeArray(0));
			dialog.Title = 'Hello Message!';
			var response:gtk.ResponseType = cast dialog.Run();
			if (response == gtk.ResponseType.Close || response == gtk.ResponseType.DeleteEvent) dialog.Destroy();
		}));
		
		vbox1.PackStart(btnMessageDialog, false, false, 2);
		
		var vbox2:gtk.VBox = new gtk.VBox();
		hboxInner.Add(vbox2);		
		
		// Button
		var btn = new Button();
		btn.Label = 'Create test.png';
		btn.add_Clicked(new cs.system.EventHandler(function(obj:Dynamic,e:cs.system.EventArgs) {
			var bitmap:cs.system.drawing.Bitmap = new cs.system.drawing.Bitmap(200, 200);
			var gr:cs.system.drawing.Graphics = cs.system.drawing.Graphics.FromImage(bitmap);
			
			gr.FillRectangle(cs.system.drawing.Brushes.White, new cs.system.drawing.RectangleF(0, 0, 200, 200));
			//gr.FillEllipse(cs.system.drawing.Brushes.Red, new cs.system.drawing.RectangleF(0, 0, 100, 100));
			
			gr.Save();
			bitmap.Save('test.png');
		}));
		vbox2.PackStart(btn, false, false, 0);		
		
		// Image
		var pixbuf:gdk.Pixbuf = null;
		try {
			pixbuf = new gdk.Pixbuf('test.png');
		} catch (e:Dynamic) {
			trace('Image not found');
			cs.system.Environment.Exit(1);
		}
		var image = new gtk.Image(pixbuf);
		vbox2.Add(image);
		
		
		// ScrolledWindow
		var scrollwin:gtk.ScrolledWindow = new gtk.ScrolledWindow();
		var image:gtk.Image = new gtk.Image('paris.jpg');
		scrollwin.AddWithViewport(image);
		
		hboxInner.Add(scrollwin);
		
		win.ShowAll();
		
		Application.Run();
	}	
}