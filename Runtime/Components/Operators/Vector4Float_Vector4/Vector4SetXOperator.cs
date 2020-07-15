// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector4Float_Vector4
{
	[CustomLabelInfo(null, nameof(Vector4), 0)]
	[CustomLabelInfo(null, nameof(Single), 1)]
	[CustomLabelInfo(null, nameof(Vector4), 2)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector4, Float) => (Vector4)/Vector4 Set X Operator")]
	public sealed class Vector4SetXOperator : SingleReturnBinaryOperator<Vector4, float, Vector4>
	{
		protected override Func<Vector4, float, Vector4> operation => DefaultOperators.Vector4SetX;
	}
}
