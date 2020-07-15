// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoundsVector3_Bounds
{
	[CustomLabelInfo("Bounds", nameof(Bounds), 0)]
	[CustomLabelInfo("Point", nameof(Vector3), 1)]
	[CustomLabelInfo(null, nameof(Boolean), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bounds, Vector3) => (Bounds)/Bounds Encapsulate Operator")]
	public sealed class BoundsEncapsulateOperator : SingleReturnBinaryOperator<Bounds, Vector3, Bounds>
	{
		protected override Func<Bounds, Vector3, Bounds> operation => DefaultOperators.BoundsEncapsulate;
	}
}
