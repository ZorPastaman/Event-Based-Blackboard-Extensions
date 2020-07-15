// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.FloatFloatFloat_Vector3
{
	[CustomLabelInfo("X", nameof(Single), 0)]
	[CustomLabelInfo("Y", nameof(Single), 1)]
	[CustomLabelInfo("Z", nameof(Single), 2)]
	[CustomLabelInfo(null, nameof(Vector3), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Float, Float, Float) => (Vector3)/Vector3 New Operator")]
	public sealed class Vector3NewOperator : SingleReturnTernaryOperator<float, float, float, Vector3>
	{
		protected override Func<float, float, float, Vector3> operation => DefaultOperators.Vector3New;
	}
}
