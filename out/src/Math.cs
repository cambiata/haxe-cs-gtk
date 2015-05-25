
#pragma warning disable 109, 114, 219, 429, 168, 162
public class Math {
	
	static Math() {
		{
			global::Math.PI = global::System.Math.PI;
			global::Math.NaN = global::System.Double.NaN;
			global::Math.NEGATIVE_INFINITY = global::System.Double.NegativeInfinity;
			global::Math.POSITIVE_INFINITY = global::System.Double.PositiveInfinity;
			global::Math.rand = new global::System.Random();
		}
		
	}
	
	
	public Math() {
	}
	
	
	public static global::System.Random rand;
	
	public static double PI;
	
	public static double NaN;
	
	public static double NEGATIVE_INFINITY;
	
	public static double POSITIVE_INFINITY;
	
}


