
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe {
	public class Log : global::haxe.lang.HxObject {
		
		static Log() {
			global::haxe.Log.trace = ( (( global::haxe.Log_Anon_45__Fun.__hx_current != null )) ? (global::haxe.Log_Anon_45__Fun.__hx_current) : (global::haxe.Log_Anon_45__Fun.__hx_current = ((global::haxe.Log_Anon_45__Fun) (new global::haxe.Log_Anon_45__Fun()) )) );
		}
		
		
		public Log(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public Log() {
			global::haxe.Log.__hx_ctor_haxe_Log(this);
		}
		
		
		public static void __hx_ctor_haxe_Log(global::haxe.Log __temp_me14) {
		}
		
		
		public static global::haxe.lang.Function trace;
		
		public static new object __hx_createEmpty() {
			return new global::haxe.Log(global::haxe.lang.EmptyObject.EMPTY);
		}
		
		
		public static new object __hx_create(global::Array arr) {
			return new global::haxe.Log();
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe {
	public class Log_Anon_45__Fun : global::haxe.lang.Function {
		
		public Log_Anon_45__Fun() : base(2, 0) {
		}
		
		
		public static global::haxe.Log_Anon_45__Fun __hx_current;
		
		public override object __hx_invoke2_o(double __fn_float1, object __fn_dyn1, double __fn_float2, object __fn_dyn2) {
			object infos = ( (( __fn_dyn2 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float2) )) : (( (( __fn_dyn2 == null )) ? (null) : (((object) (__fn_dyn2) )) )) );
			object v = ( (( __fn_dyn1 == global::haxe.lang.Runtime.undefined )) ? (((object) (__fn_float1) )) : (((object) (__fn_dyn1) )) );
			string str = null;
			if (( infos != null )) {
				str = global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.toString(global::haxe.lang.Runtime.getField(infos, "fileName", 1648581351, true)), ":"), global::haxe.lang.Runtime.toString(((int) (global::haxe.lang.Runtime.getField_f(infos, "lineNumber", 1981972957, true)) ))), ": "), global::Std.@string(v));
				if (( ((global::Array) (global::haxe.lang.Runtime.getField(infos, "customParams", 1830310359, true)) ) != null )) {
					str = global::haxe.lang.Runtime.concat(str, global::haxe.lang.Runtime.concat(",", ((global::Array) (global::haxe.lang.Runtime.getField(infos, "customParams", 1830310359, true)) ).@join(",")));
				}
				
			}
			else {
				str = global::haxe.lang.Runtime.toString(v);
			}
			
			global::System.Console.WriteLine(((string) (str) ));
			return null;
		}
		
		
	}
}


