// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector3_Float
{
	[CustomLabelInfo(null, nameof(Vector3), 0)]
	[CustomLabelInfo(null, nameof(Single), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector3) => (Float)/Vector3 Get Y Operator")]
	public sealed class Vector3GetYOperator : SingleReturnUnaryOperator<Vector3, float>
	{
		protected override Func<Vector3, float> operation => DefaultOperators.Vector3GetY;
	}
}
