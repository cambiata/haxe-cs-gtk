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
@:nativeGen class Main 
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
		
		/*
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
		}));
		*/
		
		var btn = new Button();
		btn.Label = 'Press me';
		btn.add_Clicked(new cs.system.EventHandler(function(obj:Dynamic,e:cs.system.EventArgs) {
			trace('Thanks!');
		}));
		//win.Add(btn);
		
		
		var a:PrettyDrawing = new PrettyDrawing();
		
		var box:gtk.HBox = new gtk.HBox(true, 0);
		
		box.Add(a);
		box.Add(btn);
		
		win.Add(box);
		
		trace('line');
		
		win.ShowAll();
		
		var bitmap:cs.system.drawing.Bitmap = new cs.system.drawing.Bitmap(300, 300);
		var gr:cs.system.drawing.Graphics = cs.system.drawing.Graphics.FromImage(bitmap);
		gr.FillEllipse(cs.system.drawing.Brushes.Red, new cs.system.drawing.RectangleF(0, 0, 100, 100));
		var svg:svg.SvgDocument = svg.SvgDocument.Open('F:\\tiger.svg');
		svg.Draw(gr);
		
		gr.Save();
		bitmap.Save('test.png');
		
		/*
			Svg.SvgDocument svg = Svg.SvgDocument.FromSvg("F:\\tiger.svg");
			svg.Draw (gr);

			gr.Save ();
			bitmap.Save ("test.png", System.Drawing.Imaging.ImageFormat.Png);		
		*/
		
		Application.Run();
	}	
}

@:nativeGen class PrettyDrawing extends gtk.DrawingArea {
	public function new() {
		super();
		this.SetSizeRequest(200, 200);
	}
	
	@:overload @:protected override function OnExposeEvent(e: gdk.EventExpose):Bool {
		trace('PrettyDrawing redraw');
		var pen:cs.system.drawing.Pen = new cs.system.drawing.Pen(cs.system.drawing.Color.Blue);
		var g:cs.system.drawing.Graphics = gtk.dotnet.Graphics.FromDrawable(e.Window);
		g.DrawLine(pen, 0, 0, 100, 100);
		
		
		
		
		return true;
	}
	
}

/*
class PrettyGraphic : DrawingArea {

	public PrettyGraphic ()
	{
		SetSizeRequest (200, 200);
	}
			       
	protected override bool OnExposeEvent (Gdk.EventExpose args)
	{
		using (Graphics g = Gtk.DotNet.Graphics.FromDrawable (args.Window)){
			Pen p = new Pen (Color.Blue, 1.0f);

			for (int i = 0; i < 600; i += 60)
				for (int j = 0; j < 600; j += 60)
					g.DrawLine (p, i, 0, 0, j);
		}
		return true;
	}
}
*/