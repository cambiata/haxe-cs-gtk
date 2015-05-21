package ;

import gtk.Application;
import gtk.Window;
import gtk.Button;

/**
 * ...
 * @author 
 */
class Main 
{
	static public function main() 
	{
		trace('dummy');
		
		Application.Init();
		
		var win = new Window("Hello");
		win.Resize(200, 200);
		
		var btn = new Button();
		btn.Label = 'Press me';
		btn.add_Clicked(new cs.system.EventHandler(function(obj:Dynamic,e:cs.system.EventArgs) {
			trace('Thanks!');
		}));
		
		win.Add(btn);
		
		win.ShowAll();
		
		Application.Run();
	}	
}
