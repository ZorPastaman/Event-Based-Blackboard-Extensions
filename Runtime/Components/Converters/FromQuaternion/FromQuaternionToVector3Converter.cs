// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromQuaternion
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Quaternion/From Quaternion To Vector3 Converter")]
	public sealed class FromQuaternionToVector3Converter : Converter<Quaternion, Vector3>
	{
		protected override System.Converter<Quaternion, Vector3> converter => DefaultConverters.FromQuaternionToVector3;
	}
}
