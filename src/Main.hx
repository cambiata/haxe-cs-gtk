package ;

import gtk.Application;
import gtk.Window;
import gtk.Button;
import gtk.DrawingArea;
import cairo.Context;
/**
 * ...
 * @author 
 */
class Main 
{
	static public function main() 
	{
		
		Application.Init();
		
		var win = new Window("Hello");
		win.Resize(200, 200);
		
		win.add_DeleteEvent(new gtk.DeleteEventHandler(function(t:Dynamic, e:gtk.DeleteEventArgs) { 
			Application.Quit();
			e.set_RetVal(true);
		} ));
		
		var drawing:gtk.DrawingArea = new gtk.DrawingArea();
		win.Add(drawing);
		drawing.Show();
		
		drawing.add_ExposeEvent(new gtk.ExposeEventHandler( function(t:Dynamic, e:gtk.ExposeEventArgs) {

			var context = gdk.CairoHelper.Create(drawing.GdkWindow);
			context.MoveTo(10,10);
			context.LineTo(100,10);
			context.LineTo(100,100);
			context.LineTo(10,100);
			context.LineTo(10,100);
			context.ClosePath();
			context.Color = new cairo.Color(0,0,0);
			context.FillPreserve();
			context.Color = new cairo.Color(1,0,0);
			context.Stroke();			
			/*
			*/
		}));
		
		var btn = new Button();
		btn.Label = 'Press me';
		btn.add_Clicked(new cs.system.EventHandler(function(obj:Dynamic,e:cs.system.EventArgs) {
			trace('Thanks!');
		}));
		
		trace('line');
		//win.Add(btn);
		
		win.ShowAll();
		
		Application.Run();
	}	
}
