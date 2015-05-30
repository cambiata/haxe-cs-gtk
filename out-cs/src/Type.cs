
#pragma warning disable 109, 114, 219, 429, 168, 162
public class ValueType : global::haxe.lang.ParamEnum {
	
	public ValueType(int index, object[] @params) : base(index, @params) {
	}
	
	
	public static readonly string[] __hx_constructs = new string[]{"TNull", "TInt", "TFloat", "TBool", "TObject", "TFunction", "TClass", "TEnum", "TUnknown"};
	
	public static readonly global::ValueType TNull = new global::ValueType(0, null);
	
	public static readonly global::ValueType TInt = new global::ValueType(1, null);
	
	public static readonly global::ValueType TFloat = new global::ValueType(2, null);
	
	public static readonly global::ValueType TBool = new global::ValueType(3, null);
	
	public static readonly global::ValueType TObject = new global::ValueType(4, null);
	
	public static readonly global::ValueType TFunction = new global::ValueType(5, null);
	
	public static global::ValueType TClass(global::System.Type c) {
		unchecked {
			return new global::ValueType(6, new object[]{c});
		}
	}
	
	
	public static global::ValueType TEnum(global::System.Type e) {
		unchecked {
			return new global::ValueType(7, new object[]{e});
		}
	}
	
	
	public static readonly global::ValueType TUnknown = new global::ValueType(8, null);
	
	public override string getTag() {
		return global::ValueType.__hx_constructs[this.index];
	}
	
	
}



#pragma warning disable 109, 114, 219, 429, 168, 162
public class Type : global::haxe.lang.HxObject {
	
