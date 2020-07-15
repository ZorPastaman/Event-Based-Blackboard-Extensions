// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using UnityEngine;
using Zor.EventBasedBlackboard.Workers.Conversion;

namespace Zor.EventBasedBlackboard.Components.Converters.FromVector3Int
{
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.ConvertersFolder + "From Vector3 Int/From Vector3 Int To Vector3 Converter")]
	public sealed class FromVector3IntToVector3Converter : Converter<Vector3Int, Vector3>
	{
		protected override System.Converter<Vector3Int, Vector3> converter => DefaultConverters.FromVector3IntToVector3;
	}
}
