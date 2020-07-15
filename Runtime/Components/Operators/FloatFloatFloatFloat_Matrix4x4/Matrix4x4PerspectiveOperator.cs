// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using UnityEngine;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;
using Zor.EventBasedBlackboard.Workers.Operating;

namespace Zor.EventBasedBlackboard.Components.Operators.FloatFloatFloatFloat_Matrix4x4
{
	[CustomLabelInfo("FOV", nameof(Single), 0)]
	[CustomLabelInfo("Aspect", nameof(Single), 1)]
	[CustomLabelInfo("Z Near", nameof(Single), 2)]
	[CustomLabelInfo("Z Far", nameof(Single), 3)]
	[CustomLabelInfo(null, nameof(Matrix4x4), 4)]
	[AddComponentMenu(BlackboardExtensionsAddComponentConstants.OperatorsFolder + "(Float, Float, Float, Float) => (Matrix4x4)/Matrix4x4 Perspective Operator")]
	public sealed class Matrix4x4PerspectiveOperator :
		SingleReturnQuaternaryOperator<float, float, float, float, Matrix4x4>
	{
		protected override Func<float, float, float, float, Matrix4x4> operation =>
			DefaultOperators.Matrix4x4Perspective;
	}
}
