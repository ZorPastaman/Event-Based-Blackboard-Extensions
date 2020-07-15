// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector2_Float
{
	[CustomLabelInfo(null, nameof(Vector2), 0)]
	[CustomLabelInfo(null, nameof(Single), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector2) => (Float)/Vector2 Get Y Operator")]
	public sealed class Vector2GetYOperator : SingleReturnUnaryOperator<Vector2, float>
	{
		protected override Func<Vector2, float> operation => DefaultOperators.Vector2GetY;
	}
}
