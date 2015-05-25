package;

import gtk.Application;
import gtk.Window;
import gtk.Button;


@:nativeGen class Main 
{
	
	static function main() 
	{
		Application.Init();
		
		var win = new Window("Haxe, C# and GTK");
		win.Resize(600, 400);
		
		win.add_DeleteEvent(new gtk.DeleteEventHandler(function(t:Dynamic, e:gtk.DeleteEventArgs) { 
			Application.Quit();
			e.set_RetVal(true);
		} ));	
		
		var btn = new Button();
		btn.Label = 'Button';
		btn.add_Clicked(new cs.system.EventHandler(function(obj:Dynamic, e:cs.system.EventArgs) {
			trace('Hello world!');
		}));
		win.Add(btn);
		
		
		win.ShowAll();
		Application.Run();		
	}
	
}