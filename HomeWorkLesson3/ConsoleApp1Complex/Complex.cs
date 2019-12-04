using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Complex
{
    #region Структура комплексного числа
    /// <summary>
    /// Комплексное число
    /// </summary>
    public struct SComplex
    {
        private double re; //вещественная часть
        private double im; //мнимая часть
        public SComplex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        private SComplex Plus(SComplex other)
        {
            SComplex returnMe;
            returnMe.re = re + other.re;
            returnMe.im = im + other.im;
            return returnMe;
        }
        private SComplex Multi(SComplex other)
        {
            SComplex returnMe;
            returnMe.re = re * other.re - im * other.im;
            returnMe.im = im * other.re + re * other.im;
            return returnMe;
        }
        private SComplex Minus(SComplex other)
        {
            SComplex returnMe;
            returnMe.re = re - other.re;
            returnMe.im = im - other.im;
            return returnMe;
        }
        //перегрузка простых бинарных операций
        public static SComplex operator +(SComplex c1, SComplex c2) => c1.Plus(c2);
        public static SComplex operator -(SComplex c1, SComplex c2) => c1.Minus(c2);
        public static SComplex operator *(SComplex c1, SComplex c2) => c1.Multi(c2);
        public override string ToString()
        {
            return $"{re}+{im}i";
        }
    }
    #endregion

    /// <summary>
    /// Комплексное число
    /// </summary>
    public class Complex
    {
        private double re = 0; //вещественная часть
        private double im = 0; //мнимая часть
        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        /// <param name="re">вещественная часть</param>
        /// <param name="im">мнимая часть</param>
        public Complex(double re, double im)
        {
            this.re = re;
            this.im = im;
        }
        /// <summary>
        /// Сумма комплексного числа
        /// по формуле (a+bi)+(c+di)=(a+c)+(b+d)i
        /// </summary>
        /// <param name="other">другое число</param>
        /// <returns>результат</returns>
        private Complex Plus(Complex other)
        {
            double re = this.re + other.re;
            double im = this.im + other.im;
            return new Complex(re, im);
        }
        /// <summary>
        /// Разность чисел
        /// по формуле (a+bi)-(c+di)=(a-c)+(b-d)i
        /// </summary>
        /// <param name="other">другое число</param>
        /// <returns>результат</returns>
        private Complex Minus(Complex other)
        {
            double re = this.re - other.re;
            double im = this.im - other.im;
            return new Complex(re, im);
        }
        /// <summary>
        /// Произведение чисел
        /// по формуле (a+bi)*(c+di)=ac+bci+adi+bdi^{2}=(ac+bdi^{2})+(bc+ad)i=(ac-bd)+(bc+ad)i
        /// </summary>
        /// <param name="other">другое число</param>
        /// <returns>результат</returns>
        private Complex Multi(Complex other)
        {
            double re = this.re * other.re - this.im * other.im;
            double im = this.im * other.re + this.re * other.im;  
            return new Complex(re, im);
        }
        /// <summary>
        /// Деление чисел
        /// по формуле {a+bi}{c+di}=(a+bi)(c-di\right)(c+di\right)(c-di\right)={ac+bd}{c^{2}+d^{2}}+({{bc-ad}{c^{2}+d^{2}}})i
        /// </summary>
        /// <param name="other">другое число</param>
        /// <returns>результат</returns>
        private Complex Divide(Complex other)
        {
            double re = (this.re * other.re + this.im * other.im) / (Math.Pow(other.re, 2) + Math.Pow(other.im, 2));
            double im = (this.im * other.re - this.re * other.im) / (Math.Pow(other.re, 2) + Math.Pow(other.im, 2));
            return new Complex(re, im);
        }
        //перегрузка обычных бинарных операций
        public static Complex operator +(Complex c1, Complex c2) => c1.Plus(c2);
        public static Complex operator -(Complex c1, Complex c2) => c1.Minus(c2);
        public static Complex operator *(Complex c1, Complex c2) => c1.Multi(c2);
        public static Complex operator /(Complex c1, Complex c2) => c1.Divide(c2);
        /// <summary>
        /// Вещественная часть
        /// </summary>
        public double Re
        {
            get => re;
            set => re = value;
        }
        /// <summary>
        /// Мнимая часть
        /// </summary>
        public double Im
        {
            get => im;
            set => im = value;
        }
        /// <summary>
        /// Строка комплексного числа
        /// </summary>
        /// <returns>строка</returns>
        public override string ToString()
        {
            return $"{re}+{im}i";
        }
    }
}
