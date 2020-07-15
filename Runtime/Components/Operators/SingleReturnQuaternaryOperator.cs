// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using JetBrains.Annotations;
using UnityEngine;
using Zor.EventBasedBlackboard.Core;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;

namespace Zor.EventBasedBlackboard.Components.Operators
{
	/// <summary>
	/// <para>Operates an operation with blackboard properties of types <typeparamref name="TFirstOperand"/>,
	/// <typeparamref name="TSecondOperand"/>, <typeparamref name="TThirdOperand"/>
	/// and <typeparamref name="TFourthOperand"/> that returns a property of type <typeparamref name="TResult"/>.</para>
	/// <para>Inherit this to implement a new operator.</para>
	/// </summary>
	/// <typeparam name="TFirstOperand">First operand value type.</typeparam>
	/// <typeparam name="TSecondOperand">Second operand value type.</typeparam>
	/// <typeparam name="TThirdOperand">Third operand value type.</typeparam>
	/// <typeparam name="TFourthOperand">Fourth operand value type.</typeparam>
	/// <typeparam name="TResult">Result value type.</typeparam>
	/// <remarks>
	/// It's a component wrapper over
	/// <see cref="Zor.EventBasedBlackboard.Workers.Operating.SingleReturnQuaternaryOperator{TFirstOperand,TSecondOperand,TThirdOperand,TFourthOperand,TResult}"/>
	/// </remarks>
	public abstract class SingleReturnQuaternaryOperator<TFirstOperand, TSecondOperand, TThirdOperand, TFourthOperand,
		TResult> : MonoBehaviour
	{
#pragma warning disable CS0649
		[SerializeField, CustomLabel(0)] private BlackboardPropertyReference m_FirstOperand;
		[SerializeField, CustomLabel(1)] private BlackboardPropertyReference m_SecondOperand;
		[SerializeField, CustomLabel(2)] private BlackboardPropertyReference m_ThirdOperand;
		[SerializeField, CustomLabel(3)] private BlackboardPropertyReference m_FourthOperand;
		[SerializeField, CustomLabel(4)] private BlackboardPropertyReference m_Result;
		[SerializeField] private bool m_OperateOnEnable = true;
#pragma warning restore CS0649

		private Workers.Operating.SingleReturnQuaternaryOperator<TFirstOperand, TSecondOperand, TThirdOperand,
			TFourthOperand, TResult> m_operator;

		/// <summary>
		/// Operation function.
		/// </summary>
		[NotNull]
		protected abstract Func<TFirstOperand, TSecondOperand, TThirdOperand, TFourthOperand, TResult>
			operation { get; }

		private void Awake()
		{
			m_operator = new Workers.Operating.SingleReturnQuaternaryOperator<TFirstOperand, TSecondOperand,
				TThirdOperand, TFourthOperand, TResult>(m_FirstOperand.blackboardContainer.blackboard,
				new BlackboardPropertyName(m_FirstOperand.propertyName),
				m_SecondOperand.blackboardContainer.blackboard,
				new BlackboardPropertyName(m_SecondOperand.propertyName),
				m_ThirdOperand.blackboardContainer.blackboard,
				new BlackboardPropertyName(m_ThirdOperand.propertyName),
				m_FourthOperand.blackboardContainer.blackboard,
				new BlackboardPropertyName(m_FourthOperand.propertyName),
				m_Result.blackboardContainer.blackboard,
				new BlackboardPropertyName(m_Result.propertyName),
				m_OperateOnEnable,
				operation);
		}

		private void OnEnable()
		{
			m_operator.enabled = true;
		}

		private void OnDisable()
		{
			m_operator.enabled = false;
		}
	}
}
