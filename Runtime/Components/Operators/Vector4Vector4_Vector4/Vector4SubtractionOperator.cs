// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector4Vector4_Vector4
{
	[CustomLabelInfo(null, nameof(Vector4), 0)]
	[CustomLabelInfo(null, nameof(Vector4), 1)]
	[CustomLabelInfo(null, nameof(Vector4), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector4, Vector4) => (Vector4)/Vector4 Subtraction Operator")]
	public sealed class Vector4SubtractionOperator : SingleReturnBinaryOperator<Vector4, Vector4, Vector4>
	{
		protected override Func<Vector4, Vector4, Vector4> operation => DefaultOperators.Vector4Subtraction;
	}
}
