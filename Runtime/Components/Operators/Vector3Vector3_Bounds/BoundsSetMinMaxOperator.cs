// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector3Vector3_Bounds
{
	[CustomLabelInfo("Min", nameof(Vector3), 0)]
	[CustomLabelInfo("Max", nameof(Vector3), 1)]
	[CustomLabelInfo(null, nameof(Bounds), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector3, Vector3) => (Bounds)/Bounds Set Min Max Operator")]
	public sealed class BoundsSetMinMaxOperator : SingleReturnBinaryOperator<Vector3, Vector3, Bounds>
	{
		protected override Func<Vector3, Vector3, Bounds> operation => DefaultOperators.BoundsSetMinMax;
	}
}
