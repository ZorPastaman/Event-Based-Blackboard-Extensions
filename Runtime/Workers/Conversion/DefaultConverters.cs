// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Zor.EventBasedBlackboard.Workers.Conversion
{
	/// <summary>
	/// <para>Collection of converters.</para>
	/// <para>It's used not to allocate delegates every time.</para>
	/// </summary>
	public static class DefaultConverters
	{
		public static readonly System.Converter<bool, byte> FromBoolToByte = Convert.ToByte;
		public static readonly System.Converter<bool, int> FromBoolToInt = Convert.ToInt32;
		public static readonly System.Converter<bool, long> FromBoolToLong = Convert.ToInt64;
		public static readonly System.Converter<bool, sbyte> FromBoolToSbyte = Convert.ToSByte;
		public static readonly System.Converter<bool, short> FromBoolToShort = Convert.ToInt16;
		public static readonly System.Converter<bool, uint> FromBoolToUint = Convert.ToUInt32;
		public static readonly System.Converter<bool, ulong> FromBoolToUlong = Convert.ToUInt64;
		public static readonly System.Converter<bool, ushort> FromBoolToUshort = Convert.ToUInt16;

		public static readonly System.Converter<byte, bool> FromByteToBool = Convert.ToBoolean;
		public static readonly System.Converter<byte, double> FromByteToDouble = Convert.ToDouble;
		public static readonly System.Converter<byte, float> FromByteToFloat = Convert.ToSingle;
		public static readonly System.Converter<byte, int> FromByteToInt = Convert.ToInt32;
		public static readonly System.Converter<byte, long> FromByteToLong = Convert.ToInt64;
		public static readonly System.Converter<byte, sbyte> FromByteToSbyte = Convert.ToSByte;
		public static readonly System.Converter<byte, short> FromByteToShort = Convert.ToInt16;
		public static readonly System.Converter<byte, uint> FromByteToUint = Convert.ToUInt32;
		public static readonly System.Converter<byte, ulong> FromByteToUlong = Convert.ToUInt64;
		public static readonly System.Converter<byte, ushort> FromByteToUshort = Convert.ToUInt16;

		public static readonly System.Converter<Color, Vector4> FromColorToVector4 = c => c;

		public static readonly System.Converter<Component, Object> FromComponentToObject = c => c;
		public static readonly System.Converter<Component, Transform> FromComponentToTransform = c => c as Transform;

		public static readonly System.Converter<double, byte> FromDoubleToByte = Convert.ToByte;
		public static readonly System.Converter<double, float> FromDoubleToFloat = Convert.ToSingle;
		public static readonly System.Converter<double, int> FromDoubleToInt = Convert.ToInt32;
		public static readonly System.Converter<double, long> FromDoubleToLong = Convert.ToInt64;
		public static readonly System.Converter<double, sbyte> FromDoubleToSbyte = Convert.ToSByte;
		public static readonly System.Converter<double, short> FromDoubleToShort = Convert.ToInt16;
		public static readonly System.Converter<double, uint> FromDoubleToUint = Convert.ToUInt32;
		public static readonly System.Converter<double, ulong> FromDoubleToUlong = Convert.ToUInt64;
		public static readonly System.Converter<double, ushort> FromDoubleToUshort = Convert.ToUInt16;

		public static readonly System.Converter<float, byte> FromFloatToByte = Convert.ToByte;
		public static readonly System.Converter<float, double> FromFloatToDouble = Convert.ToDouble;
		public static readonly System.Converter<float, int> FromFloatToInt = Convert.ToInt32;
		public static readonly System.Converter<float, long> FromFloatToLong = Convert.ToInt64;
		public static readonly System.Converter<float, sbyte> FromFloatToSbyte = Convert.ToSByte;
		public static readonly System.Converter<float, short> FromFloatToShort = Convert.ToInt16;
		public static readonly System.Converter<float, uint> FromFloatToUint = Convert.ToUInt32;
		public static readonly System.Converter<float, ulong> FromFloatToUlong = Convert.ToUInt64;
		public static readonly System.Converter<float, ushort> FromFloatToUshort = Convert.ToUInt16;

		public static readonly System.Converter<GameObject, Object> FromGameObjectToObject = go => go;

		public static readonly System.Converter<int, bool> FromIntToBool = Convert.ToBoolean;
		public static readonly System.Converter<int, byte> FromIntToByte = Convert.ToByte;
		public static readonly System.Converter<int, double> FromIntToDouble = Convert.ToDouble;
		public static readonly System.Converter<int, float> FromIntToFloat = Convert.ToSingle;
		public static readonly System.Converter<int, LayerMask> FromIntToLayerMask = i => i;
		public static readonly System.Converter<int, long> FromIntToLong = Convert.ToInt64;
		public static readonly System.Converter<int, sbyte> FromIntToSbyte = Convert.ToSByte;
		public static readonly System.Converter<int, short> FromIntToShort = Convert.ToInt16;
		public static readonly System.Converter<int, uint> FromIntToUint = Convert.ToUInt32;
		public static readonly System.Converter<int, ulong> FromIntToUlong = Convert.ToUInt64;
		public static readonly System.Converter<int, ushort> FromIntToUshort = Convert.ToUInt16;

		public static readonly System.Converter<LayerMask, int> FromLayerMaskToInt = lm => lm;

		public static readonly System.Converter<long, bool> FromLongToBool = Convert.ToBoolean;
		public static readonly System.Converter<long, byte> FromLongToByte = Convert.ToByte;
		public static readonly System.Converter<long, double> FromLongToDouble = Convert.ToDouble;
		public static readonly System.Converter<long, float> FromLongToFloat = Convert.ToSingle;
		public static readonly System.Converter<long, int> FromLongToInt = Convert.ToInt32;
		public static readonly System.Converter<long, sbyte> FromLongToSbyte = Convert.ToSByte;
		public static readonly System.Converter<long, short> FromLongToShort = Convert.ToInt16;
		public static readonly System.Converter<long, uint> FromLongToUint = Convert.ToUInt32;
		public static readonly System.Converter<long, ulong> FromLongToUlong = Convert.ToUInt64;
		public static readonly System.Converter<long, ushort> FromLongToUshort = Convert.ToUInt16;

		public static readonly System.Converter<Object, Component> FromObjectToComponent = o => o as Component;
		public static readonly System.Converter<Object, GameObject> FromObjectToGameObject = o => o as GameObject;
		public static readonly System.Converter<Object, Transform> FromObjectToTransform = o => o as Transform;

		public static readonly System.Converter<Quaternion, Vector3> FromQuaternionToVector3 = q => q.eulerAngles;
		public static readonly System.Converter<Quaternion, Vector4> FromQuaternionToVector4 = q =>
			new Vector4(q.x, q.y, q.z, q.w);

		public static readonly System.Converter<sbyte, bool> FromSbyteToBool = Convert.ToBoolean;
		public static readonly System.Converter<sbyte, byte> FromSbyteToByte = Convert.ToByte;
		public static readonly System.Converter<sbyte, double> FromSbyteToDouble = Convert.ToDouble;
		public static readonly System.Converter<sbyte, float> FromSbyteToFloat = Convert.ToSingle;
		public static readonly System.Converter<sbyte, int> FromSbyteToInt = Convert.ToInt32;
		public static readonly System.Converter<sbyte, long> FromSbyteToLong = Convert.ToInt64;
		public static readonly System.Converter<sbyte, short> FromSbyteToShort = Convert.ToInt16;
		public static readonly System.Converter<sbyte, uint> FromSbyteToUint = Convert.ToUInt32;
		public static readonly System.Converter<sbyte, ulong> FromSbyteToUlong = Convert.ToUInt64;
		public static readonly System.Converter<sbyte, ushort> FromSbyteToUshort = Convert.ToUInt16;

		public static readonly System.Converter<short, bool> FromShortToBool = Convert.ToBoolean;
		public static readonly System.Converter<short, byte> FromShortToByte = Convert.ToByte;
		public static readonly System.Converter<short, double> FromShortToDouble = Convert.ToDouble;
		public static readonly System.Converter<short, float> FromShortToFloat = Convert.ToSingle;
		public static readonly System.Converter<short, int> FromShortToInt = Convert.ToInt32;
		public static readonly System.Converter<short, long> FromShortToLong = Convert.ToInt64;
		public static readonly System.Converter<short, sbyte> FromShortToSbyte = Convert.ToSByte;
		public static readonly System.Converter<short, uint> FromShortToUint = Convert.ToUInt32;
		public static readonly System.Converter<short, ulong> FromShortToUlong = Convert.ToUInt64;
		public static readonly System.Converter<short, ushort> FromShortToUshort = Convert.ToUInt16;

		public static readonly System.Converter<Transform, Component> FromTransformToComponent = t => t;
		public static readonly System.Converter<Transform, Object> FromTransformToObject = t => t;

		public static readonly System.Converter<uint, bool> FromUintToBool = Convert.ToBoolean;
		public static readonly System.Converter<uint, byte> FromUintToByte = Convert.ToByte;
		public static readonly System.Converter<uint, double> FromUintToDouble = Convert.ToDouble;
		public static readonly System.Converter<uint, float> FromUintToFloat = Convert.ToSingle;
		public static readonly System.Converter<uint, int> FromUintToInt = Convert.ToInt32;
		public static readonly System.Converter<uint, long> FromUintToLong = Convert.ToInt64;
		public static readonly System.Converter<uint, sbyte> FromUintToSbyte = Convert.ToSByte;
		public static readonly System.Converter<uint, short> FromUintToShort = Convert.ToInt16;
		public static readonly System.Converter<uint, ulong> FromUintToUlong = Convert.ToUInt64;
		public static readonly System.Converter<uint, ushort> FromUintToUshort = Convert.ToUInt16;

		public static readonly System.Converter<ulong, bool> FromUlongToBool = Convert.ToBoolean;
		public static readonly System.Converter<ulong, byte> FromUlongToByte = Convert.ToByte;
		public static readonly System.Converter<ulong, double> FromUlongToDouble = Convert.ToDouble;
		public static readonly System.Converter<ulong, float> FromUlongToFloat = Convert.ToSingle;
		public static readonly System.Converter<ulong, int> FromUlongToInt = Convert.ToInt32;
		public static readonly System.Converter<ulong, long> FromUlongToLong = Convert.ToInt64;
		public static readonly System.Converter<ulong, sbyte> FromUlongToSbyte = Convert.ToSByte;
		public static readonly System.Converter<ulong, short> FromUlongToShort = Convert.ToInt16;
		public static readonly System.Converter<ulong, uint> FromUlongToUint = Convert.ToUInt32;
		public static readonly System.Converter<ulong, ushort> FromUlongToUshort = Convert.ToUInt16;

		public static readonly System.Converter<ushort, bool> FromUshortToBool = Convert.ToBoolean;
		public static readonly System.Converter<ushort, byte> FromUshortToByte = Convert.ToByte;
		public static readonly System.Converter<ushort, double> FromUshortToDouble = Convert.ToDouble;
		public static readonly System.Converter<ushort, float> FromUshortToFloat = Convert.ToSingle;
		public static readonly System.Converter<ushort, int> FromUshortToInt = Convert.ToInt32;
		public static readonly System.Converter<ushort, long> FromUshortToLong = Convert.ToInt64;
		public static readonly System.Converter<ushort, sbyte> FromUshortToSbyte = Convert.ToSByte;
		public static readonly System.Converter<ushort, short> FromUshortToShort = Convert.ToInt16;
		public static readonly System.Converter<ushort, uint> FromUshortToUint = Convert.ToUInt32;
		public static readonly System.Converter<ushort, ulong> FromUshortToUlong = Convert.ToUInt64;

		public static readonly System.Converter<Vector2, Vector2Int> FromVector2ToVector2IntCeil = Vector2Int.CeilToInt;
		public static readonly System.Converter<Vector2, Vector2Int> FromVector2ToVector2IntFloor =
			Vector2Int.FloorToInt;
		public static readonly System.Converter<Vector2, Vector2Int> FromVector2ToVector2IntRound =
			Vector2Int.RoundToInt;
		public static readonly System.Converter<Vector2, Vector3> FromVector2ToVector3XY = v => new Vector3(v.x, v.y);
		public static readonly System.Converter<Vector2, Vector3> FromVector2ToVector3XZ = v =>
			new Vector3(v.x, 0f, v.y);
		public static readonly System.Converter<Vector2, Vector3> FromVector2ToVector3YZ = v =>
			new Vector3(0f, v.x, v.y);
		public static readonly System.Converter<Vector2, Vector4> FromVector2ToVector4XY = v => new Vector4(v.x, v.y);
		public static readonly System.Converter<Vector2, Vector4> FromVector2ToVector4XZ = v =>
			new Vector4(v.x, 0f, v.y);
		public static readonly System.Converter<Vector2, Vector4> FromVector2ToVector4XW = v =>
			new Vector4(v.x, 0f, 0f, v.y);
		public static readonly System.Converter<Vector2, Vector4> FromVector2ToVector4YZ = v =>
			new Vector4(0f, v.x, v.y);
		public static readonly System.Converter<Vector2, Vector4> FromVector2ToVector4YW = v =>
			new Vector4(0f, v.x, 0f, v.y);
		public static readonly System.Converter<Vector2, Vector4> FromVector2ToVector4ZW = v =>
			new Vector4(0f, 0f, v.x, v.y);

		public static readonly System.Converter<Vector2Int, Vector2> FromVector2IntToVector2 = v => v;
		public static readonly System.Converter<Vector2Int, Vector3Int> FromVector2IntToVector3IntXY = v =>
			new Vector3Int(v.x, v.y, 0);
		public static readonly System.Converter<Vector2Int, Vector3Int> FromVector2IntToVector3IntXZ = v =>
			new Vector3Int(v.x, 0, v.y);
		public static readonly System.Converter<Vector2Int, Vector3Int> FromVector2IntToVector3IntYZ = v =>
			new Vector3Int(0, v.x, v.y);

		public static readonly System.Converter<Vector3, Quaternion> FromVector3ToQuaternion = Quaternion.Euler;
		public static readonly System.Converter<Vector3, Vector2> FromVector3ToVector2XY = v => new Vector2(v.x, v.y);
		public static readonly System.Converter<Vector3, Vector2> FromVector3ToVector2XZ = v => new Vector2(v.x, v.z);
		public static readonly System.Converter<Vector3, Vector2> FromVector3ToVector2YZ = v => new Vector2(v.y, v.z);
		public static readonly System.Converter<Vector3, Vector3Int> FromVector3ToVector3IntCeil = Vector3Int.CeilToInt;
		public static readonly System.Converter<Vector3, Vector3Int> FromVector3ToVector3IntFloor =
			Vector3Int.FloorToInt;
		public static readonly System.Converter<Vector3, Vector3Int> FromVector3ToVector3IntRound =
			Vector3Int.RoundToInt;
		public static readonly System.Converter<Vector3, Vector4> FromVector3ToVector4XYZ = v =>
			new Vector4(v.x, v.y, v.z);
		public static readonly System.Converter<Vector3, Vector4> FromVector3ToVector4YZW = v =>
			new Vector4(0f, v.x, v.y, v.z);

		public static readonly System.Converter<Vector3Int, Vector2Int> FromVector3IntToVector2IntXY = v =>
			new Vector2Int(v.x, v.y);
		public static readonly System.Converter<Vector3Int, Vector2Int> FromVector3IntToVector2IntXZ = v =>
			new Vector2Int(v.x, v.z);
		public static readonly System.Converter<Vector3Int, Vector2Int> FromVector3IntToVector2IntYZ = v =>
			new Vector2Int(v.y, v.z);
		public static readonly System.Converter<Vector3Int, Vector3> FromVector3IntToVector3 = v => v;

		public static readonly System.Converter<Vector4, Color> FromVector4ToColor = v => v;
		public static readonly System.Converter<Vector4, Quaternion> FromVector4ToQuaternion = v =>
			new Quaternion(v.x, v.y, v.z, v.w);
		public static readonly System.Converter<Vector4, Vector2> FromVector4ToVector2XY = v => new Vector2(v.x, v.y);
		public static readonly System.Converter<Vector4, Vector2> FromVector4ToVector2XZ = v => new Vector2(v.x, v.z);
		public static readonly System.Converter<Vector4, Vector2> FromVector4ToVector2XW = v => new Vector2(v.x, v.w);
		public static readonly System.Converter<Vector4, Vector2> FromVector4ToVector2YZ = v => new Vector2(v.y, v.z);
		public static readonly System.Converter<Vector4, Vector2> FromVector4ToVector2YW = v => new Vector2(v.y, v.w);
		public static readonly System.Converter<Vector4, Vector2> FromVector4ToVector2ZW = v => new Vector2(v.z, v.w);
		public static readonly System.Converter<Vector4, Vector3> FromVector4ToVector3XYZ = v =>
			new Vector3(v.x, v.y, v.z);
		public static readonly System.Converter<Vector4, Vector3> FromVector4ToVector3YZW = v =>
			new Vector3(v.y, v.z, v.w);
	}
}
