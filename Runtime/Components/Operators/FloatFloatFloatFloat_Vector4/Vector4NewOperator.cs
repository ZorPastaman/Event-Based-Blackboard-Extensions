// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.FloatFloatFloatFloat_Vector4
{
	[CustomLabelInfo("X", nameof(Single), 0)]
	[CustomLabelInfo("Y", nameof(Single), 1)]
	[CustomLabelInfo("Z", nameof(Single), 2)]
	[CustomLabelInfo("W", nameof(Single), 3)]
	[CustomLabelInfo(null, nameof(Vector4), 4)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Float, Float, Float, Float) => (Vector4)/Vector4 New Operator")]
	public sealed class Vector4NewOperator : SingleReturnQuaternaryOperator<float, float, float, float, Vector4>
	{
		protected override Func<float, float, float, float, Vector4> operation => DefaultOperators.Vector4New;
	}
}