	public Type(global::haxe.lang.EmptyObject empty) {
	}
	
	
	public Type() {
		global::Type.__hx_ctor__Type(this);
	}
	
	
	public static void __hx_ctor__Type(global::Type __temp_me9) {
	}
	
	
	public static global::System.Type getClass<T>(T o) {
		if (( ( global::System.Object.ReferenceEquals(((object) (o) ), ((object) (null) )) || ( o is global::haxe.lang.DynamicObject ) ) || ( o is global::System.Type ) )) {
			return null;
		}
		
		return o.GetType();
	}
	
	
	public static global::System.Type getEnum(object o) {
		if (( ( o is global::System.Enum ) || ( o is global::haxe.lang.Enum ) )) {
			return o.GetType();
		}
		
		return null;
	}
	
	
	public static global::System.Type getSuperClass(global::System.Type c) {
		global::System.Type t = ((global::System.Type) (c) );
		global::System.Type @base = t.BaseType;
		if (( ( global::haxe.lang.Runtime.typeEq(@base, null) || string.Equals(( @base as global::System.Reflection.MemberInfo ).ToString(), "haxe.lang.HxObject") ) || string.Equals(( @base as global::System.Reflection.MemberInfo ).ToString(), "System.Object") )) {
			return null;
		}
		
		return ((global::System.Type) (@base) );
	}
	
	
	public static string getClassName(global::System.Type c) {
		string ret = global::haxe.lang.Runtime.toString(((global::System.Type) (c) ));
		switch (ret) {
			case "System.Int32":
			{
				return "Int";
			}
			
			
			case "System.Double":
			{
				return "Float";
			}
			
			
			case "System.String":
			{
				return "String";
			}
			
			
			case "System.Object":
			{
				return "Dynamic";
			}
			
			
			case "System.Type":
			{
				return "Class";
			}
			
			
			default:
			{
				return global::haxe.lang.Runtime.toString(global::haxe.lang.StringExt.split(ret, "`")[0]);
			}
			
		}
		
	}
	
	
	public static string getEnumName(global::System.Type e) {
		unchecked {
			string ret = global::haxe.lang.Runtime.toString(((global::System.Type) (e) ));
			if (( ( ret.Length == 14 ) && string.Equals(ret, "System.Boolean") )) {
				return "Bool";
			}
			
			return ret;
		}
	}
	
	
	public static global::System.Type resolveClass(string name) {
		global::System.Type t = global::System.Type.GetType(((string) (name) ));
		if (global::haxe.lang.Runtime.typeEq(t, null)) {
			global::System.Collections.IEnumerator all = ( global::System.AppDomain.CurrentDomain.GetAssemblies() as global::System.Array ).GetEnumerator();
			while (all.MoveNext()) {
				global::System.Reflection.Assembly t2 = ((global::System.Reflection.Assembly) (all.Current) );
				t = t2.GetType(((string) (name) ));
				if ( ! (global::haxe.lang.Runtime.typeEq(t, null)) ) {
					break;
				}
				
			}
			
		}
		
		if (global::haxe.lang.Runtime.typeEq(t, null)) {
			switch (name) {
				case "Int":
				{
					return ((global::System.Type) (typeof(int)) );
				}
				
				
				case "Float":
				{
					return ((global::System.Type) (typeof(double)) );
				}
				
				
				case "Class":
				{
					return ((global::System.Type) (typeof(global::System.Type)) );
				}
				
				
				case "Dynamic":
				{
					return ((global::System.Type) (typeof(object)) );
				}
				
				
				case "String":
				{
					return ((global::System.Type) (typeof(string)) );
				}
				
				
				default:
				{
					return null;
				}
				
			}
			
		}
		else if (( t.IsInterface && (((global::System.Type) (typeof(global::haxe.lang.IGenericObject)) )).IsAssignableFrom(((global::System.Type) (t) )) )) {
			{
				object[] _this = ( t as global::System.Reflection.MemberInfo ).GetCustomAttributes(((bool) (true) ));
				object[] _g_arr = _this;
				uint _g_idx = ((uint) (0) );
				while (((bool) (( _g_idx < ( _g_arr as global::System.Array ).Length )) )) {
					object attr = ((object) (_g_arr[((int) (_g_idx++) )]) );
					global::haxe.lang.GenericInterface g = ((global::haxe.lang.GenericInterface) (( attr as global::haxe.lang.GenericInterface )) );
					if (( g != null )) {
						return ((global::System.Type) (g.generic) );
					}
					
				}
				
			}
			
			return ((global::System.Type) (t) );
		}
		else {
			return ((global::System.Type) (t) );
		}
		
	}
	
	
	public static global::System.Type resolveEnum(string name) {
		if (string.Equals(name, "Bool")) {
			return typeof(bool);
		}
		
		global::System.Type t = null;
		{
			global::System.Type cl = global::Type.resolveClass(name);
			t = cl;
		}
		
		if (( (  ! (global::haxe.lang.Runtime.typeEq(t, null))  && t.BaseType.Equals(((global::System.Type) (typeof(global::System.Enum)) )) ) || ((global::System.Type) (typeof(global::haxe.lang.Enum)) ).IsAssignableFrom(((global::System.Type) (t) )) )) {
			return t;
		}
		
		return null;
	}
	
	
	public static T createInstance<T>(global::System.Type cl, global::Array args) {
		if (global::haxe.lang.Runtime.refEq(cl, typeof(string))) {
			return global::haxe.lang.Runtime.genericCast<T>(args[0]);
		}
		
		global::System.Type t = ((global::System.Type) (cl) );
		if (t.IsInterface) {
			global::System.Type cl1 = global::Type.resolveClass(global::Type.getClassName(cl));
			t = cl1;
		}
		
		global::System.Reflection.ConstructorInfo[] ctors = t.GetConstructors();
		return global::haxe.lang.Runtime.genericCast<T>(global::haxe.lang.Runtime.callMethod(null, ((global::System.Reflection.MethodBase[]) (ctors) ), ( ctors as global::System.Array ).Length, args));
	}
	
	
	public static T createEmptyInstance<T>(global::System.Type cl) {
		unchecked {
			global::System.Type t = ((global::System.Type) (cl) );
			if (t.IsInterface) {
				global::System.Type cl1 = global::Type.resolveClass(global::Type.getClassName(cl));
				t = cl1;
			}
			
			if (global::Reflect.hasField(cl, "__hx_createEmpty")) {
				return global::haxe.lang.Runtime.genericCast<T>(global::haxe.lang.Runtime.callField(cl, "__hx_createEmpty", 2084789794, null));
			}
			
			if (global::haxe.lang.Runtime.refEq(cl, typeof(string))) {
				return global::haxe.lang.Runtime.genericCast<T>(((object) ("") ));
			}
			
			global::System.Type t1 = ((global::System.Type) (cl) );
			global::System.Reflection.ConstructorInfo[] ctors = t1.GetConstructors();
			{
				int _g1 = 0;
				int _g = ( ctors as global::System.Array ).Length;
				while (( _g1 < _g )) {
					int c = _g1++;
					if (( ( ( ctors[c] as global::System.Reflection.MethodBase ).GetParameters() as global::System.Array ).Length == 0 )) {
						global::System.Reflection.ConstructorInfo[] arr = new global::System.Reflection.ConstructorInfo[1];
						arr[0] = ctors[c];
						return global::haxe.lang.Runtime.genericCast<T>(global::haxe.lang.Runtime.callMethod(null, ((global::System.Reflection.MethodBase[]) (arr) ), ( arr as global::System.Array ).Length, new global::Array<object>(new object[]{})));
					}
					
				}
				
			}
			
			return global::haxe.lang.Runtime.genericCast<T>(global::System.Activator.CreateInstance(((global::System.Type) (t1) )));
		}
	}
	
	
	public static T createEnum<T>(global::System.Type e, string constr, global::Array @params) {
		if (( ( @params == null ) || ( @params[0] == null ) )) {
			T ret = global::haxe.lang.Runtime.genericCast<T>(global::haxe.lang.Runtime.slowGetField(e, constr, true));
			if (( ret is global::haxe.lang.Function )) {
				throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Constructor ", constr), " needs parameters"));
			}
			
			return ret;
		}
		else {
			return global::haxe.lang.Runtime.genericCast<T>(global::haxe.lang.Runtime.slowCallField(e, constr, @params));
		}
		
	}
	
	
	public static T createEnumIndex<T>(global::System.Type e, int index, global::Array @params) {
		global::Array<object> constr = global::Type.getEnumConstructs(e);
		return global::Type.createEnum<T>(e, global::haxe.lang.Runtime.toString(constr[index]), @params);
	}
	
	
	public static global::Array<object> getInstanceFields(global::System.Type c) {
		unchecked {
			if (global::haxe.lang.Runtime.refEq(c, typeof(string))) {
				return global::haxe.lang.StringRefl.fields;
			}
			
			global::System.Type c1 = ((global::System.Type) (c) );
			global::Array<object> ret = new global::Array<object>(new object[]{});
			global::System.Reflection.MemberInfo[] mis = c1.GetMembers(((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Instance) ) )) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) )) ));
			{
				int _g1 = 0;
				int _g = ( mis as global::System.Array ).Length;
				while (( _g1 < _g )) {
					int i = _g1++;
					global::System.Reflection.MemberInfo i1 = mis[i];
					if (( i1 is global::System.Reflection.PropertyInfo )) {
						continue;
					}
					
					string n = i1.Name;
					if ((  ! (n.StartsWith("__hx_"))  && ( (( (((bool) (( ((uint) (0) ) < n.Length )) )) ? (((int) (n[0]) )) : (-1) )) != 46 ) )) {
						switch (n) {
							case "Equals":
							case "ToString":
							case "GetHashCode":
							case "GetType":
							{
								break;
							}
							
							
							default:
							{
								ret.push(n);
								break;
							}
							
						}
						
					}
					
				}
				
			}
			
			return ret;
		}
	}
	
	
	public static global::Array<object> getClassFields(global::System.Type c) {
		if (global::System.Object.ReferenceEquals(((object) (c) ), ((object) (typeof(string)) ))) {
			return new global::Array<object>(new object[]{"fromCharCode"});
		}
		
		global::Array<object> ret = new global::Array<object>(new object[]{});
		global::System.Reflection.MemberInfo[] infos = ((global::System.Type) (c) ).GetMembers(((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Static) ) )) ));
		{
			int _g1 = 0;
			int _g = ( infos as global::System.Array ).Length;
			while (( _g1 < _g )) {
				int i = _g1++;
				string name = infos[i].Name;
				if ( ! (name.StartsWith("__hx_")) ) {
					ret.push(name);
				}
				
			}
			
		}
		
		return ret;
	}
	
	
	public static global::Array<object> getEnumConstructs(global::System.Type e) {
		if (global::Reflect.hasField(e, "__hx_constructs")) {
			global::Array<object> ret = new global::Array<object>(((object[]) (((string[]) (global::haxe.lang.Runtime.getField(e, "__hx_constructs", 1781145963, true)) )) ));
			return ret.copy();
		}
		
		{
			string[] native = global::System.Enum.GetNames(((global::System.Type) (e) ));
			return new global::Array<object>(((object[]) (native) ));
		}
		
	}
	
	
	public static global::ValueType @typeof(object v) {
		if (( v == null )) {
			return global::ValueType.TNull;
		}
		
		global::System.Type t = ((global::System.Type) (( v as global::System.Type )) );
		if ( ! (global::haxe.lang.Runtime.typeEq(t, null)) ) {
			return global::ValueType.TObject;
		}
		
		t = ((global::System.Type) (v.GetType()) );
		if (( t.IsEnum || ( v is global::haxe.lang.Enum ) )) {
			return global::ValueType.TEnum(((global::System.Type) (t) ));
		}
		
		if (t.IsValueType) {
			global::System.IConvertible vc = ((global::System.IConvertible) (v) );
			if (( vc != null )) {
				global::System.TypeCode _g = vc.GetTypeCode();
				switch (_g) {
					case global::System.TypeCode.Boolean:
					{
						return global::ValueType.TBool;
					}
					
					
					case global::System.TypeCode.Double:
					{
						double d = vc.ToDouble(((global::System.IFormatProvider) (null) ));
						if (( ( ( d >= global::System.Int32.MinValue ) && ( d <= global::System.Int32.MaxValue ) ) && ( d == vc.ToInt32(((global::System.IFormatProvider) (null) )) ) )) {
							return global::ValueType.TInt;
						}
						else {
							return global::ValueType.TFloat;
						}
						
					}
					
					
					case global::System.TypeCode.Int32:
					{
						return global::ValueType.TInt;
					}
					
					
					default:
					{
						return global::ValueType.TClass(((global::System.Type) (t) ));
					}
					
				}
				
			}
			else {
				return global::ValueType.TClass(((global::System.Type) (t) ));
			}
			
		}
		
		if (( v is global::haxe.lang.IHxObject )) {
			if (( v is global::haxe.lang.DynamicObject )) {
				return global::ValueType.TObject;
			}
			else if (( v is global::haxe.lang.Enum )) {
				return global::ValueType.TEnum(((global::System.Type) (t) ));
			}
			
			return global::ValueType.TClass(((global::System.Type) (t) ));
		}
		else if (( v is global::haxe.lang.Function )) {
			return global::ValueType.TFunction;
		}
		else {
			return global::ValueType.TClass(((global::System.Type) (t) ));
		}
		
	}
	
	
	public static bool enumEq<T>(T a, T b) {
		if (global::haxe.lang.Runtime.eq(a, default(T))) {
			return global::haxe.lang.Runtime.eq(b, default(T));
		}
		else if (global::haxe.lang.Runtime.eq(b, default(T))) {
			return false;
		}
		else {
			return a.Equals(b);
		}
		
	}
	
	
	public static string enumConstructor(object e) {
		if (( e is global::System.Enum )) {
			return global::haxe.lang.Runtime.concat(global::Std.@string(e), "");
		}
		else {
			return (((global::haxe.lang.Enum) (e) )).getTag();
		}
		
	}
	
	
	public static global::Array enumParameters(object e) {
		if (( e is global::System.Enum )) {
			return new global::Array<object>(new object[]{});
		}
		else {
			return (((global::haxe.lang.Enum) (e) )).getParams();
		}
		
	}
	
	
	public static int enumIndex(object e) {
		if (( e is global::System.Enum )) {
			global::System.Array values = global::System.Enum.GetValues(((global::System.Type) (global::cs.Lib.getNativeType(e)) ));
			return global::System.Array.IndexOf(((global::System.Array) (values) ), ((object) (e) ));
		}
		else {
			return (((global::haxe.lang.Enum) (e) )).index;
		}
		
	}
	
	
	public static global::Array<T> allEnums<T>(global::System.Type e) {
		global::Array<object> ctors = global::Type.getEnumConstructs(e);
		global::Array<T> ret = new global::Array<T>(new T[]{});
		{
			int _g = 0;
			while (( _g < ctors.length )) {
				string ctor = global::haxe.lang.Runtime.toString(ctors[_g]);
				 ++ _g;
				T v = global::haxe.lang.Runtime.genericCast<T>(global::Reflect.field(e, ctor));
				if (global::Std.@is(v, e)) {
					ret.push(v);
				}
				
			}
			
		}
		
		return ret;
	}
	
	
	public static new object __hx_createEmpty() {
		return new global::Type(global::haxe.lang.EmptyObject.EMPTY);
	}
	
	
	public static new object __hx_create(global::Array arr) {
		return new global::Type();
	}
	
	
}


