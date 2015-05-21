
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public interface IHxObject {
		
		bool __hx_deleteField(string field, int hash);
		
		object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck);
		
		double __hx_lookupField_f(string field, int hash, bool throwErrors);
		
		object __hx_lookupSetField(string field, int hash, object @value);
		
		double __hx_lookupSetField_f(string field, int hash, double @value);
		
		double __hx_setField_f(string field, int hash, double @value, bool handleProperties);
		
		object __hx_setField(string field, int hash, object @value, bool handleProperties);
		
		object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties);
		
		double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties);
		
		object __hx_invokeField(string field, int hash, global::Array dynargs);
		
		void __hx_getFields(global::Array<object> baseArr);
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class HxObject : global::haxe.lang.IHxObject {
		
		public HxObject(global::haxe.lang.EmptyObject empty) {
		}
		
		
		public HxObject() {
			global::haxe.lang.HxObject.__hx_ctor_haxe_lang_HxObject(this);
		}
		
		
		public static void __hx_ctor_haxe_lang_HxObject(global::haxe.lang.HxObject __temp_me12) {
		}
		
		
		public static object __hx_createEmpty() {
			return new global::haxe.lang.HxObject(global::haxe.lang.EmptyObject.EMPTY);
		}
		
		
		public static object __hx_create(global::Array arr) {
			return new global::haxe.lang.HxObject();
		}
		
		
		public virtual bool __hx_deleteField(string field, int hash) {
			return false;
		}
		
		
		public virtual object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck) {
			if (isCheck) {
				return global::haxe.lang.Runtime.undefined;
			}
			else if (throwErrors) {
				throw global::haxe.lang.HaxeException.wrap("Field not found.");
			}
			else {
				return null;
			}
			
		}
		
		
		public virtual double __hx_lookupField_f(string field, int hash, bool throwErrors) {
			if (throwErrors) {
				throw global::haxe.lang.HaxeException.wrap("Field not found or incompatible field type.");
			}
			else {
				return default(double);
			}
			
		}
		
		
		public virtual object __hx_lookupSetField(string field, int hash, object @value) {
			throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing.");
		}
		
		
		public virtual double __hx_lookupSetField_f(string field, int hash, double @value) {
			throw global::haxe.lang.HaxeException.wrap("Cannot access field for writing or incompatible type.");
		}
		
		
		public virtual double __hx_setField_f(string field, int hash, double @value, bool handleProperties) {
			switch (hash) {
				default:
				{
					return this.__hx_lookupSetField_f(field, hash, @value);
				}
				
			}
			
		}
		
		
		public virtual object __hx_setField(string field, int hash, object @value, bool handleProperties) {
			switch (hash) {
				default:
				{
					return this.__hx_lookupSetField(field, hash, @value);
				}
				
			}
			
		}
		
		
		public virtual object __hx_getField(string field, int hash, bool throwErrors, bool isCheck, bool handleProperties) {
			switch (hash) {
				default:
				{
					return this.__hx_lookupField(field, hash, throwErrors, isCheck);
				}
				
			}
			
		}
		
		
		public virtual double __hx_getField_f(string field, int hash, bool throwErrors, bool handleProperties) {
			switch (hash) {
				default:
				{
					return this.__hx_lookupField_f(field, hash, throwErrors);
				}
				
			}
			
		}
		
		
		public virtual object __hx_invokeField(string field, int hash, global::Array dynargs) {
			switch (hash) {
				default:
				{
					return ((global::haxe.lang.Function) (this.__hx_getField(field, hash, true, false, false)) ).__hx_invokeDynamic(dynargs);
				}
				
			}
			
		}
		
		
		public virtual void __hx_getFields(global::Array<object> baseArr) {
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class DynamicObject : global::haxe.lang.HxObject {
		
		public DynamicObject(global::haxe.lang.EmptyObject empty) : base(global::haxe.lang.EmptyObject.EMPTY) {
		}
		
		
		public DynamicObject() {
			global::haxe.lang.DynamicObject.__hx_ctor_haxe_lang_DynamicObject(((global::haxe.lang.DynamicObject) (this) ));
		}
		
		
		public DynamicObject(int[] __hx_hashes, object[] __hx_dynamics, int[] __hx_hashes_f, double[] __hx_dynamics_f) {
			global::haxe.lang.DynamicObject.__hx_ctor_haxe_lang_DynamicObject(((global::haxe.lang.DynamicObject) (this) ), ((int[]) (__hx_hashes) ), ((object[]) (__hx_dynamics) ), ((int[]) (__hx_hashes_f) ), ((double[]) (__hx_dynamics_f) ));
		}
		
		
		public static void __hx_ctor_haxe_lang_DynamicObject(global::haxe.lang.DynamicObject __temp_me14) {
			__temp_me14.__hx_hashes = new int[]{};
			__temp_me14.__hx_dynamics = new object[]{};
			__temp_me14.__hx_hashes_f = new int[]{};
			__temp_me14.__hx_dynamics_f = new double[]{};
		}
		
		
		public static void __hx_ctor_haxe_lang_DynamicObject(global::haxe.lang.DynamicObject __temp_me13, int[] __hx_hashes, object[] __hx_dynamics, int[] __hx_hashes_f, double[] __hx_dynamics_f) {
			__temp_me13.__hx_hashes = __hx_hashes;
			__temp_me13.__hx_dynamics = __hx_dynamics;
			__temp_me13.__hx_hashes_f = __hx_hashes_f;
			__temp_me13.__hx_dynamics_f = __hx_dynamics_f;
			__temp_me13.__hx_length = __hx_hashes.Length;
			__temp_me13.__hx_length_f = __hx_hashes_f.Length;
		}
		
		
		public static new object __hx_createEmpty() {
			return new global::haxe.lang.DynamicObject(global::haxe.lang.EmptyObject.EMPTY);
		}
		
		
		public static new object __hx_create(global::Array arr) {
			unchecked {
				return new global::haxe.lang.DynamicObject(((int[]) (arr[0]) ), ((object[]) (arr[1]) ), ((int[]) (arr[2]) ), ((double[]) (arr[3]) ));
			}
		}
		
		
		public virtual string toString() {
			global::haxe.lang.Function ts = ((global::haxe.lang.Function) (global::haxe.lang.Runtime.getField(this, "toString", 946786476, false)) );
			if (( ts != null )) {
				return global::haxe.lang.Runtime.toString(ts.__hx_invoke0_o());
			}
			
			global::System.Text.StringBuilder ret_b = new global::System.Text.StringBuilder();
			ret_b.Append(((string) ("{") ));
			bool first = true;
			{
				int _g = 0;
				global::Array<object> _g1 = global::Reflect.fields(this);
				while (( _g < _g1.length )) {
					string f = global::haxe.lang.Runtime.toString(_g1[_g]);
					 ++ _g;
					if (first) {
						first = false;
					}
					else {
						ret_b.Append(((string) (",") ));
					}
					
					ret_b.Append(((string) (" ") ));
					ret_b.Append(((string) (global::Std.@string(f)) ));
					ret_b.Append(((string) (" : ") ));
					{
						object x = global::Reflect.field(this, f);
						ret_b.Append(((string) (global::Std.@string(x)) ));
					}
					
				}
				
			}
			
			if ( ! (first) ) {
				ret_b.Append(((string) (" ") ));
			}
			
			ret_b.Append(((string) ("}") ));
			return ret_b.ToString();
		}
		
		
		public int[] __hx_hashes;
		
		public object[] __hx_dynamics;
		
		public int[] __hx_hashes_f;
		
		public double[] __hx_dynamics_f;
		
		public int __hx_length;
		
		public int __hx_length_f;
		
		public override bool __hx_deleteField(string field, int hash) {
			int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
			if (( res >= 0 )) {
				global::haxe.lang.FieldLookup.@remove<int>(this.__hx_hashes, this.__hx_length, res);
				global::haxe.lang.FieldLookup.@remove<object>(this.__hx_dynamics, this.__hx_length, res);
				this.__hx_length--;
				return true;
			}
			else {
				res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
				if (( res >= 0 )) {
					global::haxe.lang.FieldLookup.@remove<int>(this.__hx_hashes_f, this.__hx_length_f, res);
					global::haxe.lang.FieldLookup.@remove<double>(this.__hx_dynamics_f, this.__hx_length_f, res);
					this.__hx_length_f--;
					return true;
				}
				
			}
			
			return false;
		}
		
		
		public override object __hx_lookupField(string field, int hash, bool throwErrors, bool isCheck) {
			int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
			if (( res >= 0 )) {
				return this.__hx_dynamics[res];
			}
			else {
				res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
				if (( res >= 0 )) {
					return this.__hx_dynamics_f[res];
				}
				
			}
			
			if (isCheck) {
				return global::haxe.lang.Runtime.undefined;
			}
			else {
				return null;
			}
			
		}
		
		
		public override double __hx_lookupField_f(string field, int hash, bool throwErrors) {
			int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
			if (( res >= 0 )) {
				return this.__hx_dynamics_f[res];
			}
			else {
				res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
				if (( res >= 0 )) {
					return ((double) (global::haxe.lang.Runtime.toDouble(this.__hx_dynamics[res])) );
				}
				
			}
			
			return default(double);
		}
		
		
		public override object __hx_lookupSetField(string field, int hash, object @value) {
			int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
			if (( res >= 0 )) {
				return this.__hx_dynamics[res] = @value;
			}
			else {
				int res2 = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
				if (( res2 >= 0 )) {
					global::haxe.lang.FieldLookup.@remove<int>(this.__hx_hashes_f, this.__hx_length_f, res2);
					global::haxe.lang.FieldLookup.@remove<double>(this.__hx_dynamics_f, this.__hx_length_f, res2);
					this.__hx_length_f--;
				}
				
			}
			
			global::haxe.lang.FieldLookup.insert<int>(ref this.__hx_hashes, this.__hx_length,  ~ (res) , hash);
			global::haxe.lang.FieldLookup.insert<object>(ref this.__hx_dynamics, this.__hx_length,  ~ (res) , @value);
			this.__hx_length++;
			return @value;
		}
		
		
		public override double __hx_lookupSetField_f(string field, int hash, double @value) {
			int res = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes_f, this.__hx_length_f);
			if (( res >= 0 )) {
				return this.__hx_dynamics_f[res] = @value;
			}
			else {
				int res2 = global::haxe.lang.FieldLookup.findHash(hash, this.__hx_hashes, this.__hx_length);
				if (( res2 >= 0 )) {
					global::haxe.lang.FieldLookup.@remove<int>(this.__hx_hashes, this.__hx_length, res2);
					global::haxe.lang.FieldLookup.@remove<object>(this.__hx_dynamics, this.__hx_length, res2);
					this.__hx_length--;
				}
				
			}
			
			global::haxe.lang.FieldLookup.insert<int>(ref this.__hx_hashes_f, this.__hx_length_f,  ~ (res) , hash);
			global::haxe.lang.FieldLookup.insert<double>(ref this.__hx_dynamics_f, this.__hx_length_f,  ~ (res) , @value);
			this.__hx_length_f++;
			return @value;
		}
		
		
		public override void __hx_getFields(global::Array<object> baseArr) {
			{
				int i = default(int);
				{
					i = 0;
					while (( i < this.__hx_length )) {
						baseArr.push(global::haxe.lang.FieldLookup.lookupHash(this.__hx_hashes[i++]));
					}
					
				}
				
				{
					i = 0;
					while (( i < this.__hx_length_f )) {
						baseArr.push(global::haxe.lang.FieldLookup.lookupHash(this.__hx_hashes_f[i++]));
					}
					
				}
				
				base.__hx_getFields(baseArr);
			}
			
		}
		
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public interface IGenericObject : global::haxe.lang.IHxObject {
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class GenericInterface : global::System.Attribute {
		
		public GenericInterface(global::System.Type generic) : base() {
			this.generic = generic;
		}
		
		
		public readonly global::System.Type generic;
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class Enum {
		
		public Enum(int index) {
			this.index = index;
		}
		
		
		public readonly int index;
		
		public virtual string getTag() {
			throw global::haxe.lang.HaxeException.wrap("Not Implemented");
		}
		
		
		public virtual global::Array<object> getParams() {
			return new global::Array<object>(new object[]{});
		}
		
		
		public virtual string toString() {
			return this.getTag();
		}
		
		
		public override string ToString(){
			return this.toString();
		}
		
		
	}
}



#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public class ParamEnum : global::haxe.lang.Enum {
		
		public ParamEnum(int index, object[] @params) : base(index) {
			this.@params = @params;
		}
		
		
		public readonly object[] @params;
		
		public override global::Array<object> getParams() {
			if (( this.@params == null )) {
				return new global::Array<object>(new object[]{});
			}
			else {
				return new global::Array<object>(((object[]) (this.@params) ));
			}
			
		}
		
		
		public override string toString() {
			if (( ( this.@params == null ) || ( ( ((object[]) (this.@params) ) as global::System.Array ).Length == 0 ) )) {
				return this.getTag();
			}
			
			global::System.Text.StringBuilder ret_b = new global::System.Text.StringBuilder();
			{
				string x = this.getTag();
				ret_b.Append(((string) (global::Std.@string(x)) ));
			}
			
			ret_b.Append(((string) ("(") ));
			bool first = true;
			{
				int _g = 0;
				object[] _g1 = this.@params;
				while (( _g < ( ((object[]) (_g1) ) as global::System.Array ).Length )) {
					object p = ((object) (((object[]) (_g1) )[_g]) );
					 ++ _g;
					if (first) {
						first = false;
					}
					else {
						ret_b.Append(((string) (",") ));
					}
					
					{
						object x1 = p;
						ret_b.Append(((string) (global::Std.@string(x1)) ));
					}
					
				}
				
			}
			
			ret_b.Append(((string) (")") ));
			return ret_b.ToString();
		}
		
		
		public override bool Equals(object obj) {
			if (global::haxe.lang.Runtime.eq(obj, this)) {
				return true;
			}
			
			global::haxe.lang.ParamEnum obj1 = null;
			{
				object @value = obj;
				obj1 = ((global::haxe.lang.ParamEnum) (( @value as global::haxe.lang.ParamEnum )) );
			}
			
			bool ret = ( ( ( obj1 != null ) && global::Std.@is(obj1, global::Type.getClass<object>(this)) ) && ( obj1.index == this.index ) );
			if ( ! (ret) ) {
				return false;
			}
			
			if (( obj1.@params == this.@params )) {
				return true;
			}
			
			int len = 0;
			if (( ( ( obj1.@params == null ) || ( this.@params == null ) ) || ( (len = ( ((object[]) (this.@params) ) as global::System.Array ).Length) != ( ((object[]) (obj1.@params) ) as global::System.Array ).Length ) )) {
				return false;
			}
			
			{
				int _g = 0;
				while (( _g < len )) {
					int i = _g++;
					if ( ! (global::Type.enumEq<object>(((object) (((object[]) (obj1.@params) )[i]) ), ((object) (((object[]) (this.@params) )[i]) ))) ) {
						return false;
					}
					
				}
				
			}
			
			return true;
		}
		
		
		public override int GetHashCode() {
			unchecked {
				int h = 19;
				if (( this.@params != null )) {
					int _g = 0;
					object[] _g1 = this.@params;
					while (( _g < ( ((object[]) (_g1) ) as global::System.Array ).Length )) {
						object p = ((object) (((object[]) (_g1) )[_g]) );
						 ++ _g;
						h = ( h * 31 );
						if (( p != null )) {
							h += ((int) (global::haxe.lang.Runtime.toInt(p.GetHashCode())) );
						}
						
					}
					
				}
				
				h += this.index;
				return h;
			}
		}
		
		
	}
}


