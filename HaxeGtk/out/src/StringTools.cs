
#pragma warning disable 109, 114, 219, 429, 168, 162
public class StringTools : global::haxe.lang.HxObject {
	
	public StringTools(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public StringTools() {
		global::StringTools.__hx_ctor__StringTools(this);
	}
	
	
	public static void __hx_ctor__StringTools(global::StringTools __temp_me8) {
	}
	
	
	public static string urlEncode(string s) {
		return global::System.Uri.EscapeUriString(((string) (s) ));
	}
	
	
	public static string urlDecode(string s) {
		return global::System.Uri.UnescapeDataString(((string) (s) ));
	}
	
	
	public static string htmlEscape(string s, global::haxe.lang.Null<bool> quotes) {
		s = global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(s, "&").@join("&amp;"), "<").@join("&lt;"), ">").@join("&gt;");
		if (((quotes)).@value) {
			return global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(s, "\"").@join("&quot;"), "\'").@join("&#039;");
		}
		else {
			return s;
		}
		
	}
	
	
	public static string htmlUnescape(string s) {
		return global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(global::haxe.lang.StringExt.split(s, "&gt;").@join(">"), "&lt;").@join("<"), "&quot;").@join("\""), "&#039;").@join("\'"), "&amp;").@join("&");
	}
	
	
	public static bool startsWith(string s, string start) {
		return s.StartsWith(start);
	}
	
	
	public static bool endsWith(string s, string end) {
		return s.EndsWith(end);
	}
	
	
	public static bool isSpace(string s, int pos) {
		unchecked {
			global::haxe.lang.Null<int> c = global::haxe.lang.StringExt.charCodeAt(s, pos);
			return ( ( ( (c).@value > 8 ) && ( (c).@value < 14 ) ) || global::haxe.lang.Runtime.eq((c).toDynamic(), 32) );
		}
	}
	
	
	public static string ltrim(string s) {
		return s.TrimStart();
	}
	
	
	public static string rtrim(string s) {
		return s.TrimEnd();
	}
	
	
	public static string trim(string s) {
		return s.Trim();
	}
	
	
	public static string lpad(string s, string c, int l) {
		if (( c.Length <= 0 )) {
			return s;
		}
		
		while (( s.Length < l )) {
			s = global::haxe.lang.Runtime.concat(c, s);
		}
		
		return s;
	}
	
	
	public static string rpad(string s, string c, int l) {
		if (( c.Length <= 0 )) {
			return s;
		}
		
		while (( s.Length < l )) {
			s = global::haxe.lang.Runtime.concat(s, c);
		}
		
		return s;
	}
	
	
	public static string replace(string s, string sub, string @by) {
		if (( sub.Length == 0 )) {
			return global::haxe.lang.StringExt.split(s, sub).@join(@by);
		}
		else {
			return s.Replace(sub, @by);
		}
		
	}
	
	
	public static string hex(int n, global::haxe.lang.Null<int> digits) {
		unchecked {
			string s = "";
			string hexChars = "0123456789ABCDEF";
			do {
				s = global::haxe.lang.Runtime.concat(global::haxe.lang.StringExt.charAt(hexChars, ( n & 15 )), s);
				n = ((int) (( ((uint) (n) ) >> 4 )) );
			}
			while (( n > 0 ));
			if (digits.hasValue) {
				while (( s.Length < (digits).@value )) {
					s = global::haxe.lang.Runtime.concat("0", s);
				}
				
			}
			
			return s;
		}
	}
	
	
	public static int fastCodeAt(string s, int index) {
		unchecked {
			if (((bool) (( ((uint) (index) ) < s.Length )) )) {
				return ((int) (s[index]) );
			}
			else {
				return -1;
			}
			
		}
	}
	
	
	public static bool isEof(int c) {
		unchecked {
			return ( c == -1 );
		}
	}
	
	
	public static new object __hx_createEmpty() {
		return new global::StringTools(global::haxe.lang.EmptyObject.EMPTY);
	}
	
	
	public static new object __hx_create(global::Array arr) {
		return new global::StringTools();
	}
	
	
}


