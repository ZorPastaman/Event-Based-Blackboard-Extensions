// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using System.Globalization;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Zor.EventBasedBlackboard.Workers.Operating
{
	/// <summary>
	/// <para>Collection of operators.</para>
	/// <para>It's used not to allocate delegates every time.</para>
	/// </summary>
	public static class DefaultOperators
	{
		public static readonly Func<AnimationCurve, float, float> AnimationCurveEvaluate =
			(curve, time) => curve.Evaluate(time);

		public static readonly Func<bool, bool> BoolNot = b => !b;

		public static readonly Func<bool, string> BoolToString = b => b.ToString(CultureInfo.InvariantCulture);

		public static readonly Func<bool, bool, bool> BoolAnd = (left, right) => left & right;
		public static readonly Func<bool, bool, bool> BoolEqual = (left, right) => left == right;
		public static readonly Func<bool, bool, bool> BoolNotEqual = (left, right) => left != right;
		public static readonly Func<bool, bool, bool> BoolOr = (left, right) => left | right;
		public static readonly Func<bool, bool, bool> BoolXor = (left, right) => left ^ right;

		public static readonly Func<bool, AnimationCurve, AnimationCurve, AnimationCurve> AnimationCurveConditional =
			(condition, left, right) => condition ? left : right;

		public static readonly Func<bool, bool, bool, bool> BoolConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, Bounds, Bounds, Bounds> BoundsConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, BoundsInt, BoundsInt, BoundsInt> BoundsIntConditional =
			(condition, left, right) => condition ? left : right;

		public static readonly Func<bool, byte, byte, byte> ByteConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, char, char, char> CharConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, Color, Color, Color> ColorConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, Component, Component, Component> ComponentConditional =
			(condition, left, right) => condition ? left : right;

		public static readonly Func<bool, double, double, double> DoubleConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, float, float, float> FloatConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, GameObject, GameObject, GameObject> GameObjectConditional =
			(condition, left, right) => condition ? left : right;

		public static readonly Func<bool, Gradient, Gradient, Gradient> GradientConditional =
			(condition, left, right) => condition ? left : right;

		public static readonly Func<bool, int, int, int> IntConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, LayerMask, LayerMask, LayerMask> LayerMaskConditional =
			(condition, left, right) => condition ? left : right;

		public static readonly Func<bool, long, long, long> LongConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, Matrix4x4, Matrix4x4, Matrix4x4> Matrix4x4Conditional =
			(condition, left, right) => condition ? left : right;

		public static readonly Func<bool, Object, Object, Object> ObjectConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, PropertyName, PropertyName, PropertyName> PropertyNameConditional =
			(condition, left, right) => condition ? left : right;

		public static readonly Func<bool, Quaternion, Quaternion, Quaternion> QuaternionConditional =
			(condition, left, right) => condition ? left : right;

		public static readonly Func<bool, Rect, Rect, Rect> RectConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, RectInt, RectInt, RectInt> RectIntConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, sbyte, sbyte, sbyte> SbyteConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, short, short, short> ShortConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, string, string, string> StringConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, Transform, Transform, Transform> TransformConditional =
			(condition, left, right) => condition ? left : right;

		public static readonly Func<bool, uint, uint, uint> UintConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, ulong, ulong, ulong> UlongConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, ushort, ushort, ushort> UshortConditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, Vector2, Vector2, Vector2> Vector2Conditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, Vector2Int, Vector2Int, Vector2Int> Vector2IntConditional =
			(condition, left, right) => condition ? left : right;

		public static readonly Func<bool, Vector3, Vector3, Vector3> Vector3Conditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<bool, Vector3Int, Vector3Int, Vector3Int> Vector3IntConditional =
			(condition, left, right) => condition ? left : right;

		public static readonly Func<bool, Vector4, Vector4, Vector4> Vector4Conditional = (condition, left, right) =>
			condition ? left : right;

		public static readonly Func<Bounds, Vector3> BoundsCenter = b => b.center;
		public static readonly Func<Bounds, Vector3> BoundsExtents = b => b.extents;
		public static readonly Func<Bounds, Vector3> BoundsMax = b => b.max;
		public static readonly Func<Bounds, Vector3> BoundsMin = b => b.min;
		public static readonly Func<Bounds, Vector3> BoundsSize = b => b.size;

		public static readonly Func<Bounds, Bounds, bool> BoundsEqual = (left, right) => left == right;
		public static readonly Func<Bounds, Bounds, bool> BoundsIntersects = (left, right) => left.Intersects(right);
		public static readonly Func<Bounds, Bounds, bool> BoundsNotEqual = (left, right) => left != right;

		public static readonly Func<Bounds, Vector3, bool> BoundsContains = (bounds, point) =>
			bounds.Contains(point);

		public static readonly Func<Bounds, Vector3, Bounds> BoundsEncapsulate = (bounds, point) =>
		{
			bounds.Encapsulate(point);
			return bounds;
		};
		public static readonly Func<Bounds, Vector3, Bounds> BoundsExpand = (bounds, amount) =>
		{
			bounds.Expand(amount);
			return bounds;
		};

		public static readonly Func<Bounds, Vector3, float> BoundsSquaredDistance = (bounds, point) =>
			bounds.SqrDistance(point);

		public static readonly Func<Bounds, Vector3, Vector3> BoundsClosestPoint = (bounds, point) =>
			bounds.ClosestPoint(point);

		public static readonly Func<BoundsInt, Vector3> BoundsIntCenter = b => b.center;

		public static readonly Func<BoundsInt, Vector3Int> BoundsIntMax = b => b.max;
		public static readonly Func<BoundsInt, Vector3Int> BoundsIntMin = b => b.min;
		public static readonly Func<BoundsInt, Vector3Int> BoundsIntPosition = b => b.position;
		public static readonly Func<BoundsInt, Vector3Int> BoundsIntSize = b => b.size;

		public static readonly Func<BoundsInt, BoundsInt, bool> BoundsIntEqual = (left, right) => left == right;
		public static readonly Func<BoundsInt, BoundsInt, bool> BoundIntNotEqual = (left, right) => left != right;

		public static readonly Func<BoundsInt, BoundsInt, BoundsInt> BoundsIntClampToBounds = (value, bounds) =>
		{
			value.ClampToBounds(bounds);
			return value;
		};

		public static readonly Func<BoundsInt, Vector3Int, bool> BoundsIntContains = (bounds, position) =>
			bounds.Contains(position);

		public static readonly Func<byte, byte> ByteDecrement = b => --b;
		public static readonly Func<byte, byte> ByteIncrement = b => ++b;

		public static readonly Func<byte, string> ByteToString = b => b.ToString(CultureInfo.InvariantCulture);

		public static readonly Func<byte, byte, bool> ByteAnythingMask = (value, mask) => (value & mask) != 0;
		public static readonly Func<byte, byte, bool> ByteEqual = (left, right) => left == right;
		public static readonly Func<byte, byte, bool> ByteEverythingMask = (value, mask) => (value & mask) == mask;
		public static readonly Func<byte, byte, bool> ByteGreater = (left, right) => left > right;
		public static readonly Func<byte, byte, bool> ByteGreaterOrEqual = (left, right) => left >= right;
		public static readonly Func<byte, byte, bool> ByteLess = (left, right) => left < right;
		public static readonly Func<byte, byte, bool> ByteLessOrEqual = (left, right) => left <= right;
		public static readonly Func<byte, byte, bool> ByteNotEqual = (left, right) => left != right;
		public static readonly Func<byte, byte, bool> ByteNothingMask = (value, mask) => (value & mask) == 0;

		public static readonly Func<byte, byte, byte> ByteMax = Math.Max;
		public static readonly Func<byte, byte, byte> ByteMin = Math.Min;

		public static readonly Func<byte, byte, byte, byte> ByteClamp = (value, min, max) =>
			Math.Min(Math.Max(value, min), max);

		public static readonly Func<char, string> CharToString = c => c.ToString(CultureInfo.InvariantCulture);

		public static readonly Func<char, char, bool> CharEqual = (left, right) => left == right;
		public static readonly Func<char, char, bool> CharNotEqual = (left, right) => left != right;

		public static readonly Func<Color, float> ColorGetRed = c => c.r;
		public static readonly Func<Color, float> ColorGetGreen = c => c.g;
		public static readonly Func<Color, float> ColorGetBlue = c => c.b;
		public static readonly Func<Color, float> ColorGetAlpha = c => c.a;

		public static readonly Func<Color, Color, bool> ColorEqual = (left, right) => left == right;
		public static readonly Func<Color, Color, bool> ColorNotEqual = (left, right) => left != right;

		public static readonly Func<Color, Color, Color> ColorAddition = (left, right) => left + right;
		public static readonly Func<Color, Color, Color> ColorMultiplication = (left, right) => left * right;
		public static readonly Func<Color, Color, Color> ColorSubtraction = (left, right) => left - right;

		public static readonly Func<Color, float, Color> ColorSetRed = (color, red) =>
		{
			color.r = red;
			return color;
		};
		public static readonly Func<Color, float, Color> ColorSetGreen = (color, green) =>
		{
			color.g = green;
			return color;
		};
		public static readonly Func<Color, float, Color> ColorSetBlue = (color, blue) =>
		{
			color.b = blue;
			return color;
		};
		public static readonly Func<Color, float, Color> ColorSetAlpha = (color, alpha) =>
		{
			color.a = alpha;
			return color;
		};

		public static readonly Func<Color, Color, float, Color> ColorLerp = Color.Lerp;
		public static readonly Func<Color, Color, float, Color> ColorLerpUnclamped = Color.LerpUnclamped;

		public static readonly Func<Color, float, Color> ColorProportionalDivision = (c, f) => c / f;
		public static readonly Func<Color, float, Color> ColorProportionalMultiplication = (c, f) => c * f;

		public static readonly Action<Component> ComponentSimpleInstantiate = c => Object.Instantiate(c);
		public static readonly Func<Component, Component> ComponentInstantiate = Object.Instantiate;

		public static readonly Func<Component, GameObject> ComponentGameObject = c => c.gameObject;

		public static readonly Func<Component, Transform> ComponentTransform = c => c.transform;

		public static readonly Action<GameObject> GameObjectSimpleInstantiate = go => Object.Instantiate(go);
		public static readonly Func<GameObject, GameObject> GameObjectInstantiate = Object.Instantiate;

		public static readonly Func<GameObject, Transform> GameObjectTransform = go => go.transform;

		public static readonly Func<double, double> DoubleAbs = Math.Abs;
		public static readonly Func<double, double> DoubleMinus = d => -d;

		public static readonly Func<double, int> DoubleSign = Math.Sign;

		public static readonly Func<double, string> DoubleToString = d => d.ToString(CultureInfo.InvariantCulture);

		public static readonly Func<double, double, bool> DoubleEqual = (left, right) => left == right;
		public static readonly Func<double, double, bool> DoubleGreater = (left, right) => left > right;
		public static readonly Func<double, double, bool> DoubleGreaterOrEqual = (left, right) => left >= right;
		public static readonly Func<double, double, bool> DoubleLess = (left, right) => left < right;
		public static readonly Func<double, double, bool> DoubleLessOrEqual = (left, right) => left <= right;
		public static readonly Func<double, double, bool> DoubleNotEqual = (left, right) => left != right;

		public static readonly Func<double, double, double> DoubleAddition = (left, right) => left + right;
		public static readonly Func<double, double, double> DoubleDivision = (left, right) => left / right;
		public static readonly Func<double, double, double> DoubleMax = Math.Max;
		public static readonly Func<double, double, double> DoubleMin = Math.Min;
		public static readonly Func<double, double, double> DoubleMultiplication = (left, right) => left * right;
		public static readonly Func<double, double, double> DoubleRemainder = (left, right) => left % right;
		public static readonly Func<double, double, double> DoubleSubtraction = (left, right) => left - right;

		public static readonly Func<double, double, double, double> DoubleClamp = (value, min, max) =>
			Math.Min(Math.Max(value, min), max);

		public static readonly Func<float, float> FloatAbs = Math.Abs;
		public static readonly Func<float, float> FloatAcos = Mathf.Acos;
		public static readonly Func<float, float> FloatAsin = Mathf.Asin;
		public static readonly Func<float, float> FloatAtan = Mathf.Atan;
		public static readonly Func<float, float> FloatCeil = Mathf.Ceil;
		public static readonly Func<float, float> FloatClamp01 = Mathf.Clamp01;
		public static readonly Func<float, float> FloatCos = Mathf.Cos;
		public static readonly Func<float, float> FloatExp = Mathf.Exp;
		public static readonly Func<float, float> FloatFloor = Mathf.Floor;
		public static readonly Func<float, float> FloatMinus = f => -f;
		public static readonly Func<float, float> FloatRound = Mathf.Round;
		public static readonly Func<float, float> FloatFloatSign = Mathf.Sign;
		public static readonly Func<float, float> FloatSin = Mathf.Sin;
		public static readonly Func<float, float> FloatSqrt = Mathf.Sqrt;
		public static readonly Func<float, float> FloatTan = Mathf.Tan;

		public static readonly Func<float, int> FloatCeilToInt = Mathf.CeilToInt;
		public static readonly Func<float, int> FloatFloorToInt = Mathf.FloorToInt;
		public static readonly Func<float, int> FloatRoundToInt = Mathf.RoundToInt;
		public static readonly Func<float, int> FloatIntSign = Math.Sign;

		public static readonly Func<float, string> FloatToString = f => f.ToString(CultureInfo.InvariantCulture);

		public static readonly Func<float, float, bool> FloatApproximately = Mathf.Approximately;
		public static readonly Func<float, float, bool> FloatEqual = (left, right) => left == right;
		public static readonly Func<float, float, bool> FloatGreater = (left, right) => left > right;
		public static readonly Func<float, float, bool> FloatGreaterOrEqual = (left, right) => left >= right;
		public static readonly Func<float, float, bool> FloatLess = (left, right) => left < right;
		public static readonly Func<float, float, bool> FloatLessOrEqual = (left, right) => left <= right;
		public static readonly Func<float, float, bool> FloatNotEqual = (left, right) => left != right;

		public static readonly Func<float, float, float> FloatAddition = (left, right) => left + right;
		public static readonly Func<float, float, float> FloatAtan2 = Mathf.Atan2;
		public static readonly Func<float, float, float> FloatDivision = (left, right) => left / right;
		public static readonly Func<float, float, float> FloatLog = Mathf.Log;
		public static readonly Func<float, float, float> FloatMax = Mathf.Max;
		public static readonly Func<float, float, float> FloatMin = Mathf.Min;
		public static readonly Func<float, float, float> FloatMultiplication = (left, right) => left * right;
		public static readonly Func<float, float, float> FloatPerlinNoise = Mathf.PerlinNoise;
		public static readonly Func<float, float, float> FloatPingPong = Mathf.PingPong;
		public static readonly Func<float, float, float> FloatPow = Mathf.Pow;
		public static readonly Func<float, float, float> FloatRemainder = (left, right) => left % right;
		public static readonly Func<float, float, float> FloatSubtraction = (left, right) => left - right;

		public static readonly Func<float, float, float, float> FloatClamp = Mathf.Clamp;
		public static readonly Func<float, float, float, float> FloatInverseLerp = Mathf.InverseLerp;
		public static readonly Func<float, float, float, float> FloatLerp = Mathf.Lerp;
		public static readonly Func<float, float, float, float> FloatLerpUnclamped = Mathf.LerpUnclamped;

		public static readonly Func<float, float, float, float, Color> ColorNew = (red, green, blue, alpha) =>
			new Color(red, green, blue, alpha);

		public static readonly Func<Gradient, float, Color> GradientEvaluate =
			(gradient, time) => gradient.Evaluate(time);

		public static readonly Func<int, bool> IntIsPowerOfTwo = Mathf.IsPowerOfTwo;

		public static readonly Func<int, int> IntAbs = Mathf.Abs;
		public static readonly Func<int, int> IntClosestPowerOfTwo = Mathf.ClosestPowerOfTwo;
		public static readonly Func<int, int> IntComplement = i => ~i;
		public static readonly Func<int, int> IntDecrement = i => --i;
		public static readonly Func<int, int> IntIncrement = i => ++i;
		public static readonly Func<int, int> IntMinus = i => -i;
		public static readonly Func<int, int> IntNextPowerOfTwo = Mathf.NextPowerOfTwo;
		public static readonly Func<int, int> IntSign = Math.Sign;

		public static readonly Func<int, string> IntToString = i => i.ToString(CultureInfo.InvariantCulture);

		public static readonly Func<int, int, bool> IntAnythingMask = (value, mask) => (value & mask) != 0;
		public static readonly Func<int, int, bool> IntEqual = (left, right) => left == right;
		public static readonly Func<int, int, bool> IntEverythingMask = (value, mask) => (value & mask) == mask;
		public static readonly Func<int, int, bool> IntGreater = (left, right) => left > right;
		public static readonly Func<int, int, bool> IntGreaterOrEqual = (left, right) => left >= right;
		public static readonly Func<int, int, bool> IntLess = (left, right) => left < right;
		public static readonly Func<int, int, bool> IntLessOrEqual = (left, right) => left <= right;
		public static readonly Func<int, int, bool> IntNotEqual = (left, right) => left != right;
		public static readonly Func<int, int, bool> IntNothingMask = (value, mask) => (value & mask) == 0;

		public static readonly Func<int, int, int> IntAddition = (left, right) => left + right;
		public static readonly Func<int, int, int> IntAnd = (left, right) => left & right;
		public static readonly Func<int, int, int> IntDivision = (left, right) => left / right;
		public static readonly Func<int, int, int> IntLeftShift = (left, right) => left << right;
		public static readonly Func<int, int, int> IntMax = Mathf.Max;
		public static readonly Func<int, int, int> IntMin = Mathf.Min;
		public static readonly Func<int, int, int> IntMultiplication = (left, right) => left * right;
		public static readonly Func<int, int, int> IntOr = (left, right) => left | right;
		public static readonly Func<int, int, int> IntRemainder = (left, right) => left % right;
		public static readonly Func<int, int, int> IntRightShift = (left, right) => left >> right;
		public static readonly Func<int, int, int> IntSubtraction = (left, right) => left - right;
		public static readonly Func<int, int, int> IntXor = (left, right) => left ^ right;

		public static readonly Func<int, int, int, int> IntClamp = Mathf.Clamp;

		public static readonly Func<long, int> LongSign = Math.Sign;

		public static readonly Func<long, long> LongAbs = Math.Abs;
		public static readonly Func<long, long> LongComplement = l => ~l;
		public static readonly Func<long, long> LongDecrement = l => --l;
		public static readonly Func<long, long> LongIncrement = l => ++l;
		public static readonly Func<long, long> LongMinus = l => -l;

		public static readonly Func<long, string> LongToString = l => l.ToString(CultureInfo.InvariantCulture);

		public static readonly Func<long, int, long> LongLeftShift = (left, right) => left << right;
		public static readonly Func<long, int, long> LongRightShift = (left, right) => left >> right;

		public static readonly Func<long, long, bool> LongAnythingMask = (value, mask) => (value & mask) != 0;
		public static readonly Func<long, long, bool> LongEqual = (left, right) => left == right;
		public static readonly Func<long, long, bool> LongEverythingMask = (value, mask) => (value & mask) == mask;
		public static readonly Func<long, long, bool> LongGreater = (left, right) => left > right;
		public static readonly Func<long, long, bool> LongGreaterOrEqual = (left, right) => left >= right;
		public static readonly Func<long, long, bool> LongLess = (left, right) => left < right;
		public static readonly Func<long, long, bool> LongLessOrEqual = (left, right) => left <= right;
		public static readonly Func<long, long, bool> LongNotEqual = (left, right) => left != right;
		public static readonly Func<long, long, bool> LongNothingMask = (value, mask) => (value & mask) == 0;

		public static readonly Func<long, long, long> LongAddition = (left, right) => left + right;
		public static readonly Func<long, long, long> LongAnd = (left, right) => left & right;
		public static readonly Func<long, long, long> LongDivision = (left, right) => left / right;
		public static readonly Func<long, long, long> LongMax = Math.Max;
		public static readonly Func<long, long, long> LongMin = Math.Min;
		public static readonly Func<long, long, long> LongMultiplication = (left, right) => left * right;
		public static readonly Func<long, long, long> LongOr = (left, right) => left | right;
		public static readonly Func<long, long, long> LongRemainder = (left, right) => left % right;
		public static readonly Func<long, long, long> LongSubtraction = (left, right) => left - right;
		public static readonly Func<long, long, long> LongXor = (left, right) => left ^ right;

		public static readonly Func<long, long, long, long> LongClamp = (value, min, max) =>
			Math.Min(Math.Max(value, min), max);

		public static readonly Func<Matrix4x4, float> Matrix4x4Determinant = Matrix4x4.Determinant;

		public static readonly Func<Matrix4x4, Matrix4x4> Matrix4x4Inverse = Matrix4x4.Inverse;
		public static readonly Func<Matrix4x4, Matrix4x4> Matrix4x4Transpose = Matrix4x4.Transpose;

		public static readonly Func<Matrix4x4, Vector3> Matrix4x4LossyScale = m => m.lossyScale;

		public static readonly Func<Matrix4x4, Quaternion> Matrix4x4Rotation = m => m.rotation;

		public static readonly Func<Matrix4x4, Matrix4x4, bool> Matrix4x4Equal = (left, right) => left == right;
		public static readonly Func<Matrix4x4, Matrix4x4, bool> Matrix4x4NotEqual = (left, right) => left != right;

		public static readonly Func<Matrix4x4, int, float> Matrix4x4GetElement = (matrix, elementIndex) =>
			matrix[elementIndex];

		public static readonly Func<Matrix4x4, int, Vector4> Matrix4x4GetColumn = (matrix, columnIndex) =>
			matrix.GetColumn(columnIndex);
		public static readonly Func<Matrix4x4, int, Vector4> Matrix4x4GetRow = (matrix, rowIndex) =>
			matrix.GetRow(rowIndex);

		public static readonly Func<Matrix4x4, Matrix4x4, Matrix4x4> Matrix4x4Multiplication = (left, right) =>
			left * right;

		public static readonly Func<Matrix4x4, Vector3, Vector3> Matrix4x4MultiplyPoint = (matrix, point) =>
			matrix.MultiplyPoint(point);
		public static readonly Func<Matrix4x4, Vector3, Vector3> Matrix4x4MultiplyPoint3x4 = (matrix, point) =>
			matrix.MultiplyPoint3x4(point);
		public static readonly Func<Matrix4x4, Vector3, Vector3> Matrix4x4MultiplyVector = (matrix, vector) =>
			matrix.MultiplyVector(vector);

		public static readonly Func<Matrix4x4, Vector4, Vector4> Matrix4x4VectorMultiplication = (left, right) =>
			left * right;

		public static readonly Func<Matrix4x4, int, float, Matrix4x4> Matrix4x4SetElement =
			(matrix, elementIndex, value) =>
			{
				matrix[elementIndex] = value;
				return matrix;
			};

		public static readonly Func<Matrix4x4, int, Vector4, Matrix4x4> Matrix4x4SetColumn =
			(matrix, columnIndex, column) =>
			{
				matrix.SetColumn(columnIndex, column);
				return matrix;
			};
		public static readonly Func<Matrix4x4, int, Vector4, Matrix4x4> Matrix4x4SetRow = (matrix, rowIndex, row) =>
		{
			matrix.SetRow(rowIndex, row);
			return matrix;
		};

		public static readonly Func<Quaternion, Matrix4x4> Matrix4x4Rotate = Matrix4x4.Rotate;

		public static readonly Func<Vector3, Matrix4x4> Matrix4x4Scale = Matrix4x4.Scale;
		public static readonly Func<Vector3, Matrix4x4> Matrix4x4Translate = Matrix4x4.Translate;

		public static readonly Func<Vector4, Vector4, Vector4, Vector4, Matrix4x4> Matrix4x4New =
			(column0, column1, column2, column3) => new Matrix4x4(column0, column1, column2, column3);

		public static readonly Func<float, float, float, float, Matrix4x4> Matrix4x4Perspective = Matrix4x4.Perspective;

		public static readonly Func<Vector3, Vector3, Vector3, Matrix4x4> Matrix4x4LookAt = Matrix4x4.LookAt;

		public static readonly Func<Vector3, Quaternion, Vector3, Matrix4x4> Matrix4x4TRS = Matrix4x4.TRS;

		public static readonly Func<Object, bool> ObjectExists = o => o;

		public static readonly Func<Object, Object, bool> ObjectEqual = (left, right) => left == right;
		public static readonly Func<Object, Object, bool> ObjectNotEqual = (left, right) => left != right;

		public static readonly Func<string, PropertyName> PropertyNameNew = s => new PropertyName(s);

		public static readonly Func<PropertyName, PropertyName, bool> PropertyNameEqual = (left, right) =>
			left == right;
		public static readonly Func<PropertyName, PropertyName, bool> PropertyNameNotEqual = (left, right) =>
			left != right;

		public static readonly Func<Quaternion, float> QuaternionGetX = q => q.x;
		public static readonly Func<Quaternion, float> QuaternionGetY = q => q.y;
		public static readonly Func<Quaternion, float> QuaternionGetZ = q => q.z;
		public static readonly Func<Quaternion, float> QuaternionGetW = q => q.w;

		public static readonly Func<Quaternion, Quaternion> QuaternionInverse = Quaternion.Inverse;
		public static readonly Func<Quaternion, Quaternion> QuaternionNormalize = Quaternion.Normalize;

		public static readonly Func<Quaternion, Vector3> QuaternionEulerAngles = q => q.eulerAngles;

		public static readonly Func<Vector3, Quaternion> QuaternionEuler = Quaternion.Euler;

		public static readonly Func<float, Vector3, Quaternion> QuaternionAngleAxis = Quaternion.AngleAxis;

		public static readonly Func<Quaternion, float, Quaternion> QuaternionSetX = (quaternion, value) =>
		{
			quaternion.x = value;
			return quaternion;
		};
		public static readonly Func<Quaternion, float, Quaternion> QuaternionSetY = (quaternion, value) =>
		{
			quaternion.y = value;
			return quaternion;
		};
		public static readonly Func<Quaternion, float, Quaternion> QuaternionSetZ = (quaternion, value) =>
		{
			quaternion.z = value;
			return quaternion;
		};
		public static readonly Func<Quaternion, float, Quaternion> QuaternionSetW = (quaternion, value) =>
		{
			quaternion.w = value;
			return quaternion;
		};

		public static readonly Func<Quaternion, Quaternion, bool> QuaternionEqual = (left, right) => left == right;
		public static readonly Func<Quaternion, Quaternion, bool> QuaternionNotEqual = (left, right) => left != right;

		public static readonly Func<Quaternion, Quaternion, float> QuaternionDot = Quaternion.Dot;
		public static readonly Func<Quaternion, Quaternion, float> QuaternionAngle = Quaternion.Angle;

		public static readonly Func<Quaternion, Quaternion, Quaternion> QuaternionMultiplication = (left, right) =>
			left * right;

		public static readonly Func<Quaternion, Vector3, Vector3> QuaternionPointMultiplication =
			(quaternion, point) => quaternion * point;

		public static readonly Func<Vector3, Vector3, Quaternion> QuaternionLookRotation = Quaternion.LookRotation;

		public static readonly Func<Quaternion, Quaternion, float, Quaternion> QuaternionSlerp = Quaternion.Slerp;
		public static readonly Func<Quaternion, Quaternion, float, Quaternion> QuaternionSlerpUnclamped =
			Quaternion.SlerpUnclamped;
		public static readonly Func<Quaternion, Quaternion, float, Quaternion> QuaternionLerp = Quaternion.Lerp;
		public static readonly Func<Quaternion, Quaternion, float, Quaternion> QuaternionLerpUnclamped =
			Quaternion.LerpUnclamped;

		public static readonly Func<Vector3, Vector3, Quaternion> QuaternionFromToRotation = Quaternion.FromToRotation;

		public static readonly Func<float, float, float, float, Quaternion> QuaternionNew = (x, y, z, w) =>
			new Quaternion(x, y, z, w);

		public static readonly Func<Rect, float> RectGetX = r => r.x;
		public static readonly Func<Rect, float> RectGetY = r => r.y;
		public static readonly Func<Rect, float> RectGetHeight = r => r.height;
		public static readonly Func<Rect, float> RectGetWidth = r => r.width;
		public static readonly Func<Rect, float> RectGetXMin = r => r.xMin;
		public static readonly Func<Rect, float> RectGetYMin = r => r.yMin;
		public static readonly Func<Rect, float> RectGetXMax = r => r.xMax;
		public static readonly Func<Rect, float> RectGetYMax = r => r.yMax;

		public static readonly Func<Rect, Vector2> RectGetPosition = r => r.position;
		public static readonly Func<Rect, Vector2> RectGetCenter = r => r.center;
		public static readonly Func<Rect, Vector2> RectGetMin = r => r.min;
		public static readonly Func<Rect, Vector2> RectGetMax = r => r.max;
		public static readonly Func<Rect, Vector2> RectGetSize = r => r.size;

		public static readonly Func<Rect, float, Rect> RectSetX = (rect, x) =>
		{
			rect.x = x;
			return rect;
		};
		public static readonly Func<Rect, float, Rect> RectSetY = (rect, y) =>
		{
			rect.y = y;
			return rect;
		};
		public static readonly Func<Rect, float, Rect> RectSetHeight = (rect, height) =>
		{
			rect.height = height;
			return rect;
		};
		public static readonly Func<Rect, float, Rect> RectSetWidth = (rect, width) =>
		{
			rect.width = width;
			return rect;
		};
		public static readonly Func<Rect, float, Rect> RectSetXMin = (rect, xMin) =>
		{
			rect.xMin = xMin;
			return rect;
		};
		public static readonly Func<Rect, float, Rect> RectSetYMin = (rect, yMin) =>
		{
			rect.yMin = yMin;
			return rect;
		};
		public static readonly Func<Rect, float, Rect> RectSetXMax = (rect, xMax) =>
		{
			rect.xMax = xMax;
			return rect;
		};
		public static readonly Func<Rect, float, Rect> RectSetYMax = (rect, yMax) =>
		{
			rect.yMax = yMax;
			return rect;
		};

		public static readonly Func<Rect, Rect, bool> RectOverlaps = (rect, other) => rect.Overlaps(other);
		public static readonly Func<Rect, Rect, bool> RectEqual = (left, right) => left == right;
		public static readonly Func<Rect, Rect, bool> RectNotEqual = (left, right) => left != right;

		public static readonly Func<Rect, Vector2, bool> RectContainsPoint = (rect, point) => rect.Contains(point);

		public static readonly Func<Rect, Vector2, Rect> RectSetPosition = (rect, position) =>
		{
			rect.position = position;
			return rect;
		};
		public static readonly Func<Rect, Vector2, Rect> RectSetCenter = (rect, center) =>
		{
			rect.center = center;
			return rect;
		};
		public static readonly Func<Rect, Vector2, Rect> RectSetMin = (rect, min) =>
		{
			rect.min = min;
			return rect;
		};
		public static readonly Func<Rect, Vector2, Rect> RectSetMax = (rect, max) =>
		{
			rect.max = max;
			return rect;
		};
		public static readonly Func<Rect, Vector2, Rect> RectSetSize = (rect, size) =>
		{
			rect.size = size;
			return rect;
		};

		public static readonly Func<Rect, Vector2, Vector2> RectNormalizedToPoint = Rect.NormalizedToPoint;
		public static readonly Func<Rect, Vector2, Vector2> RectPointToNormalized = Rect.PointToNormalized;

		public static readonly Func<Vector2, Vector2, Rect> RectNewWithVectors = (position, size) =>
			new Rect(position, size);

		public static readonly Func<float, float, float, float, Rect> RectNewWithFloats = (x, y, width, height) =>
			new Rect(x, y, width, height);
		public static readonly Func<float, float, float, float, Rect> RectMinMaxRect = Rect.MinMaxRect;

		public static readonly Func<RectInt, int> RectIntGetX = r => r.x;
		public static readonly Func<RectInt, int> RectIntGetY = r => r.y;
		public static readonly Func<RectInt, int> RectIntGetWidth = r => r.width;
		public static readonly Func<RectInt, int> RectIntGetHeight = r => r.height;
		public static readonly Func<RectInt, int> RectIntGetXMin = r => r.xMin;
		public static readonly Func<RectInt, int> RectIntGetYMin = r => r.yMin;
		public static readonly Func<RectInt, int> RectIntGetXMax = r => r.xMax;
		public static readonly Func<RectInt, int> RectIntGetYMax = r => r.yMax;

		public static readonly Func<RectInt, Vector2> RectIntCenter = r => r.center;

		public static readonly Func<RectInt, Vector2Int> RectIntGetMin = r => r.min;
		public static readonly Func<RectInt, Vector2Int> RectIntGetMax = r => r.max;
		public static readonly Func<RectInt, Vector2Int> RectIntGetPosition = r => r.position;
		public static readonly Func<RectInt, Vector2Int> RectIntGetSize = r => r.size;

		public static readonly Func<RectInt, int, RectInt> RectIntSetX = (rect, x) =>
		{
			rect.x = x;
			return rect;
		};
		public static readonly Func<RectInt, int, RectInt> RectIntSetY = (rect, y) =>
		{
			rect.y = y;
			return rect;
		};
		public static readonly Func<RectInt, int, RectInt> RectIntSetWidth = (rect, width) =>
		{
			rect.width = width;
			return rect;
		};
		public static readonly Func<RectInt, int, RectInt> RectIntSetHeight = (rect, height) =>
		{
			rect.height = height;
			return rect;
		};
		public static readonly Func<RectInt, int, RectInt> RectIntSetXMin = (rect, xMin) =>
		{
			rect.xMin = xMin;
			return rect;
		};
		public static readonly Func<RectInt, int, RectInt> RectIntSetYMin = (rect, yMin) =>
		{
			rect.yMin = yMin;
			return rect;
		};
		public static readonly Func<RectInt, int, RectInt> RectIntSetXMax = (rect, xMax) =>
		{
			rect.xMax = xMax;
			return rect;
		};
		public static readonly Func<RectInt, int, RectInt> RectIntSetYMax = (rect, yMax) =>
		{
			rect.yMax = yMax;
			return rect;
		};

		public static readonly Func<RectInt, RectInt, bool> RectIntEqual = (left, right) => left.Equals(right);

		public static readonly Func<RectInt, RectInt, RectInt> RectIntClampToBounds = (rect, bounds) =>
		{
			rect.ClampToBounds(bounds);
			return rect;
		};

		public static readonly Func<RectInt, Vector2Int, bool> RectIntContains = (rect, position) =>
			rect.Contains(position);

		public static readonly Func<RectInt, Vector2Int, RectInt> RectIntSetMin = (rect, min) =>
		{
			rect.min = min;
			return rect;
		};
		public static readonly Func<RectInt, Vector2Int, RectInt> RectIntSetMax = (rect, max) =>
		{
			rect.max = max;
			return rect;
		};
		public static readonly Func<RectInt, Vector2Int, RectInt> RectIntSetPosition = (rect, position) =>
		{
			rect.position = position;
			return rect;
		};
		public static readonly Func<RectInt, Vector2Int, RectInt> RectIntSetSize = (rect, size) =>
		{
			rect.size = size;
			return rect;
		};

		public static readonly Func<Vector2Int, Vector2Int, RectInt> RectIntNewWithVectors = (position, size) =>
			new RectInt(position, size);

		public static readonly Func<int, int, int, int, RectInt> RectIntNewWithInts = (xMin, yMin, width, height) =>
			new RectInt(xMin, yMin, width, height);

		public static readonly Func<sbyte, sbyte> SbyteDecrement = sb => --sb;
		public static readonly Func<sbyte, sbyte> SbyteIncrement = sb => ++sb;

		public static readonly Func<sbyte, string> SbyteToString = sb => sb.ToString(CultureInfo.InvariantCulture);

		public static readonly Func<sbyte, sbyte, bool> SbyteAnythingMask = (value, mask) => (value & mask) != 0;
		public static readonly Func<sbyte, sbyte, bool> SbyteEqual = (left, right) => left == right;
		public static readonly Func<sbyte, sbyte, bool> SbyteEverythingMask = (value, mask) => (value & mask) == mask;
		public static readonly Func<sbyte, sbyte, bool> SbyteGreater = (left, right) => left > right;
		public static readonly Func<sbyte, sbyte, bool> SbyteGreaterOrEqual = (left, right) => left >= right;
		public static readonly Func<sbyte, sbyte, bool> SbyteLess = (left, right) => left < right;
		public static readonly Func<sbyte, sbyte, bool> SbyteLessOrEqual = (left, right) => left <= right;
		public static readonly Func<sbyte, sbyte, bool> SbyteNotEqual = (left, right) => left != right;
		public static readonly Func<sbyte, sbyte, bool> SbyteNothingMask = (value, mask) => (value & mask) == 0;

		public static readonly Func<sbyte, sbyte, sbyte> SbyteMax = Math.Max;
		public static readonly Func<sbyte, sbyte, sbyte> SbyteMin = Math.Min;

		public static readonly Func<sbyte, sbyte, sbyte, sbyte> SbyteClamp = (value, min, max) =>
			Math.Min(Math.Max(value, min), max);
		
		public static readonly Func<short, int> ShortSign = Math.Sign;

		public static readonly Func<short, short> ShortAbs = Math.Abs;
		public static readonly Func<short, short> ShortDecrement = l => --l;
		public static readonly Func<short, short> ShortIncrement = l => ++l;

		public static readonly Func<short, string> ShortToString = s => s.ToString(CultureInfo.InvariantCulture);

		public static readonly Func<short, short, bool> ShortAnythingMask = (value, mask) => (value & mask) != 0;
		public static readonly Func<short, short, bool> ShortEqual = (left, right) => left == right;
		public static readonly Func<short, short, bool> ShortEverythingMask = (value, mask) => (value & mask) == mask;
		public static readonly Func<short, short, bool> ShortGreater = (left, right) => left > right;
		public static readonly Func<short, short, bool> ShortGreaterOrEqual = (left, right) => left >= right;
		public static readonly Func<short, short, bool> ShortLess = (left, right) => left < right;
		public static readonly Func<short, short, bool> ShortLessOrEqual = (left, right) => left <= right;
		public static readonly Func<short, short, bool> ShortNotEqual = (left, right) => left != right;
		public static readonly Func<short, short, bool> ShortNothingMask = (value, mask) => (value & mask) == 0;

		public static readonly Func<short, short, short> ShortMax = Math.Max;
		public static readonly Func<short, short, short> ShortMin = Math.Min;

		public static readonly Func<short, short, short, short> ShortClamp = (value, min, max) =>
			Math.Min(Math.Max(value, min), max);

		public static readonly Func<string, bool> StringIsNullOrEmpty = string.IsNullOrEmpty;

		public static readonly Func<string, int> StringGetLength = s => s.Length;

		public static readonly Func<string, string> StringToLower = s => s.ToLowerInvariant();
		public static readonly Func<string, string> StringToUpper = s => s.ToUpperInvariant();

		public static readonly Func<string, int, char> StringGetChar = (value, index) => value[index];

		public static readonly Func<string, string, bool> StringContains = (left, right) => left.Contains(right);
		public static readonly Func<string, string, bool> StringEndsWith = (left, right) => left.EndsWith(right);
		public static readonly Func<string, string, bool> StringStartsWith = (left, right) => left.StartsWith(right);
		public static readonly Func<string, string, bool> StringEqual = (left, right) => left == right;
		public static readonly Func<string, string, bool> StringNotEqual = (left, right) => left != right;

		public static readonly Func<string, string, string> StringConcat = (left, right) => left + right;

		public static readonly Func<string, int, int, string> StringSubstring = (value, start, length) =>
			value.Substring(start, length);

		public static readonly Func<string, string, string, string> StringReplace = (value, oldValue, newValue) =>
			value.Replace(oldValue, newValue);

		public static readonly Func<Transform, Matrix4x4> TransformGetWorldToLocalMatrix = t => t.worldToLocalMatrix;
		public static readonly Func<Transform, Matrix4x4> TransformGetLocalToWorldMatrix = t => t.localToWorldMatrix;

		public static readonly Func<Transform, Quaternion> TransformGetRotation = t => t.rotation;
		public static readonly Func<Transform, Quaternion> TransformGetLocalRotation = t => t.localRotation;

		public static readonly Action<Transform, Quaternion> TransformSetRotation = (transform, rotation) =>
			transform.rotation = rotation;
		public static readonly Action<Transform, Quaternion> TransformSetLocalRotation = (transform, localRotation) =>
			transform.localRotation = localRotation;

		public static readonly Func<Transform, Vector3> TransformGetPosition = t => t.position;
		public static readonly Func<Transform, Vector3> TransformGetLocalPosition = t => t.localPosition;
		public static readonly Func<Transform, Vector3> TransformGetLossyScale = t => t.lossyScale;
		public static readonly Func<Transform, Vector3> TransformGetLocalScale = t => t.localScale;
		public static readonly Func<Transform, Vector3> TransformGetUp = t => t.up;
		public static readonly Func<Transform, Vector3> TransformGetForward = t => t.forward;

		public static readonly Action<Transform, Vector3> TransformSetPosition = (transform, position) =>
			transform.position = position;
		public static readonly Action<Transform, Vector3> TransformSetLocalPosition = (transform, localPosition) =>
			transform.localPosition = localPosition;
		public static readonly Action<Transform, Vector3> TransformSetLocalScale = (transform, localScale) =>
			transform.localScale = localScale;
		public static readonly Action<Transform, Vector3> TransformSetUp = (transform, up) => transform.up = up;
		public static readonly Action<Transform, Vector3> TransformSetForward = (transform, forward) =>
			transform.forward = forward;

		public static readonly Func<uint, uint> UintDecrement = l => --l;
		public static readonly Func<uint, uint> UintIncrement = l => ++l;

		public static readonly Func<uint, string> UintToString = l => l.ToString(CultureInfo.InvariantCulture);
		
		public static readonly Func<uint, uint, bool> UintEqual = (left, right) => left == right;
		public static readonly Func<uint, uint, bool> UintGreater = (left, right) => left > right;
		public static readonly Func<uint, uint, bool> UintGreaterOrEqual = (left, right) => left >= right;
		public static readonly Func<uint, uint, bool> UintLess = (left, right) => left < right;
		public static readonly Func<uint, uint, bool> UintLessOrEqual = (left, right) => left <= right;
		public static readonly Func<uint, uint, bool> UintNotEqual = (left, right) => left != right;

		public static readonly Func<uint, uint, uint> UintAddition = (left, right) => left + right;
		public static readonly Func<uint, uint, uint> UintDivision = (left, right) => left / right;
		public static readonly Func<uint, uint, uint> UintMax = Math.Max;
		public static readonly Func<uint, uint, uint> UintMin = Math.Min;
		public static readonly Func<uint, uint, uint> UintMultiplication = (left, right) => left * right;
		public static readonly Func<uint, uint, uint> UintRemainder = (left, right) => left % right;
		public static readonly Func<uint, uint, uint> UintSubtraction = (left, right) => left - right;
		
		public static readonly Func<uint, uint, uint, uint> UintClamp = (value, min, max) =>
			Math.Min(Math.Max(value, min), max);

		public static readonly Func<ulong, ulong> UlongDecrement = l => --l;
		public static readonly Func<ulong, ulong> UlongIncrement = l => ++l;

		public static readonly Func<ulong, string> UlongToString = l => l.ToString(CultureInfo.InvariantCulture);
		
		public static readonly Func<ulong, ulong, bool> UlongEqual = (left, right) => left == right;
		public static readonly Func<ulong, ulong, bool> UlongGreater = (left, right) => left > right;
		public static readonly Func<ulong, ulong, bool> UlongGreaterOrEqual = (left, right) => left >= right;
		public static readonly Func<ulong, ulong, bool> UlongLess = (left, right) => left < right;
		public static readonly Func<ulong, ulong, bool> UlongLessOrEqual = (left, right) => left <= right;
		public static readonly Func<ulong, ulong, bool> UlongNotEqual = (left, right) => left != right;

		public static readonly Func<ulong, ulong, ulong> UlongAddition = (left, right) => left + right;
		public static readonly Func<ulong, ulong, ulong> UlongDivision = (left, right) => left / right;
		public static readonly Func<ulong, ulong, ulong> UlongMax = Math.Max;
		public static readonly Func<ulong, ulong, ulong> UlongMin = Math.Min;
		public static readonly Func<ulong, ulong, ulong> UlongMultiplication = (left, right) => left * right;
		public static readonly Func<ulong, ulong, ulong> UlongRemainder = (left, right) => left % right;
		public static readonly Func<ulong, ulong, ulong> UlongSubtraction = (left, right) => left - right;
		
		public static readonly Func<ulong, ulong, ulong, ulong> UlongClamp = (value, min, max) =>
			Math.Min(Math.Max(value, min), max);

		public static readonly Func<ushort, ushort> UshortDecrement = l => --l;
		public static readonly Func<ushort, ushort> UshortIncrement = l => ++l;

		public static readonly Func<ushort, string> UshortToString = l => l.ToString(CultureInfo.InvariantCulture);
		
		public static readonly Func<ushort, ushort, bool> UshortEqual = (left, right) => left == right;
		public static readonly Func<ushort, ushort, bool> UshortGreater = (left, right) => left > right;
		public static readonly Func<ushort, ushort, bool> UshortGreaterOrEqual = (left, right) => left >= right;
		public static readonly Func<ushort, ushort, bool> UshortLess = (left, right) => left < right;
		public static readonly Func<ushort, ushort, bool> UshortLessOrEqual = (left, right) => left <= right;
		public static readonly Func<ushort, ushort, bool> UshortNotEqual = (left, right) => left != right;

		public static readonly Func<ushort, ushort, ushort> UshortMax = Math.Max;
		public static readonly Func<ushort, ushort, ushort> UshortMin = Math.Min;
		
		public static readonly Func<ushort, ushort, ushort, ushort> UshortClamp = (value, min, max) =>
			Math.Min(Math.Max(value, min), max);

		public static readonly Func<float, float, Vector2> Vector2New = (x, y) => new Vector2(x, y);

		public static readonly Func<Vector2, float> Vector2GetX = v => v.x;
		public static readonly Func<Vector2, float> Vector2GetY = v => v.y;
		public static readonly Func<Vector2, float> Vector2Magnitude = v => v.magnitude;
		public static readonly Func<Vector2, float> Vector2SqrMagnitude = v => v.sqrMagnitude;

		public static readonly Func<Vector2, Vector2> Vector2Normalized = v => v.normalized;
		public static readonly Func<Vector2, Vector2> Vector2Minus = v => -v;

		public static readonly Func<Vector2, float, Vector2> Vector2SetX = (vector, x) =>
		{
			vector.x = x;
			return vector;
		};
		public static readonly Func<Vector2, float, Vector2> Vector2SetY = (vector, y) =>
		{
			vector.y = y;
			return vector;
		};
		public static readonly Func<Vector2, float, Vector2> Vector2FloatMultiplication = (left, right) => left * right;
		public static readonly Func<Vector2, float, Vector2> Vector2FloatDivision = (left, right) => left / right;

		public static readonly Func<Vector2, Vector2, bool> Vector2Equal = (left, right) => left == right;
		public static readonly Func<Vector2, Vector2, bool> Vector2NotEqual = (left, right) => left != right;

		public static readonly Func<Vector2, Vector2, Vector2> Vector2Addition = (left, right) => left + right;
		public static readonly Func<Vector2, Vector2, Vector2> Vector2Subtraction = (left, right) => left - right;
		public static readonly Func<Vector2, Vector2, Vector2> Vector2VectorMultiplication =
			(left, right) => left * right;
		public static readonly Func<Vector2, Vector2, Vector2> Vector2VectorDivision = (left, right) => left / right;
		
		public static readonly Func<int, int, Vector2Int> Vector2IntNew = (x, y) => new Vector2Int(x, y);

		public static readonly Func<Vector2Int, int> Vector2IntGetX = v => v.x;
		public static readonly Func<Vector2Int, int> Vector2IntGetY = v => v.y;
		public static readonly Func<Vector2Int, float> Vector2IntMagnitude = v => v.magnitude;
		public static readonly Func<Vector2Int, int> Vector2IntSqrMagnitude = v => v.sqrMagnitude;

		public static readonly Func<Vector2Int, int, Vector2Int> Vector2IntSetX = (vector, x) =>
		{
			vector.x = x;
			return vector;
		};
		public static readonly Func<Vector2Int, int, Vector2Int> Vector2IntSetY = (vector, y) =>
		{
			vector.y = y;
			return vector;
		};
		public static readonly Func<Vector2Int, int, Vector2Int> Vector2IntIntMultiplication = (left, right) => left * right;

		public static readonly Func<Vector2Int, Vector2Int, bool> Vector2IntEqual = (left, right) => left == right;
		public static readonly Func<Vector2Int, Vector2Int, bool> Vector2IntNotEqual = (left, right) => left != right;

		public static readonly Func<Vector2Int, Vector2Int, Vector2Int> Vector2IntAddition = (left, right) => left + right;
		public static readonly Func<Vector2Int, Vector2Int, Vector2Int> Vector2IntSubtraction = (left, right) => left - right;
		public static readonly Func<Vector2Int, Vector2Int, Vector2Int> Vector2IntVectorMultiplication =
			(left, right) => left * right;

		public static readonly Func<float, float, float, Vector3> Vector3New = (x, y, z) => new Vector3(x, y, z);

		public static readonly Func<Vector3, float> Vector3GetX = v => v.x;
		public static readonly Func<Vector3, float> Vector3GetY = v => v.y;
		public static readonly Func<Vector3, float> Vector3GetZ = v => v.z;
		public static readonly Func<Vector3, float> Vector3Magnitude = v => v.magnitude;
		public static readonly Func<Vector3, float> Vector3SqrMagnitude = v => v.sqrMagnitude;

		public static readonly Func<Vector3, Vector3> Vector3Normalized = v => v.normalized;
		public static readonly Func<Vector3, Vector3> Vector3Minus = v => -v;

		public static readonly Func<Vector3, float, Vector3> Vector3SetX = (vector, x) =>
		{
			vector.x = x;
			return vector;
		};
		public static readonly Func<Vector3, float, Vector3> Vector3SetY = (vector, y) =>
		{
			vector.y = y;
			return vector;
		};
		public static readonly Func<Vector3, float, Vector3> Vector3SetZ = (vector, z) =>
		{
			vector.z = z;
			return vector;
		};

		public static readonly Func<Vector3, float, Vector3> Vector3Multiplication = (left, right) => left * right;
		public static readonly Func<Vector3, float, Vector3> Vector3Division = (left, right) => left / right;

		public static readonly Func<Vector3, Vector3, bool> Vector3Equal = (left, right) => left == right;
		public static readonly Func<Vector3, Vector3, bool> Vector3NotEqual = (left, right) => left != right;

		public static readonly Func<Vector3, Vector3, Vector3> Vector3Addition = (left, right) => left + right;
		public static readonly Func<Vector3, Vector3, Vector3> Vector3Subtraction = (left, right) => left - right;
		
		public static readonly Func<int, int, int, Vector3Int> Vector3IntNew = (x, y, z) => new Vector3Int(x, y, z);

		public static readonly Func<Vector3Int, int> Vector3IntGetX = v => v.x;
		public static readonly Func<Vector3Int, int> Vector3IntGetY = v => v.y;
		public static readonly Func<Vector3Int, int> Vector3IntGetZ = v => v.z;
		public static readonly Func<Vector3Int, float> Vector3IntMagnitude = v => v.magnitude;
		public static readonly Func<Vector3Int, int> Vector3IntSqrMagnitude = v => v.sqrMagnitude;

		public static readonly Func<Vector3Int, int, Vector3Int> Vector3IntSetX = (vector, x) =>
		{
			vector.x = x;
			return vector;
		};
		public static readonly Func<Vector3Int, int, Vector3Int> Vector3IntSetY = (vector, y) =>
		{
			vector.y = y;
			return vector;
		};
		public static readonly Func<Vector3Int, int, Vector3Int> Vector3IntSetZ = (vector, z) =>
		{
			vector.z = z;
			return vector;
		};
		public static readonly Func<Vector3Int, int, Vector3Int> Vector3IntIntMultiplication = (left, right) => left * right;

		public static readonly Func<Vector3Int, Vector3Int, bool> Vector3IntEqual = (left, right) => left == right;
		public static readonly Func<Vector3Int, Vector3Int, bool> Vector3IntNotEqual = (left, right) => left != right;

		public static readonly Func<Vector3Int, Vector3Int, Vector3Int> Vector3IntAddition = (left, right) => left + right;
		public static readonly Func<Vector3Int, Vector3Int, Vector3Int> Vector3IntSubtraction = (left, right) => left - right;
		public static readonly Func<Vector3Int, Vector3Int, Vector3Int> Vector3IntVectorMultiplication =
			(left, right) => left * right;

		public static readonly Func<float, float, float, float, Vector4> Vector4New = (x, y, z, w) =>
			new Vector4(x, y, z, w);

		public static readonly Func<Vector4, float> Vector4GetX = v => v.x;
		public static readonly Func<Vector4, float> Vector4GetY = v => v.y;
		public static readonly Func<Vector4, float> Vector4GetZ = v => v.z;
		public static readonly Func<Vector4, float> Vector4GetW = v => v.w;
		public static readonly Func<Vector4, float> Vector4Magnitude = v => v.magnitude;
		public static readonly Func<Vector4, float> Vector4SqrMagnitude = v => v.sqrMagnitude;

		public static readonly Func<Vector4, Vector4> Vector4Normalized = v => v.normalized;
		public static readonly Func<Vector4, Vector4> Vector4Minus = v => -v;

		public static readonly Func<Vector4, float, Vector4> Vector4SetX = (vector, x) =>
		{
			vector.x = x;
			return vector;
		};
		public static readonly Func<Vector4, float, Vector4> Vector4SetY = (vector, y) =>
		{
			vector.y = y;
			return vector;
		};
		public static readonly Func<Vector4, float, Vector4> Vector4SetZ = (vector, z) =>
		{
			vector.z = z;
			return vector;
		};
		public static readonly Func<Vector4, float, Vector4> Vector4SetW = (vector, w) =>
		{
			vector.w = w;
			return vector;
		};
		public static readonly Func<Vector4, float, Vector4> Vector4Multiplication = (left, right) => left * right;
		public static readonly Func<Vector4, float, Vector4> Vector4Division = (left, right) => left / right;

		public static readonly Func<Vector4, Vector4, bool> Vector4Equal = (left, right) => left == right;
		public static readonly Func<Vector4, Vector4, bool> Vector4NotEqual = (left, right) => left != right;

		public static readonly Func<Vector4, Vector4, Vector4> Vector4Addition = (left, right) => left + right;
		public static readonly Func<Vector4, Vector4, Vector4> Vector4Subtraction = (left, right) => left - right;
		
		public static readonly Func<Vector3, Vector3, Bounds> BoundsNew = (center, size) => new Bounds(center, size);
		public static readonly Func<Vector3, Vector3, Bounds> BoundsSetMinMax = (min, max) =>
		{
			var bounds = new Bounds();
			bounds.SetMinMax(min, max);
			return bounds;
		};

		public static readonly Func<Vector3Int, Vector3Int, BoundsInt> BoundsIntNew = (position, size) =>
			new BoundsInt(position, size);
		public static readonly Func<Vector3Int, Vector3Int, BoundsInt> BoundsIntSetMinMax = (min, max) =>
		{
			var bounds = new BoundsInt();
			bounds.SetMinMax(min, max);
			return bounds;
		};
	}
}
