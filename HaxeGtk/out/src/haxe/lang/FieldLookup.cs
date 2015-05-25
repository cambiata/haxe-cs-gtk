
#pragma warning disable 109, 114, 219, 429, 168, 162
namespace haxe.lang {
	public sealed class FieldLookup {
		
		#pragma warning disable 628
		static FieldLookup() {
			global::haxe.lang.FieldLookup.length = ( global::haxe.lang.FieldLookup.fieldIds as global::System.Array ).Length;
		}
		
		
		public FieldLookup() {
		}
		
		
		protected static int[] fieldIds = new int[]{105, 4745537, 4849249, 5393365, 5442204, 5594513, 76061764, 87367608, 302979532, 328878574, 359333139, 407283053, 452737314, 501039929, 520590566, 946786476, 1067353468, 1103412149, 1181037546, 1204816148, 1224901875, 1247875546, 1280845662, 1282943179, 1352786672, 1532710347, 1547539107, 1620824029, 1621420777, 1623148745, 1648581351, 1705629508, 1781145963, 1830310359, 1915412854, 1916009602, 1981972957, 2025055113, 2082663554, 2084789794, 2127021138};
		
		protected static string[] fields = new string[]{"i", "__a", "arr", "len", "map", "pop", "remove", "filter", "methodName", "iterator", "lastIndexOf", "hasNext", "reverse", "insert", "length", "toString", "splice", "copy", "join", "concat", "next", "push", "sort", "quicksort", "spliceVoid", "concatNative", "className", "__unsafe_get", "__unsafe_set", "indexOf", "fileName", "toDynamic", "__hx_constructs", "customParams", "__get", "__set", "lineNumber", "unshift", "shift", "__hx_createEmpty", "slice"};
		
		protected static int length;
		
		public static void addFields(int[] nids, string[] nfields) {
			int[] cids = global::haxe.lang.FieldLookup.fieldIds;
			string[] cfields = global::haxe.lang.FieldLookup.fields;
			int nlen = ( nids as global::System.Array ).Length;
			int clen = global::haxe.lang.FieldLookup.length;
			if (( ( nfields as global::System.Array ).Length != nlen )) {
				throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat(global::haxe.lang.Runtime.concat("Different fields length: ", global::haxe.lang.Runtime.toString(nlen)), " and "), global::haxe.lang.Runtime.toString(( nfields as global::System.Array ).Length)));
			}
			
			bool needsChange = false;
			{
				int[] _g_arr = nids;
				uint _g_idx = ((uint) (0) );
				while (((bool) (( _g_idx < ( _g_arr as global::System.Array ).Length )) )) {
					int i = ((int) (_g_arr[((int) (_g_idx++) )]) );
					if (( global::haxe.lang.FieldLookup.findHash(i, cids, clen) < 0 )) {
						needsChange = true;
						break;
					}
					
				}
				
			}
			
