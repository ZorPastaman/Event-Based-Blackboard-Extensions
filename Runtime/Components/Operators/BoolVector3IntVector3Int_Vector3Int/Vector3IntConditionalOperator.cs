// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.BoolVector3IntVector3Int_Vector3Int
{
	[CustomLabelInfo("Condition", nameof(Boolean), 0)]
	[CustomLabelInfo("True", nameof(Vector3Int), 1)]
	[CustomLabelInfo("False", nameof(Vector3Int), 2)]
	[CustomLabelInfo(null, nameof(Vector3Int), 3)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Bool, Vector3Int, Vector3Int) => (Vector3Int)/Vector3Int Conditional Operator")]
	public sealed class Vector3IntConditionalOperator :
		SingleReturnTernaryOperator<bool, Vector3Int, Vector3Int, Vector3Int>
	{
		protected override Func<bool, Vector3Int, Vector3Int, Vector3Int> operation =>
			DefaultOperators.Vector3IntConditional;
	}
}
