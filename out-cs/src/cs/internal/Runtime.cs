
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class Runtime {
		
		
	public static object getField(haxe.lang.HxObject obj, string field, int fieldHash, bool throwErrors)
	{
		if (obj == null && !throwErrors) return null;
		return obj.__hx_getField(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, throwErrors, false, false);
	}

	public static double getField_f(haxe.lang.HxObject obj, string field, int fieldHash, bool throwErrors)
	{
		if (obj == null && !throwErrors) return 0.0;
		return obj.__hx_getField_f(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, throwErrors, false);
	}

	public static object setField(haxe.lang.HxObject obj, string field, int fieldHash, object value)
	{
		return obj.__hx_setField(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, value, false);
	}

	public static double setField_f(haxe.lang.HxObject obj, string field, int fieldHash, double value)
	{
		return obj.__hx_setField_f(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, value, false);
	}

	public static object callField(haxe.lang.HxObject obj, string field, int fieldHash, Array args)
	{
		return obj.__hx_invokeField(field, (fieldHash == 0) ? haxe.lang.FieldLookup.hash(field) : fieldHash, args);
	}
		public Runtime() {
		}
		
		
		public static readonly object undefined = ((object) (new global::System.Object()) );
		
		public static object closure(object obj, int hash, string field) {
			return new global::haxe.lang.Closure(obj, field, hash);
		}
		
		
		public static bool eq(object v1, object v2) {
			if (global::System.Object.ReferenceEquals(((object) (v1) ), ((object) (v2) ))) {
				return true;
			}
			
			if (( global::System.Object.ReferenceEquals(((object) (v1) ), ((object) (null) )) || global::System.Object.ReferenceEquals(((object) (v2) ), ((object) (null) )) )) {
				return false;
			}
			
			global::System.IConvertible v1c = ((global::System.IConvertible) (( v1 as global::System.IConvertible )) );
			if (( v1c != null )) {
				global::System.IConvertible v2c = ((global::System.IConvertible) (( v2 as global::System.IConvertible )) );
				if (( v2c == null )) {
					return false;
				}
				
				global::System.TypeCode t1 = v1c.GetTypeCode();
				global::System.TypeCode t2 = v2c.GetTypeCode();
				if (( t1 == t2 )) {
					return global::System.Object.Equals(((object) (v1c) ), ((object) (v2c) ));
				}
				
				if (( ( t1 == global::System.TypeCode.String ) || ( t2 == global::System.TypeCode.String ) )) {
					return false;
				}
				
				switch (t1) {
					case global::System.TypeCode.Decimal:
					{
						return v1c.ToDecimal(((global::System.IFormatProvider) (null) )).Equals(v2c.ToDecimal(((global::System.IFormatProvider) (null) )));
					}
					
					
					case global::System.TypeCode.UInt64:
					case global::System.TypeCode.Int64:
					case global::System.TypeCode.DateTime:
					{
						switch (t2) {
							case global::System.TypeCode.Decimal:
							{
								return v1c.ToDecimal(((global::System.IFormatProvider) (null) )).Equals(v2c.ToDecimal(((global::System.IFormatProvider) (null) )));
							}
							
							
							case global::System.TypeCode.UInt64:
							case global::System.TypeCode.Int64:
							case global::System.TypeCode.DateTime:
							case global::System.TypeCode.Double:
							case global::System.TypeCode.Single:
							{
								return ( v1c.ToUInt64(((global::System.IFormatProvider) (null) )) == v2c.ToUInt64(((global::System.IFormatProvider) (null) )) );
							}
							
							
							default:
							{
								return ( v1c.ToUInt64(((global::System.IFormatProvider) (null) )) == v2c.ToUInt64(((global::System.IFormatProvider) (null) )) );
							}
							
						}
						
					}
					
					
					case global::System.TypeCode.Double:
					case global::System.TypeCode.Single:
					{
						switch (t2) {
							case global::System.TypeCode.Decimal:
							{
								return v1c.ToDecimal(((global::System.IFormatProvider) (null) )).Equals(v2c.ToDecimal(((global::System.IFormatProvider) (null) )));
							}
							
							
							case global::System.TypeCode.UInt64:
							case global::System.TypeCode.Int64:
							case global::System.TypeCode.DateTime:
							{
								return ( v1c.ToUInt64(((global::System.IFormatProvider) (null) )) == v2c.ToUInt64(((global::System.IFormatProvider) (null) )) );
							}
							
							
							case global::System.TypeCode.Double:
							case global::System.TypeCode.Single:
							{
								return ( v1c.ToDouble(((global::System.IFormatProvider) (null) )) == v2c.ToDouble(((global::System.IFormatProvider) (null) )) );
							}
							
							
							default:
							{
								return ( v1c.ToDouble(((global::System.IFormatProvider) (null) )) == v2c.ToDouble(((global::System.IFormatProvider) (null) )) );
							}
							
						}
						
					}
					
					
					default:
					{
						switch (t2) {
							case global::System.TypeCode.Decimal:
							{
								return v1c.ToDecimal(((global::System.IFormatProvider) (null) )).Equals(v2c.ToDecimal(((global::System.IFormatProvider) (null) )));
							}
							
							
							case global::System.TypeCode.UInt64:
							case global::System.TypeCode.Int64:
							case global::System.TypeCode.DateTime:
							{
								return ( v1c.ToUInt64(((global::System.IFormatProvider) (null) )) == v2c.ToUInt64(((global::System.IFormatProvider) (null) )) );
							}
							
							
							case global::System.TypeCode.Double:
							case global::System.TypeCode.Single:
							{
								return ( v1c.ToDouble(((global::System.IFormatProvider) (null) )) == v2c.ToDouble(((global::System.IFormatProvider) (null) )) );
							}
							
							
							default:
							{
								return ( v1c.ToInt32(((global::System.IFormatProvider) (null) )) == v2c.ToInt32(((global::System.IFormatProvider) (null) )) );
							}
							
						}
						
					}
					
				}
				
			}
			
			global::System.ValueType v1v = ((global::System.ValueType) (( v1 as global::System.ValueType )) );
			if (( v1v != null )) {
				return v1.Equals(v2);
			}
			else {
				global::System.Type v1t = ((global::System.Type) (( v1 as global::System.Type )) );
				if (( v1t != null )) {
					global::System.Type v2t = ((global::System.Type) (( v2 as global::System.Type )) );
					if (( v2t != null )) {
						return global::haxe.lang.Runtime.typeEq(v1t, v2t);
					}
					
					return false;
				}
				
			}
			
			return false;
		}
		
		
		public static bool refEq(object v1, object v2) {
			if (( v1 is global::System.Type )) {
				return global::haxe.lang.Runtime.typeEq(((global::System.Type) (( v1 as global::System.Type )) ), ((global::System.Type) (( v2 as global::System.Type )) ));
			}
			
			return global::System.Object.ReferenceEquals(((object) (v1) ), ((object) (v2) ));
		}
		
		
		public static double toDouble(object obj) {
			if (( obj == null )) {
				return .0;
			}
			else if (( obj is double )) {
				return ((double) (obj) );
			}
			else {
				return ((global::System.IConvertible) (( obj as global::System.IConvertible )) ).ToDouble(((global::System.IFormatProvider) (null) ));
			}
			
		}
		
		
		public static int toInt(object obj) {
			if (( obj == null )) {
				return 0;
			}
			else if (( obj is int )) {
				return ((int) (obj) );
			}
			else {
				return ((global::System.IConvertible) (( obj as global::System.IConvertible )) ).ToInt32(((global::System.IFormatProvider) (null) ));
			}
			
		}
		
		
		public static bool isInt(object obj) {
			global::System.IConvertible cv1 = ((global::System.IConvertible) (( obj as global::System.IConvertible )) );
			if (( cv1 != null )) {
				global::System.TypeCode _g = cv1.GetTypeCode();
				switch (_g) {
					case global::System.TypeCode.Double:
					{
						double d = ((double) (obj) );
						return ( ( ( d >= global::System.Int32.MinValue ) && ( d <= global::System.Int32.MaxValue ) ) && ( d == ((int) (d) ) ) );
					}
					
					
					case global::System.TypeCode.UInt32:
					case global::System.TypeCode.Int32:
					{
						return true;
					}
					
					
					default:
					{
						return false;
					}
					
				}
				
			}
			
			return false;
		}
		
		
		public static bool isUInt(object obj) {
			global::System.IConvertible cv1 = ((global::System.IConvertible) (( obj as global::System.IConvertible )) );
			if (( cv1 != null )) {
				global::System.TypeCode _g = cv1.GetTypeCode();
				switch (_g) {
					case global::System.TypeCode.Double:
					{
						double d = ((double) (obj) );
						bool __temp_boolv4 = ((bool) (( d >= global::System.UInt32.MinValue )) );
						bool __temp_boolv3 = false;
						bool __temp_boolv2 = false;
						if (__temp_boolv4) {
							__temp_boolv3 = ((bool) (( d <= global::System.UInt32.MaxValue )) );
							if (__temp_boolv3) {
								{
									double _g1 = d;
									uint _g2 = default(uint);
									_g2 = ((uint) (d) );
									__temp_boolv2 = ((bool) (( _g2 == _g1 )) );
								}
								
							}
							
						}
						
						bool __temp_stmt1 = ( ( __temp_boolv4 && __temp_boolv3 ) && __temp_boolv2 );
						return __temp_stmt1;
					}
					
					
					case global::System.TypeCode.UInt32:
					{
						return true;
					}
					
					
					default:
					{
						return false;
					}
					
				}
				
			}
			
			return false;
		}
		
		
		public static int compare(object v1, object v2) {
			unchecked {
				if (global::System.Object.ReferenceEquals(((object) (v1) ), ((object) (v2) ))) {
					return 0;
				}
				
				if (global::System.Object.ReferenceEquals(((object) (v1) ), ((object) (null) ))) {
					return -1;
				}
				
				if (global::System.Object.ReferenceEquals(((object) (v2) ), ((object) (null) ))) {
					return 1;
				}
				
				global::System.IConvertible cv1 = ((global::System.IConvertible) (( v1 as global::System.IConvertible )) );
				if (( cv1 != null )) {
					global::System.IConvertible cv2 = ((global::System.IConvertible) (( v2 as global::System.IConvertible )) );
					if (( cv2 == null )) {
						throw new global::System.ArgumentException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot compare ", ( global::cs.Lib.getNativeType(v1) as global::System.Reflection.MemberInfo ).ToString()), " and "), ( global::cs.Lib.getNativeType(v2) as global::System.Reflection.MemberInfo ).ToString()));
					}
					
					{
						global::System.TypeCode _g = cv1.GetTypeCode();
						switch (_g) {
							case global::System.TypeCode.String:
							{
								if (( cv2.GetTypeCode() != global::System.TypeCode.String )) {
									throw new global::System.ArgumentException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot compare ", ( global::cs.Lib.getNativeType(v1) as global::System.Reflection.MemberInfo ).ToString()), " and "), ( global::cs.Lib.getNativeType(v2) as global::System.Reflection.MemberInfo ).ToString()));
								}
								
								string s1 = ((string) (( v1 as string )) );
								string s2 = ((string) (( v2 as string )) );
								return string.Compare(((string) (s1) ), ((string) (s2) ), ((global::System.StringComparison) (global::System.StringComparison.Ordinal) ));
							}
							
							
							case global::System.TypeCode.Double:
							{
								double d1 = ((double) (v1) );
								double d2 = cv2.ToDouble(((global::System.IFormatProvider) (null) ));
								if (( d1 < d2 )) {
									return -1;
								}
								else if (( d1 > d2 )) {
									return 1;
								}
								else {
									return 0;
								}
								
							}
							
							
							default:
							{
								double d1d = cv1.ToDouble(((global::System.IFormatProvider) (null) ));
								double d2d = cv2.ToDouble(((global::System.IFormatProvider) (null) ));
								if (( d1d < d2d )) {
									return -1;
								}
								else if (( d1d > d2d )) {
									return 1;
								}
								else {
									return 0;
								}
								
							}
							
						}
						
					}
					
				}
				
				global::System.IComparable c1 = ((global::System.IComparable) (( v1 as global::System.IComparable )) );
				global::System.IComparable c2 = ((global::System.IComparable) (( v2 as global::System.IComparable )) );
				if (( ( c1 == null ) || ( c2 == null ) )) {
					throw new global::System.ArgumentException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot compare ", ( global::cs.Lib.getNativeType(v1) as global::System.Reflection.MemberInfo ).ToString()), " and "), ( global::cs.Lib.getNativeType(v2) as global::System.Reflection.MemberInfo ).ToString()));
				}
				
				return c1.CompareTo(((object) (c2) ));
			}
		}
		
		
		public static object plus(object v1, object v2) {
			if (( ( v1 is string ) || ( v2 is string ) )) {
				return global::haxe.lang.Runtime.concat(global::Std.@string(v1), global::Std.@string(v2));
			}
			
			if (( v1 == null )) {
				if (( v2 == null )) {
					return null;
				}
				
				v1 = 0;
			}
			else if (( v2 == null )) {
				v2 = 0;
			}
			
			global::System.IConvertible cv1 = ((global::System.IConvertible) (( v1 as global::System.IConvertible )) );
			if (( cv1 != null )) {
				global::System.IConvertible cv2 = ((global::System.IConvertible) (( v2 as global::System.IConvertible )) );
				if (( cv2 == null )) {
					throw new global::System.ArgumentException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot dynamically add ", ( global::cs.Lib.getNativeType(v1) as global::System.Reflection.MemberInfo ).ToString()), " and "), ( global::cs.Lib.getNativeType(v2) as global::System.Reflection.MemberInfo ).ToString()));
				}
				
				return ( cv1.ToDouble(((global::System.IFormatProvider) (null) )) + cv2.ToDouble(((global::System.IFormatProvider) (null) )) );
			}
			
			throw new global::System.ArgumentException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot dynamically add ", global::Std.@string(v1)), " and "), global::Std.@string(v2)));
		}
		
		
		public static object slowGetField(object obj, string field, bool throwErrors) {
			if (( obj == null )) {
				if (throwErrors) {
					throw new global::System.NullReferenceException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot access field \'", field), "\' of null."));
				}
				else {
					return null;
				}
				
			}
			
			global::System.Type t = ((global::System.Type) (( obj as global::System.Type )) );
			global::System.Reflection.BindingFlags bf = default(global::System.Reflection.BindingFlags);
			if (( t == null )) {
				string s = ((string) (( obj as string )) );
				if ( ! (string.Equals(s, null)) ) {
					return global::haxe.lang.StringRefl.handleGetField(s, field, throwErrors);
				}
				
				t = ((global::System.Type) (obj.GetType()) );
				bf = ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Instance) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) )) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) )) );
			}
			else {
				if (( ( t == ((global::System.Type) (typeof(string)) ) ) && string.Equals(field, "fromCharCode") )) {
					return new global::haxe.lang.Closure(typeof(global::haxe.lang.StringExt), field, 0);
				}
				
				obj = null;
				bf = ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Static) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) )) );
			}
			
			global::System.Reflection.FieldInfo f = t.GetField(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
			if (( f != null )) {
				return global::haxe.lang.Runtime.unbox(f.GetValue(((object) (obj) )));
			}
			else {
				global::System.Reflection.PropertyInfo prop = t.GetProperty(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
				if (( prop == null )) {
					global::System.Reflection.MemberInfo[] m = t.GetMember(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
					if (( ( ( m as global::System.Array ).Length == 0 ) && (( string.Equals(field, "__get") || string.Equals(field, "__set") )) )) {
						m = t.GetMember(((string) (( (string.Equals(field, "__get")) ? ("get_Item") : ("set_Item") )) ), ((global::System.Reflection.BindingFlags) (bf) ));
					}
					
					if (( ( m as global::System.Array ).Length > 0 )) {
						return new global::haxe.lang.Closure(( (( obj != null )) ? (obj) : (t) ), field, 0);
					}
					else {
						if (t.IsCOMObject) {
							try {
								return t.InvokeMember(((string) (field) ), ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.GetProperty) ), ((global::System.Reflection.Binder) (null) ), ((object) (obj) ), ((object[]) (new object[0]) ));
							}
							catch (global::System.Exception e){
								global::haxe.lang.Exceptions.exception = e;
							}
							
							
						}
						
						if (throwErrors) {
							throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot access field \'", field), "\'."));
						}
						else {
							return null;
						}
						
					}
					
				}
				
				return global::haxe.lang.Runtime.unbox(prop.GetValue(((object) (obj) ), ((object[]) (null) )));
			}
			
		}
		
		
		public static bool slowHasField(object obj, string field) {
			if (( obj == null )) {
				return false;
			}
			
			global::System.Type t = ((global::System.Type) (( obj as global::System.Type )) );
			global::System.Reflection.BindingFlags bf = default(global::System.Reflection.BindingFlags);
			if (( t == null )) {
				string s = ((string) (( obj as string )) );
				if ( ! (string.Equals(s, null)) ) {
					return ( global::haxe.lang.StringRefl.handleGetField(s, field, false) != null );
				}
				
				t = ((global::System.Type) (obj.GetType()) );
				bf = ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Instance) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) )) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) )) );
			}
			else {
				if (( t == ((global::System.Type) (typeof(string)) ) )) {
					return string.Equals(field, "fromCharCode");
				}
				
				obj = null;
				bf = ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Static) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) )) );
			}
			
			global::System.Reflection.MemberInfo[] mi = t.GetMember(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
			return ( ( mi != null ) && ( ( mi as global::System.Array ).Length > 0 ) );
		}
		
		
		public static object slowSetField(object obj, string field, object @value) {
			if (( obj == null )) {
				throw new global::System.NullReferenceException(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Cannot access field \'", field), "\' of null."));
			}
			
			global::System.Type t = ((global::System.Type) (( obj as global::System.Type )) );
			global::System.Reflection.BindingFlags bf = default(global::System.Reflection.BindingFlags);
			if (( t == null )) {
				t = ((global::System.Type) (obj.GetType()) );
				bf = ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Instance) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) )) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) )) );
			}
			else {
				obj = null;
				bf = ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Static) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) )) );
			}
			
			global::System.Reflection.FieldInfo f = t.GetField(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
			if (( f != null )) {
				if (( f.FieldType as global::System.Reflection.MemberInfo ).ToString().StartsWith("haxe.lang.Null")) {
					@value = global::haxe.lang.Runtime.mkNullable(@value, f.FieldType);
				}
				
				if (( global::System.Object.ReferenceEquals(((global::System.Type) (typeof(global::System.Double)) ), ((object) (global::cs.Lib.getNativeType(@value)) )) &&  ! (global::System.Object.ReferenceEquals(((object) (t) ), ((object) (f.FieldType) )))  )) {
					global::System.IConvertible ic = ((global::System.IConvertible) (( @value as global::System.IConvertible )) );
					@value = ic.ToType(((global::System.Type) (f.FieldType) ), ((global::System.IFormatProvider) (null) ));
				}
				
				f.SetValue(((object) (obj) ), ((object) (@value) ));
				return @value;
			}
			else {
				global::System.Reflection.PropertyInfo prop = t.GetProperty(((string) (field) ), ((global::System.Reflection.BindingFlags) (bf) ));
				if (( prop == null )) {
					if (t.IsCOMObject) {
						try {
							return t.InvokeMember(((string) (field) ), ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.SetProperty) ), ((global::System.Reflection.Binder) (null) ), ((object) (obj) ), ((object[]) (new object[]{@value}) ));
						}
						catch (global::System.Exception e){
							global::haxe.lang.Exceptions.exception = e;
						}
						
						
					}
					
					throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Field \'", field), "\' not found for writing from Class "), global::Std.@string(t)));
				}
				
				if (( prop.PropertyType as global::System.Reflection.MemberInfo ).ToString().StartsWith("haxe.lang.Null")) {
					@value = global::haxe.lang.Runtime.mkNullable(@value, prop.PropertyType);
				}
				
				if (( global::System.Object.ReferenceEquals(((global::System.Type) (typeof(global::System.Double)) ), ((object) (global::cs.Lib.getNativeType(@value)) )) &&  ! (global::System.Object.ReferenceEquals(((object) (t) ), ((object) (f.FieldType) )))  )) {
					global::System.IConvertible ic1 = ((global::System.IConvertible) (( @value as global::System.IConvertible )) );
					@value = ic1.ToType(((global::System.Type) (f.FieldType) ), ((global::System.IFormatProvider) (null) ));
				}
				
				prop.SetValue(((object) (obj) ), ((object) (@value) ), ((object[]) (null) ));
				return @value;
			}
			
		}
		
		
		public static object callMethod(object obj, global::System.Reflection.MethodBase[] methods, int methodLength, global::Array args) {
			unchecked {
				if (( methodLength == 0 )) {
					throw global::haxe.lang.HaxeException.wrap("No available methods");
				}
				
				int length = ((int) (global::haxe.lang.Runtime.getField_f(args, "length", 520590566, true)) );
				object[] oargs = new object[length];
				global::System.Type[] ts = new global::System.Type[length];
				int[] rates = new int[( methods as global::System.Array ).Length];
				{
					int _g = 0;
					while (( _g < length )) {
						int i = _g++;
						oargs[i] = args[i];
						if (( args[i] != null )) {
							ts[i] = global::cs.Lib.getNativeType(args[i]);
						}
						
					}
					
				}
				
				int last = 0;
				if (( methodLength > 1 )) {
					{
						int _g1 = 0;
						while (( _g1 < methodLength )) {
							int i1 = _g1++;
							global::System.Reflection.ParameterInfo[] @params = methods[i1].GetParameters();
							if (( ( @params as global::System.Array ).Length != length )) {
								continue;
							}
							else {
								bool fits = true;
								int crate = 0;
								{
									int _g2 = 0;
									int _g11 = ( @params as global::System.Array ).Length;
									while (( _g2 < _g11 )) {
										int i2 = _g2++;
										global::System.Type param = @params[i2].ParameterType;
										string strParam = global::haxe.lang.Runtime.concat(global::Std.@string(param), "");
										if (( param.IsAssignableFrom(((global::System.Type) (ts[i2]) )) || ( ( ts[i2] == null ) &&  ! (param.IsValueType)  ) )) {
											continue;
										}
										else if (( strParam.StartsWith("haxe.lang.Null") || ( (( ( oargs[i2] == null ) || ( oargs[i2] is global::System.IConvertible ) )) && (((global::System.Type) (typeof(global::System.IConvertible)) )).IsAssignableFrom(((global::System.Type) (param) )) ) )) {
											crate++;
											continue;
										}
										else if ( ! (param.ContainsGenericParameters) ) {
											fits = false;
											break;
										}
										
									}
									
								}
								
								if (fits) {
									rates[last] = crate;
									methods[last++] = methods[i1];
								}
								
							}
							
						}
						
					}
					
					methodLength = last;
				}
				else if (( ( methodLength == 1 ) && ( ( methods[0].GetParameters() as global::System.Array ).Length != length ) )) {
					methodLength = 0;
				}
				
				if (( methodLength == 0 )) {
					throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat("Invalid calling parameters for method ", ( methods[0] as global::System.Reflection.MemberInfo ).Name));
				}
				
				double best = global::Math.POSITIVE_INFINITY;
				int bestMethod = 0;
				{
					int _g3 = 0;
					while (( _g3 < methodLength )) {
						int i3 = _g3++;
						if (( rates[i3] < best )) {
							bestMethod = i3;
							best = ((double) (rates[i3]) );
						}
						
					}
					
				}
				
				methods[0] = methods[bestMethod];
				global::System.Reflection.ParameterInfo[] params1 = methods[0].GetParameters();
				{
					int _g12 = 0;
					int _g4 = ( params1 as global::System.Array ).Length;
					while (( _g12 < _g4 )) {
						int i4 = _g12++;
						global::System.Type param1 = params1[i4].ParameterType;
						string strParam1 = global::haxe.lang.Runtime.concat(global::Std.@string(param1), "");
						object arg = oargs[i4];
						if (strParam1.StartsWith("haxe.lang.Null")) {
							oargs[i4] = global::haxe.lang.Runtime.mkNullable(arg, param1);
						}
						else if ((((global::System.Type) (typeof(global::System.IConvertible)) )).IsAssignableFrom(((global::System.Type) (param1) ))) {
							if (( arg == null )) {
								if (param1.IsValueType) {
									oargs[i4] = global::System.Activator.CreateInstance(((global::System.Type) (param1) ));
								}
								
							}
							else if ( ! (global::cs.Lib.getNativeType(arg).IsAssignableFrom(((global::System.Type) (param1) ))) ) {
								oargs[i4] = (((global::System.IConvertible) (arg) )).ToType(((global::System.Type) (param1) ), ((global::System.IFormatProvider) (null) ));
							}
							
						}
						
					}
					
				}
				
				if (( methods[0].ContainsGenericParameters && ( methods[0] is global::System.Reflection.MethodInfo ) )) {
					global::System.Reflection.MethodInfo m = ((global::System.Reflection.MethodInfo) (methods[0]) );
					global::System.Type[] tgs = ( m as global::System.Reflection.MethodBase ).GetGenericArguments();
					{
						int _g13 = 0;
						int _g5 = ( tgs as global::System.Array ).Length;
						while (( _g13 < _g5 )) {
							int i5 = _g13++;
							tgs[i5] = typeof(object);
						}
						
					}
					
					m = m.MakeGenericMethod(((global::System.Type[]) (tgs) ));
					object retg = ( m as global::System.Reflection.MethodBase ).Invoke(((object) (obj) ), ((object[]) (oargs) ));
					return global::haxe.lang.Runtime.unbox(retg);
				}
				
				global::System.Reflection.MethodBase m1 = methods[0];
				if (( ( obj == null ) && ( m1 is global::System.Reflection.ConstructorInfo ) )) {
					object ret = (((global::System.Reflection.ConstructorInfo) (m1) )).Invoke(((object[]) (oargs) ));
					return global::haxe.lang.Runtime.unbox(ret);
				}
				
				object ret1 = m1.Invoke(((object) (obj) ), ((object[]) (oargs) ));
				return global::haxe.lang.Runtime.unbox(ret1);
			}
		}
		
		
		public static object unbox(object dyn) {
			if (( ( dyn != null ) && (global::haxe.lang.Runtime.concat(global::Std.@string(global::cs.Lib.getNativeType(dyn)), "")).StartsWith("haxe.lang.Null") )) {
				return ((object) (global::haxe.lang.Runtime.callField(dyn, "toDynamic", 1705629508, null)) );
			}
			else {
				return dyn;
			}
			
		}
		
		
		public static object mkNullable(object obj, global::System.Type nullableType) {
			
		if (nullableType.ContainsGenericParameters)
			return haxe.lang.Null<object>.ofDynamic<object>(obj);
		return nullableType.GetMethod("_ofDynamic").Invoke(null, new object[] { obj });
	
		}
		
		
		public static object slowCallField(object obj, string field, global::Array args) {
			if (( string.Equals(field, "toString") && (( ( args == null ) || ( ((int) (global::haxe.lang.Runtime.getField_f(args, "length", 520590566, true)) ) == 0 ) )) )) {
				return obj.ToString();
			}
			
			if (( args == null )) {
				args = new global::Array<object>(new object[]{});
			}
			
			global::System.Reflection.BindingFlags bf = default(global::System.Reflection.BindingFlags);
			global::System.Type t = ((global::System.Type) (( obj as global::System.Type )) );
			if (( t == null )) {
				string s = ((string) (( obj as string )) );
				if ( ! (string.Equals(s, null)) ) {
					return global::haxe.lang.StringRefl.handleCallField(s, field, args);
				}
				
				t = obj.GetType();
				bf = ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Instance) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) )) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.FlattenHierarchy) ) )) );
			}
			else {
				if (( ( t == ((global::System.Type) (typeof(string)) ) ) && string.Equals(field, "fromCharCode") )) {
					return global::haxe.lang.StringExt.fromCharCode(global::haxe.lang.Runtime.toInt(args[0]));
				}
				
				obj = null;
				bf = ((global::System.Reflection.BindingFlags) (( ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Static) ) | ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.Public) ) )) );
			}
			
			global::System.Reflection.MethodBase[] mis = ((global::System.Reflection.MethodBase[]) (t.GetMethods(((global::System.Reflection.BindingFlags) (bf) ))) );
			int last = 0;
			{
				int _g1 = 0;
				int _g = ( mis as global::System.Array ).Length;
				while (( _g1 < _g )) {
					int i = _g1++;
					string name = ( mis[i] as global::System.Reflection.MemberInfo ).Name;
					if (string.Equals(name, field)) {
						mis[last++] = mis[i];
					}
					
				}
				
			}
			
			if (( ( last == 0 ) && (( string.Equals(field, "__get") || string.Equals(field, "__set") )) )) {
				if (string.Equals(field, "__get")) {
					field = "get_Item";
				}
				else {
					field = "set_Item";
				}
				
				{
					int _g11 = 0;
					int _g2 = ( mis as global::System.Array ).Length;
					while (( _g11 < _g2 )) {
						int i1 = _g11++;
						string name1 = ( mis[i1] as global::System.Reflection.MemberInfo ).Name;
						if (string.Equals(name1, field)) {
							mis[last++] = mis[i1];
						}
						
					}
					
				}
				
			}
			
			if (( ( last == 0 ) && t.IsCOMObject )) {
				object[] oargs = new object[((int) (global::haxe.lang.Runtime.getField_f(args, "length", 520590566, true)) )];
				{
					int _g12 = 0;
					int _g3 = ( oargs as global::System.Array ).Length;
					while (( _g12 < _g3 )) {
						int i2 = _g12++;
						oargs[i2] = args[i2];
					}
					
				}
				
				return t.InvokeMember(((string) (field) ), ((global::System.Reflection.BindingFlags) (global::System.Reflection.BindingFlags.InvokeMethod) ), ((global::System.Reflection.Binder) (null) ), ((object) (obj) ), ((object[]) (oargs) ));
			}
			
			if (( last == 0 )) {
				throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Method \"", field), "\" not found on type "), global::Std.@string(t)));
			}
			
			return global::haxe.lang.Runtime.callMethod(obj, mis, last, args);
		}
		
		
		public static object callField(object obj, string field, int fieldHash, global::Array args) {
			global::haxe.lang.HxObject hxObj = ((global::haxe.lang.HxObject) (( obj as global::haxe.lang.HxObject )) );
			if (( hxObj != null )) {
				return hxObj.__hx_invokeField(field, ( (( fieldHash == 0 )) ? (global::haxe.lang.FieldLookup.hash(field)) : (fieldHash) ), args);
			}
			
			return global::haxe.lang.Runtime.slowCallField(obj, field, args);
		}
		
		
		public static object getField(object obj, string field, int fieldHash, bool throwErrors) {
			global::haxe.lang.HxObject hxObj = ((global::haxe.lang.HxObject) (( obj as global::haxe.lang.HxObject )) );
			if (( hxObj != null )) {
				return hxObj.__hx_getField(field, ( (( fieldHash == 0 )) ? (global::haxe.lang.FieldLookup.hash(field)) : (fieldHash) ), throwErrors, false, false);
			}
			
			return global::haxe.lang.Runtime.slowGetField(obj, field, throwErrors);
		}
		
		
		public static double getField_f(object obj, string field, int fieldHash, bool throwErrors) {
			global::haxe.lang.HxObject hxObj = ((global::haxe.lang.HxObject) (( obj as global::haxe.lang.HxObject )) );
			if (( hxObj != null )) {
				return hxObj.__hx_getField_f(field, ( (( fieldHash == 0 )) ? (global::haxe.lang.FieldLookup.hash(field)) : (fieldHash) ), throwErrors, false);
			}
			
			return global::haxe.lang.Runtime.toDouble(global::haxe.lang.Runtime.slowGetField(obj, field, throwErrors));
		}
		
		
		public static object setField(object obj, string field, int fieldHash, object @value) {
			global::haxe.lang.HxObject hxObj = ((global::haxe.lang.HxObject) (( obj as global::haxe.lang.HxObject )) );
			if (( hxObj != null )) {
				return hxObj.__hx_setField(field, ( (( fieldHash == 0 )) ? (global::haxe.lang.FieldLookup.hash(field)) : (fieldHash) ), @value, false);
			}
			
			return global::haxe.lang.Runtime.slowSetField(obj, field, @value);
		}
		
		
		public static double setField_f(object obj, string field, int fieldHash, double @value) {
			global::haxe.lang.HxObject hxObj = ((global::haxe.lang.HxObject) (( obj as global::haxe.lang.HxObject )) );
			if (( hxObj != null )) {
				return hxObj.__hx_setField_f(field, ( (( fieldHash == 0 )) ? (global::haxe.lang.FieldLookup.hash(field)) : (fieldHash) ), @value, false);
			}
			
			return global::haxe.lang.Runtime.toDouble(global::haxe.lang.Runtime.slowSetField(obj, field, @value));
		}
		
		
		public static string toString(object obj) {
			if (( obj == null )) {
				return null;
			}
			
			if (( obj is bool )) {
				if (global::haxe.lang.Runtime.toBool((obj))) {
					return "true";
				}
				else {
					return "false";
				}
				
			}
			
			return obj.ToString();
		}
		
		
		public static bool typeEq(global::System.Type t1, global::System.Type t2) {
			if (( ( t1 == null ) || ( t2 == null ) )) {
				return ( t1 == t2 );
			}
			
			bool t1i = t1.IsInterface;
			bool t2i = t2.IsInterface;
			if (( t1i != t2i )) {
				if (t1i) {
					global::haxe.lang.GenericInterface g = global::haxe.lang.Runtime.getGenericAttr(t1);
					if (( g != null )) {
						t1 = g.generic;
					}
					
				}
				else {
					global::haxe.lang.GenericInterface g1 = global::haxe.lang.Runtime.getGenericAttr(t2);
					if (( g1 != null )) {
						t2 = g1.generic;
					}
					
				}
				
			}
			
			if (( ( t1.GetGenericArguments() as global::System.Array ).Length > 0 )) {
				t1 = t1.GetGenericTypeDefinition();
			}
			
			if (( ( t2.GetGenericArguments() as global::System.Array ).Length > 0 )) {
				t2 = t2.GetGenericTypeDefinition();
			}
			
			return global::System.Object.ReferenceEquals(((object) (t1) ), ((object) (t2) ));
		}
		
		
		public static global::haxe.lang.GenericInterface getGenericAttr(global::System.Type t) {
			{
				object[] _this = ( t as global::System.Reflection.MemberInfo ).GetCustomAttributes(((bool) (true) ));
				object[] _g_arr = _this;
				uint _g_idx = ((uint) (0) );
				while (((bool) (( _g_idx < ( _g_arr as global::System.Array ).Length )) )) {
					object attr = ((object) (_g_arr[((int) (_g_idx++) )]) );
					if (( attr is global::haxe.lang.GenericInterface )) {
						return ((global::haxe.lang.GenericInterface) (attr) );
					}
					
				}
				
			}
			
			return null;
		}
		
		
		public static To genericCast<To>(object obj) {
			
		if (obj is To)
			return (To) obj;
		else if (obj == null)
			return default(To);
		if (typeof(To) == typeof(double))
			return (To)(object) toDouble(obj);
		else if (typeof(To) == typeof(int))
			return (To)(object) toInt(obj);
		else if (typeof(To) == typeof(float))
			return (To)(object)(float)toDouble(obj);
		else if (typeof(To) == typeof(long))
			return (To)(object)(long)toDouble(obj);
		else
			return (To) obj;
	
		}
		
		
		public static string concat(string s1, string s2) {
			
		return (s1 == null ? "null" : s1) + (s2 == null ? "null" : s2);
	
		}
		
		
		public static bool toBool(object dyn) {
			if (( dyn == null )) {
				return false;
			}
			else {
				return (bool)dyn;
			}
			
		}
		
		
	}
}



namespace haxe.lang{
	public enum EmptyObject{
		EMPTY
	}
}


