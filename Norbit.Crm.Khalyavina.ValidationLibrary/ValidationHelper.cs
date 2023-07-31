using System;
using System.Collections.Generic;
using System.Linq;

namespace Norbit.Crm.Khalyavina.ValidationLibrary
{
	/// <summary>
	/// Проверяет правильность полученных значений.
	/// </summary>
	public static class ValidationHelper
	{
		/// <summary>
		/// Проверяет является ли <paramref name="n"/> положительным.
		/// </summary>
		/// <param name="n">Число.</param>
		/// <exception cref="ArgumentOutOfRangeException">Число не положительное.</exception>
		public static void CheckPositiveNumber(int n)
		{
			if (n <= 0)
			{
				throw new ArgumentOutOfRangeException(nameof(n),
					"Введено не положительное число.");
			}
		}

		/// <summary>
		/// Проверяет массив <paramref name="array"/> на пустоту.
		/// </summary>
		/// <param name="array">Массив.</param>
		/// <exception cref="ArgumentNullException">Передан пустой массив.</exception>
		public static void CheckEmptyArray<T>(IEnumerable<T> array)
		{
			if ((array == null) || (array.Count() <= 0))
			{
				throw new ArgumentNullException(nameof(array),
					"Массив пуст или не создан.");
			}
		}

		/// <summary>
		/// Проверяет находится ли индекс <paramref name="index"/> в массиве ёмкостью <paramref name="capacity"/>.
		/// </summary>
		/// <param name="index">Индекс.</param>
		/// <param name="capacity">Ёмкость массива.</param>
		/// <exception cref="ArgumentOutOfRangeException">Индекс находится за пределами массива.</exception>
		public static void CheckArrayIndex(int index, int capacity)
		{
			if (index >= capacity || index < 0)
			{
				throw new ArgumentOutOfRangeException(nameof(index), "Индекс находится за пределами массива.");
			}
		}

		/// <summary>
		/// Проверяет элемент <paramref name="element"/> на пустоту.
		/// </summary>
		/// <param name="element">Элемент.</param>
		/// <exception cref="ArgumentNullException">Передан пустой элемент.</exception>
		public static void CheckNullElement<T>(T element, string elementName)
		{
			if (element == null)
			{
				throw new ArgumentNullException(elementName,
					"Элемент не создан.");
			}
		}
	}
}
