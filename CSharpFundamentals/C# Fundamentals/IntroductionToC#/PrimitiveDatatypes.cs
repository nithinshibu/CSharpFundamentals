using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals.C__Fundamentals.IntroductionToC_
{
	internal class PrimitiveDatatypes
	{
		public static void VariousPrimitiveDatatypes()
		{
			//primitive types
			sbyte a = sbyte.MinValue;
			sbyte b = sbyte.MaxValue;	
			sbyte c = default(sbyte);

            Console.WriteLine($"{a},{b},{c}");

			byte d = byte.MaxValue;
			short e = short.MinValue;
			ushort f = ushort.MinValue;
			int g = int.MaxValue;
			uint h = uint.MaxValue;
			long i = long.MaxValue;
			ulong j = ulong.MaxValue;
			float k = float.MinValue;
			double l = double.MaxValue;
			decimal m = decimal.MinValue;
			char n = 'A';
			bool x= true;
			// string is a non-primitive type
			string o = "hello";

        }
	}
}
