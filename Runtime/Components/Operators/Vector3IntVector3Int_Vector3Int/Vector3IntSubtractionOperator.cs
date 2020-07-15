// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector3IntVector3Int_Vector3Int
{
	[CustomLabelInfo(null, nameof(Vector3Int), 0)]
	[CustomLabelInfo(null, nameof(Vector3Int), 1)]
	[CustomLabelInfo(null, nameof(Vector3Int), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector3Int, Vector3Int) => (Vector3Int)/Vector3Int Subtraction Operator")]
	public sealed class Vector3IntSubtractionOperator : SingleReturnBinaryOperator<Vector3Int, Vector3Int, Vector3Int>
	{
		protected override Func<Vector3Int, Vector3Int, Vector3Int> operation => DefaultOperators.Vector3IntSubtraction;
	}
}
