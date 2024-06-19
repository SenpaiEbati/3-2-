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

        public string First 
        { 
            get 
            { 
                return _First; 
            } 
            set 
            { 
                if ( !string.IsNullOrWhiteSpace(value) )
                    _First = value; 
            } 
        }
        public string Second 
        { 
            get 
            { 
                return _Second; 
            }
            set 
            { 
                if ( !string.IsNullOrWhiteSpace(value) )
                    _Second = value; 
            } 
        }

        public Element() : this("ж","з") { }

        public Element(string nFirst, string nSecond) 
        {
            _First = string.IsNullOrWhiteSpace(nFirst) ? "ж" : nFirst;
            _Second = string.IsNullOrWhiteSpace(nSecond) ? "з" : nSecond;
        }

        public override string ToString()
        {
            return "[" + _First + "]{" + _Second + "}";
        }

        public override bool Equals(object obj)
        {
            if (obj != null && GetType() == obj.GetType())
                return this == (obj as Element);
            else
                return false;
        }

        public override int GetHashCode()
        {
            return _First.GetHashCode() ^ _Second.GetHashCode();
        }

        public static Element operator -(Element Left, Element Right)
        {

            string a,b;
            if (Right._First.Length < Left._First.Length)
                a = Left._First.Remove(Left._First.Length - Right._First.Length, Right._First.Length);
            else
                a = "ж";

            if (Right._Second.Length < Left._Second.Length)
                b = Left._Second.Remove(Left._Second.Length - Right._Second.Length, Right._Second.Length);
            else
                b = "з";

            return new Element(a,b);
        }

        public static Element operator *(Element Repetition, int Quantity)
        {
            string a = "";
            string b = "";
            if (Quantity > 0)
            {
                for (int i = 0; i < Quantity; i++)
                {
                    a += Repetition._First;
                    b += Repetition._Second;
                }
                return new Element(a, b);
            }
            else
                return new Element("ж", "з");
            
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
            if ((Left._First.Length == Right._First.Length) && (Left._Second.Length < Right._Second.Length))
                return true;

            if (Left._First.Length < Right._First.Length)
                return true;

            return false;
        }

        public static bool operator >(Element Left, Element Right)
        {
            if ((Left._First.Length == Right._First.Length) && (Left._Second.Length > Right._Second.Length))
                return true;

            if (Left._First.Length > Right._First.Length)
                return true;

            return false;
        }
    }
}