			if (needsChange) {
				lock(typeof(global::haxe.lang.FieldLookup)){
					int[] ansIds = new int[( clen + nlen )];
					string[] ansFields = new string[( clen + nlen )];
					int ci = 0;
					int ni = 0;
					int ansi = 0;
					while (( ( ci < clen ) && ( ni < nlen ) )) {
						if (( cids[ci] < nids[ni] )) {
							ansIds[ansi] = cids[ci];
							ansFields[ansi] = cfields[ci];
							 ++ ci;
						}
						else {
							ansIds[ansi] = nids[ni];
							ansFields[ansi] = nfields[ni];
							 ++ ni;
						}
						
						 ++ ansi;
					}
					
					if (( ci < clen )) {
						global::System.Array.Copy(((global::System.Array) (cids) ), ((int) (ci) ), ((global::System.Array) (ansIds) ), ((int) (ansi) ), ((int) (( clen - ci )) ));
						global::System.Array.Copy(((global::System.Array) (cfields) ), ((int) (ci) ), ((global::System.Array) (ansFields) ), ((int) (ansi) ), ((int) (( clen - ci )) ));
						ansi += ( clen - ci );
					}
					
					if (( ni < nlen )) {
						global::System.Array.Copy(((global::System.Array) (nids) ), ((int) (ni) ), ((global::System.Array) (ansIds) ), ((int) (ansi) ), ((int) (( nlen - ni )) ));
						global::System.Array.Copy(((global::System.Array) (nfields) ), ((int) (ni) ), ((global::System.Array) (ansFields) ), ((int) (ansi) ), ((int) (( nlen - ni )) ));
						ansi += ( nlen - ni );
					}
					
					global::haxe.lang.FieldLookup.fieldIds = ansIds;
					global::haxe.lang.FieldLookup.fields = ansFields;
					global::haxe.lang.FieldLookup.length = ansi;
				}
				;
			}
			
		}
		
		
		public static int doHash(string s) {
			unchecked {
				int acc = 0;
				{
					int _g1 = 0;
					int _g = s.Length;
					while (( _g1 < _g )) {
						int i = _g1++;
						acc = ( ( ( 223 * (( acc >> 1 )) ) + ((int) (s[i]) ) ) << 1 );
					}
					
				}
				
				return ((int) (( ((uint) (acc) ) >> 1 )) );
			}
		}
		
		
		public static string lookupHash(int key) {
			unchecked {
				int[] ids = global::haxe.lang.FieldLookup.fieldIds;
				int min = 0;
				int max = global::haxe.lang.FieldLookup.length;
				while (( min < max )) {
					int mid = ( min + ((int) (( (( max - min )) / 2 )) ) );
					int imid = ids[mid];
					if (( key < imid )) {
						max = mid;
					}
					else if (( key > imid )) {
						min = ( mid + 1 );
					}
					else {
						return global::haxe.lang.FieldLookup.fields[mid];
					}
					
				}
				
				throw global::haxe.lang.HaxeException.wrap(global::haxe.lang.Runtime.concat("Field not found for hash ", global::haxe.lang.Runtime.toString(key)));
			}
		}
		
		
		public static int hash(string s) {
			unchecked {
				if (string.Equals(s, null)) {
					return 0;
				}
				
				int key = default(int);
				{
					int acc = 0;
					{
						int _g1 = 0;
						int _g = s.Length;
						while (( _g1 < _g )) {
							int i = _g1++;
							acc = ( ( ( 223 * (( acc >> 1 )) ) + ((int) (s[i]) ) ) << 1 );
						}
						
					}
					
					key = ((int) (( ((uint) (acc) ) >> 1 )) );
				}
				
				int[] ids = global::haxe.lang.FieldLookup.fieldIds;
				string[] fld = global::haxe.lang.FieldLookup.fields;
				int min = 0;
				int max = global::haxe.lang.FieldLookup.length;
				int len = global::haxe.lang.FieldLookup.length;
				while (( min < max )) {
					int mid = ((int) (( min + ( ((double) ((( max - min ))) ) / 2 ) )) );
					int imid = ids[mid];
					if (( key < imid )) {
						max = mid;
					}
					else if (( key > imid )) {
						min = ( mid + 1 );
					}
					else {
						string field = fld[mid];
						if ( ! (string.Equals(field, s)) ) {
							return  ~ (key) ;
						}
						
						return key;
					}
					
				}
				
				lock(typeof(global::haxe.lang.FieldLookup)){
					if (( len != global::haxe.lang.FieldLookup.length )) {
						return global::haxe.lang.FieldLookup.hash(s);
					}
					
					global::haxe.lang.FieldLookup.insert<int>(ref global::haxe.lang.FieldLookup.fieldIds, global::haxe.lang.FieldLookup.length, min, key);
					global::haxe.lang.FieldLookup.insert<string>(ref global::haxe.lang.FieldLookup.fields, global::haxe.lang.FieldLookup.length, min, s);
					 ++ global::haxe.lang.FieldLookup.length;
				}
				;
				return key;
			}
		}
		
		
		public static int findHash(int hash, int[] hashs, int length) {
			unchecked {
				int min = 0;
				int max = length;
				while (( min < max )) {
					int mid = ((int) (( (( max + min )) / 2 )) );
					int imid = hashs[mid];
					if (( hash < imid )) {
						max = mid;
					}
					else if (( hash > imid )) {
						min = ( mid + 1 );
					}
					else {
						return mid;
					}
					
				}
				
				return  ~ (min) ;
			}
		}
		
		
		public static void @remove<T>(T[] a, int length, int pos) {
			unchecked {
				global::System.Array.Copy(((global::System.Array) (a) ), ((int) (( pos + 1 )) ), ((global::System.Array) (a) ), ((int) (pos) ), ((int) (( ( length - pos ) - 1 )) ));
				a[( length - 1 )] = default(T);
			}
		}
		
		
		public static void insert<T>(ref T[] a, int length, int pos, T x) {
			unchecked {
				int capacity = ( a as global::System.Array ).Length;
				if (( pos == length )) {
					if (( capacity == length )) {
						T[] newarr = new T[( (( length << 1 )) + 1 )];
						( a as global::System.Array ).CopyTo(((global::System.Array) (newarr) ), ((int) (0) ));
						a = ((T[]) (newarr) );
					}
					
				}
				else if (( pos == 0 )) {
					if (( capacity == length )) {
						T[] newarr1 = new T[( (( length << 1 )) + 1 )];
						global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (newarr1) ), ((int) (1) ), ((int) (length) ));
						a = ((T[]) (newarr1) );
					}
					else {
						global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (a) ), ((int) (1) ), ((int) (length) ));
					}
					
				}
				else if (( capacity == length )) {
					T[] newarr2 = new T[( (( length << 1 )) + 1 )];
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (newarr2) ), ((int) (0) ), ((int) (pos) ));
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (pos) ), ((global::System.Array) (newarr2) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					a = ((T[]) (newarr2) );
				}
				else {
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (pos) ), ((global::System.Array) (a) ), ((int) (( pos + 1 )) ), ((int) (( length - pos )) ));
					global::System.Array.Copy(((global::System.Array) (a) ), ((int) (0) ), ((global::System.Array) (a) ), ((int) (0) ), ((int) (pos) ));
				}
				
				a[pos] = x;
			}
		}
		
		
	}
}


