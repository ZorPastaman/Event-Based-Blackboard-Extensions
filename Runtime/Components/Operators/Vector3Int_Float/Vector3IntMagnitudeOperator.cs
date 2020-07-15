// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector3Int_Int
{
	[CustomLabelInfo(null, nameof(Vector3Int), 0)]
	[CustomLabelInfo(null, nameof(Single), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector3Int) => (Int)/Vector3Int Magnitude Operator")]
	public sealed class Vector3IntMagnitudeOperator : SingleReturnUnaryOperator<Vector3Int, float>
	{
		protected override Func<Vector3Int, float> operation => DefaultOperators.Vector3IntMagnitude;
	}
}
