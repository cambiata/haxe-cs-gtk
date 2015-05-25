
#pragma warning disable 109, 114, 219, 429, 168, 162
public class Reflect : global::haxe.lang.HxObject {
	
	public Reflect(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public Reflect() {
		global::Reflect.__hx_ctor__Reflect(this);
	}
	
	
	public static void __hx_ctor__Reflect(global::Reflect __temp_me7) {
	}
	
	
	public static bool hasField(object o, string field) {
		global::haxe.lang.IHxObject ihx = ((global::haxe.lang.IHxObject) (( o as global::haxe.lang.IHxObject )) );
		if (( ihx != null )) {
			return ( ihx.__hx_getField(field, global::haxe.lang.FieldLookup.hash(field), false, true, false) != global::haxe.lang.Runtime.undefined );
		}
		
		return global::haxe.lang.Runtime.slowHasField(o, field);
	}
	
	
	public static object field(object o, string field) {
		global::haxe.lang.IHxObject ihx = ((global::haxe.lang.IHxObject) (( o as global::haxe.lang.IHxObject )) );
		if (( ihx != null )) {
			return ihx.__hx_getField(field, global::haxe.lang.FieldLookup.hash(field), false, false, false);
		}
		
		return global::haxe.lang.Runtime.slowGetField(o, field, false);
	}
	
	
	public static void setField(object o, string field, object @value) {
		global::haxe.lang.IHxObject ihx = ((global::haxe.lang.IHxObject) (( o as global::haxe.lang.IHxObject )) );
		if (( ihx != null )) {
			ihx.__hx_setField(field, global::haxe.lang.FieldLookup.hash(field), @value, false);
		}
		else {
			global::haxe.lang.Runtime.slowSetField(o, field, @value);
		}
		
	}
	
	
	public static object getProperty(object o, string field) {
		global::haxe.lang.IHxObject ihx = ((global::haxe.lang.IHxObject) (( o as global::haxe.lang.IHxObject )) );
		if (( ihx != null )) {
			return ihx.__hx_getField(field, global::haxe.lang.FieldLookup.hash(field), false, false, true);
		}
		
		if (global::haxe.lang.Runtime.slowHasField(o, global::haxe.lang.Runtime.concat("get_", field))) {
			return global::haxe.lang.Runtime.slowCallField(o, global::haxe.lang.Runtime.concat("get_", field), null);
		}
		
		return global::haxe.lang.Runtime.slowGetField(o, field, false);
	}
	
	
	public static void setProperty(object o, string field, object @value) {
		global::haxe.lang.IHxObject ihx = ((global::haxe.lang.IHxObject) (( o as global::haxe.lang.IHxObject )) );
		if (( ihx != null )) {
			ihx.__hx_setField(field, global::haxe.lang.FieldLookup.hash(field), @value, true);
		}
		else if (global::haxe.lang.Runtime.slowHasField(o, global::haxe.lang.Runtime.concat("set_", field))) {
			global::haxe.lang.Runtime.slowCallField(o, global::haxe.lang.Runtime.concat("set_", field), new global::Array<object>(new object[]{@value}));
		}
		else {
			global::haxe.lang.Runtime.slowSetField(o, field, @value);
		}
		
	}
	
	
	public static object callMethod(object o, object func, global::Array args) {
		return (((global::haxe.lang.Function) (func) )).__hx_invokeDynamic(args);
	}
	
	
	public static global::Array<object> fields(object o) {
		global::haxe.lang.IHxObject ihx = ((global::haxe.lang.IHxObject) (( o as global::haxe.lang.IHxObject )) );
		if (( o != null )) {
			global::Array<object> ret = new global::Array<object>(new object[]{});
			ihx.__hx_getFields(ret);
			return ret;
		}
		else if (( o is global::System.Type )) {
			return global::Type.getClassFields(((global::System.Type) (o) ));
		}
		else {
			return global::Reflect.instanceFields(o.GetType());
		}
		
	}
	
	
	public static global::Array<object> instanceFields(global::System.Type c) {
		global::System.Type c1 = ((global::System.Type) (c) );
		global::Array<object> ret = new global::Array<object>(new object[]{});
		global::System.Reflection.FieldInfo[] mis = c1.GetFields(((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Instance) ) )) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) )) ));
		{
			int _g1 = 0;
			int _g = ( mis as global::System.Array ).Length;
			while (( _g1 < _g )) {
				int i = _g1++;
				global::System.Reflection.FieldInfo i1 = mis[i];
				ret.push(( i1 as global::System.Reflection.MemberInfo ).Name);
			}
			
		}
		
		return ret;
	}
	
	
	public static bool isFunction(object f) {
		return ( f is global::haxe.lang.Function );
	}
	
	
	public static int compare<T>(T a, T b) {
		return global::haxe.lang.Runtime.compare(a, b);
	}
	
	
	public static bool compareMethods(object f1, object f2) {
		if (global::haxe.lang.Runtime.eq(f1, f2)) {
			return true;
		}
		
		if (( ( f1 is global::haxe.lang.Closure ) && ( f2 is global::haxe.lang.Closure ) )) {
			global::haxe.lang.Closure f1c = ((global::haxe.lang.Closure) (f1) );
			global::haxe.lang.Closure f2c = ((global::haxe.lang.Closure) (f2) );
			return ( global::haxe.lang.Runtime.refEq(f1c.obj, f2c.obj) && string.Equals(f1c.field, f2c.field) );
		}
		
		return false;
	}
	
	
	public static bool isObject(object v) {
		return ( ( v != null ) &&  ! ((( ( ( v is global::haxe.lang.Enum ) || ( v is global::haxe.lang.Function ) ) || ( v is global::System.ValueType ) )))  );
	}
	
	
	public static bool isEnumValue(object v) {
		return ( ( v != null ) && (( ( v is global::haxe.lang.Enum ) || ( v is global::System.Enum ) )) );
	}
	
	
	public static bool deleteField(object o, string field) {
		global::haxe.lang.DynamicObject ihx = ((global::haxe.lang.DynamicObject) (( o as global::haxe.lang.DynamicObject )) );
		if (( ihx != null )) {
			return ihx.__hx_deleteField(field, global::haxe.lang.FieldLookup.hash(field));
		}
		
		return false;
	}
	
	
	public static T copy<T>(T o) {
		object o2 = new global::haxe.lang.DynamicObject(new int[]{}, new object[]{}, new int[]{}, new double[]{});
		{
			int _g = 0;
			global::Array<object> _g1 = global::Reflect.fields(o);
			while (( _g < _g1.length )) {
				string f = global::haxe.lang.Runtime.toString(_g1[_g]);
				 ++ _g;
				global::Reflect.setField(o2, f, global::Reflect.field(o, f));
			}
			
		}
		
		return global::haxe.lang.Runtime.genericCast<T>(o2);
	}
	
	
	public static object makeVarArgs(global::haxe.lang.Function f) {
		return new global::haxe.lang.VarArgsFunction(f);
	}
	
	
	public static new object __hx_createEmpty() {
		return new global::Reflect(global::haxe.lang.EmptyObject.EMPTY);
	}
	
	
	public static new object __hx_create(global::Array arr) {
		return new global::Reflect();
	}
	
	
}


