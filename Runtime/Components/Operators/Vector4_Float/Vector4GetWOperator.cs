// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.Vector4_Float
{
	[CustomLabelInfo(null, nameof(Vector4), 0)]
	[CustomLabelInfo(null, nameof(Single), 1)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Vector4) => (Float)/Vector4 Get W Operator")]
	public sealed class Vector4GetWOperator : SingleReturnUnaryOperator<Vector4, float>
	{
		protected override Func<Vector4, float> operation => DefaultOperators.Vector4GetW;
	}
}
