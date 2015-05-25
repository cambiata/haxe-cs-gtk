
#pragma warning disable 109, 114, 219, 429, 168, 162
public class Std {
	
	public Std() {
	}
	
	
	public static bool @is(object v, object t) {
		if (( v == null )) {
			return global::haxe.lang.Runtime.eq(t, typeof(object));
		}
		
		if (( t == null )) {
			return false;
		}
		
		global::System.Type clt = ((global::System.Type) (t) );
		if (global::haxe.lang.Runtime.typeEq(clt, null)) {
			return false;
		}
		
		string name = global::haxe.lang.Runtime.toString(clt);
		switch (name) {
			case "System.Double":
			{
				return v is double || v is int;
			}
			
			
			case "System.Int32":
			{
				return haxe.lang.Runtime.isInt(v);
			}
			
			
			case "System.Boolean":
			{
				return v is bool;
			}
			
			
			case "System.Object":
			{
				return true;
			}
			
			
		}
		
		return clt.IsAssignableFrom(((global::System.Type) (global::cs.Lib.getNativeType(v)) ));
	}
	
	
	public static string @string(object s) {
		if (( s == null )) {
			return "null";
		}
		
		if (( s is bool )) {
			if (global::haxe.lang.Runtime.toBool(s)) {
				return "true";
			}
			else {
				return "false";
			}
			
		}
		
		return s.ToString();
	}
	
	
}


