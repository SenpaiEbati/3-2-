using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_курс_2_задание
{
    class Element
    {
        private string _First, _Second;

        public string First { get { return _First; } set { if (value != null) _First = value; } }
        public string Second { get { return _Second; } set { if (value != null) _Second = value; } }

        public Element() : this("ж","з") { }

        public Element(string nFirst, string nSecond) 
        {
            _First = nFirst != null ? nFirst : "ж";
            _Second = nSecond != null ? nSecond : "з";
        }

        public override string ToString()
        {
            return "[" + _First + "]{" + _Second + "}";
        }

        public override bool Equals(object obj)
        {
            return obj is Element element &&
                   _First == element._First &&
                   _Second == element._Second &&
                   First == element.First &&
                   Second == element.Second;
        }

        public override int GetHashCode()
        {
            int hashCode = 777291660;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_First);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(_Second);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(First);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Second);
            return hashCode;
        }

        public static Element operator -(Element Left, Element Right)
        {
            if ((Right._First.Length >= Left._First.Length) && (Right._Second.Length >= Left._Second.Length))
                return new Element("ж", "з");
            else if (!(Right._First.Length >= Left._First.Length) && (Right._Second.Length >= Left._Second.Length))
                return new Element(Left._First.Remove(Left._First.Length - Right._First.Length, Right._First.Length), "з");
            else if ((Right._First.Length >= Left._First.Length) && !(Right._Second.Length >= Left._Second.Length))
                return new Element("ж", Left._Second.Remove(Left._Second.Length - Right._Second.Length, Right._Second.Length));
            else
                return new Element(Left._First.Remove(Left._First.Length - Right._First.Length, Right._First.Length), 
                                   Left._Second.Remove(Left._Second.Length - Right._Second.Length, Right._Second.Length));
        }

        public static Element operator *(Element Repetition, int Quantity)
        {
            for (int i = 0; i < Quantity; i++)
            {
                Repetition._First += Repetition._First;
                Repetition._Second += Repetition._Second;
            }
            return new Element(Repetition._First,Repetition._Second);
        }

        public static bool operator ==(Element Left, Element Right)
        {
            return (Left._First == Right._First) && (Left._Second == Right._Second);
        }

        public static bool operator !=(Element Left, Element Right) 
        {  
            return !(Left == Right); 
        }

        public static bool operator <(Element Left, Element Right)
        {   
            if (Left._First.Length < Right._First.Length)
                return true;
            else if (Left._First.Length == Right._First.Length)
                if (Left._Second.Length < Right._Second.Length)
                    return true;
                else
                    return false;
            else
                return false;
        }

        public static bool operator >(Element Left, Element Right)
        {
            if (Left._First.Length > Right._First.Length)
                return true;
            else if (Left._First.Length == Right._First.Length)
                if (Left._Second.Length > Right._Second.Length)
                    return true;
                else
                    return false;
            else
                return false;
        }
    }
}
