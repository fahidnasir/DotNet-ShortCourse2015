using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission02
{
    public class Complex
    {
        private int real;	//real part
        private int imaginary; //imaginary part

        public int Real
        {
            get { return real; }
            set
            {
                if (value >= -500 && value <= 500)
                {
                    real = value;
                }
            }
        }
        public int Imaginary
        {
            get { return imaginary; }
            set
            {
                if (value >= -100 && value <= 100)
                {
                    imaginary = value;
                }
            }
        }


        public Complex()
        {
            //TODO: initialize real with 1;
            this.Real = 5;
            this.Imaginary = 1;
        }
        public Complex(int real, int imaginary)
        {
            //TODO: initialize real and imaginary parts with given values.
            this.Real = real;
            this.Imaginary = imaginary;
        }
        public Complex Add(Complex Q)
        {
            //TODO: Add complex and imaginary parts and return resultant complex number.

            //Memory Efficient Approach

            //Q.SetReal(Q.GetReal() + this.r);
            //Q.SetImaginary(Q.GetImaginary() + this.im);
            //return Q;

            return Add(Q.Real, Q.Imaginary);
        }
        public Complex Add(int real, int imaginary)
        {
            //TODO: Add complex and binary parts and return resultant complex number.

            real = real + this.real;
            imaginary = imaginary + this.imaginary;
            Complex result = new Complex(real, imaginary);
            return result;
        }
        public Complex Subtract(Complex Q)
        {
            //TODO: Subtract Q from
            //Memory Efficient Approach

            //Q.SetReal(Q.GetReal() - this.r);
            //Q.SetImaginary(Q.GetImaginary() - this.im);
            //return Q;

            return Subtract(Q.Real, Q.Imaginary);
        }
        public Complex Subtract(int real, int imaginary)
        {
            //TODO: Subtraction operation on real and imaginary parts.
            real = real - this.real;
            imaginary = imaginary - this.imaginary;
            Complex result = new Complex(real, imaginary);
            return result;
        }
        //You can also implement multiply method.
        public String ToString()
        {
            //TODO: String representation in the form “a i + b”.
            return "Real Part: " + real + " Imaginary Part: " + imaginary;
        }
    }
}