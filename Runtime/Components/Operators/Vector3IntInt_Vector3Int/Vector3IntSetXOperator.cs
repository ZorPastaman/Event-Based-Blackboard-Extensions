// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector3IntInt_Vector3Int
{
	[CustomLabelInfo(null, nameof(Vector3Int), 0)]
	[CustomLabelInfo(null, nameof(Int32), 1)]
	[CustomLabelInfo(null, nameof(Vector3Int), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector3Int, Int) => (Vector3Int)/Vector3Int Set X Operator")]
	public sealed class Vector3IntSetXOperator : SingleReturnBinaryOperator<Vector3Int, int, Vector3Int>
	{
		protected override Func<Vector3Int, int, Vector3Int> operation => DefaultOperators.Vector3IntSetX;
	}
}
