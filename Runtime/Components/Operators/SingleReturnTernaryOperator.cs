// Copyright (c) 2019-2020 Vladimir Popov zor1994@gmail.com https://github.com/ZorPastaman/Event-Based-Blackboard-Extensions

using System;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using UnityEngine;
using Zor.EventBasedBlackboard.Core;
using Zor.EventBasedBlackboard.PropertyAttributes.CustomLabel;

namespace Zor.EventBasedBlackboard.Components.Operators
{
	/// <summary>
	/// <para>Operates an operation with blackboard properties of types <typeparamref name="TFirstOperand"/>,
	/// <typeparamref name="TSecondOperand"/> and <typeparamref name="TThirdOperand"/>
	/// that returns a property of type <typeparamref name="TResult"/>.</para>
	/// <para>Inherit this to implement a new operator.</para>
	/// </summary>
	/// <typeparam name="TFirstOperand">First operand value type.</typeparam>
	/// <typeparam name="TSecondOperand">Second operand value type.</typeparam>
	/// <typeparam name="TThirdOperand">Third operand value type.</typeparam>
	/// <typeparam name="TResult">Result value type.</typeparam>
	/// <remarks>
	/// It's a component wrapper over
	/// <see cref="Zor.EventBasedBlackboard.Workers.Operating.SingleReturnTernaryOperator{TFirstOperand,TSecondOperand,TThirdOperand,TResult}"/>
	/// </remarks>
	public abstract class SingleReturnTernaryOperator<TFirstOperand, TSecondOperand, TThirdOperand, TResult> :
		MonoBehaviour
	{
#pragma warning disable CS0649
		[SerializeField, CustomLabel(0)] private BlackboardPropertyReference m_FirstOperand;
		[SerializeField, CustomLabel(1)] private BlackboardPropertyReference m_SecondOperand;
		[SerializeField, CustomLabel(2)] private BlackboardPropertyReference m_ThirdOperand;
		[SerializeField, CustomLabel(3)] private BlackboardPropertyReference m_Result;
		[SerializeField] private bool m_OperateOnEnable = true;
#pragma warning restore CS0649

		private Workers.Operating.SingleReturnTernaryOperator<TFirstOperand, TSecondOperand, TThirdOperand, TResult>
			m_operator;

		public BlackboardPropertyReference firstOperand
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_FirstOperand;
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => m_FirstOperand = value;
		}

		public BlackboardPropertyReference secondOperand
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_SecondOperand;
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => m_SecondOperand = value;
		}

		public BlackboardPropertyReference thirdOperand
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_ThirdOperand;
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => m_ThirdOperand = value;
		}

		public BlackboardPropertyReference result
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_Result;
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => m_Result = value;
		}

		public bool operateOnEnable
		{
			[MethodImpl(MethodImplOptions.AggressiveInlining), Pure]
			get => m_OperateOnEnable;
			[MethodImpl(MethodImplOptions.AggressiveInlining)]
			set => m_OperateOnEnable = value;
		}

		[NotNull]
		protected abstract Func<TFirstOperand, TSecondOperand, TThirdOperand, TResult> operation { get; }

		[ContextMenu("Recreate Operator")]
		public void RecreateOperator()
		{
			if (m_operator == null)
			{
				return;
			}

			bool wasEnabled = m_operator.enabled;
			m_operator.enabled = false;
			Awake();
			m_operator.enabled = wasEnabled;
		}

		private void Awake()
		{
			m_operator = new Workers.Operating.SingleReturnTernaryOperator<TFirstOperand, TSecondOperand,
				TThirdOperand, TResult>(m_FirstOperand.blackboardContainer.blackboard,
				new BlackboardPropertyName(m_FirstOperand.propertyName),
				m_SecondOperand.blackboardContainer.blackboard,
				new BlackboardPropertyName(m_SecondOperand.propertyName),
				m_ThirdOperand.blackboardContainer.blackboard,
				new BlackboardPropertyName(m_ThirdOperand.propertyName),
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
