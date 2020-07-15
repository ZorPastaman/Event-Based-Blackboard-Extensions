// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector2Int_Float
{
	[CustomLabelInfo(null, nameof(Vector2Int), 0)]
	[CustomLabelInfo(null, nameof(Single), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector2Int) => (Float)/Vector2Int Magnitude Operator")]
	public sealed class Vector2IntMagnitudeOperator : SingleReturnUnaryOperator<Vector2Int, float>
	{
		protected override Func<Vector2Int, float> operation => DefaultOperators.Vector2IntMagnitude;
	}
}
