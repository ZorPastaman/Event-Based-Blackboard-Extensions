// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromVector3
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Vector3/From Vector3 To Quaternion Converter")]
	public sealed class FromVector3ToQuaternionConverter : Converter<Vector3, Quaternion>
	{
		protected override System.Converter<Vector3, Quaternion> converter => DefaultConverters.FromVector3ToQuaternion;
	}
}
