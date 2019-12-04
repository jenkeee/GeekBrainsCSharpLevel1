using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3Rational
{
    /// <summary>
    /// Рациональное число
    /// </summary>
    public class Rational
    {
        private int num; //числитель, целое число
        private int denom; //знаменатель, натуральное число
        /// <summary>
        /// Доступ к числителю
        /// </summary>
        public int Num
        {
            get => num;
            set => num = value;
        }
        /// <summary>
        /// Доступ к знаменателю
        /// </summary>
        public int Denom
        {
            get => denom;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("Знаменатель не может быть равен 0");
                }
                denom = value;
            }
        }
        /// <summary>
        /// Рациональное число
        /// </summary>
        /// <param name="num">числитель</param>
        /// <param name="denom">знаменатель</param>
        public Rational(int num, int denom)
        {
            this.num = num;
            this.denom = denom;
        }
        /// <summary>
        /// Суммирование двух чисел
        /// </summary>
        /// <param name="other">второе число</param>
        /// <returns>результат</returns>
        public Rational Plus(Rational other)
        {
            int num = this.num * other.denom + this.denom * other.num;
            int denom = this.denom * other.denom;
            return new Rational(num, denom);
        }
        /// <summary>
        /// Разность двух чисел
        /// </summary>
        /// <param name="other">второе число</param>
        /// <returns>результат</returns>
        public Rational Minus(Rational other)
        {
            int num = this.num * other.denom - this.denom * other.num;
            int denom = this.denom * other.denom;
            return new Rational(num, denom);
        }
        /// <summary>
        /// Произведение двух чисел
        /// </summary>
        /// <param name="other">второе число</param>
        /// <returns>результат</returns>
        public Rational Multi(Rational other)
        {
            int num = this.num * other.num;
            int denom = this.denom * other.denom;
            return new Rational(num, denom);
        }
        /// <summary>
        /// Частное двух чисел
        /// </summary>
        /// <param name="other">второе число</param>
        /// <returns>результат</returns>
        public Rational Divid(Rational other)
        {
            int num = this.num * other.denom;
            int denom = this.denom * other.num;
            return  new Rational(num, denom);
        }
        /// <summary>
        /// Упрощение дробей этого рационального числа
        /// </summary>
        public void DoPrunningRational()
        {
            int min; //минимальное из двух чисел - возможный общий делитель
            if (num < denom)
            {
                min = num / 2;
            }
            else
            {
                min = denom / 2;
            }
            for (int i = min; i >= 2; i--)
            {
                if (num % i == 0 && denom % i == 0)
                {
                    num /= i;
                    denom /= i;
                    break;
                }
            }
        }
        /// <summary>
        /// Получение десятичной дроби числа
        /// </summary>
        public double GetDecValue => Convert.ToDouble(num / denom);
        //Перегрузка обычных бинарных операций
        public static Rational operator +(Rational r1, Rational r2) => r1.Plus(r2);
        public static Rational operator -(Rational r1, Rational r2) => r1.Minus(r2);
        public static Rational operator *(Rational r1, Rational r2) => r1.Multi(r2);
        public static Rational operator /(Rational r1, Rational r2) => r1.Divid(r2);
        /// <summary>
        /// Получение значения в виде строки
        /// </summary>
        /// <returns>строка</returns>
        public override string ToString()
        {
            return $"{num}/{denom}";
        }
    }
}
