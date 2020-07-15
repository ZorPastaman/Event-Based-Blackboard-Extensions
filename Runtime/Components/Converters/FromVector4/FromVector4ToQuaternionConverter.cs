// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromVector4
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Vector4/From Vector4 To Quaternion Converter")]
	public sealed class FromVector4ToQuaternionConverter : Converter<Vector4, Quaternion>
	{
		protected override System.Converter<Vector4, Quaternion> converter => DefaultConverters.FromVector4ToQuaternion;
	}
}
