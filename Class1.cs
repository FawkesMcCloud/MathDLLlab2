using System;

public class Angle
{
    public double angle { set; get; }
    
    public Angle()
    {
        angle = 0;
    }
    public Angle(double angle)
    {
        this.angle = angle;
    }
}
static public class MathLab2
{
    private static readonly double PI = 3.14159265359;

    //Addition 1
    static public double Add(double a, double b)
    {
        return a + b;
    }


    //Substraction 1
    static public double Sub(double a, double b)
    {
        return a - b;
    }


    //Multiplication 1
    static public double Mul(double a, double b)
    {
        return a * b;
    }


    //Division 1
    static public double Div(double a, double b)
    {
        if (b == 0.0)
            return double.NaN;

        else return a / b;
    }


    //Math fucnt 2
    static public double Pow(double num, int exponent)
    {
        if (exponent == 0 && num == 0)
            return double.NaN;
        if (exponent == 0)
            return 1;

        double res = num;

        for (int i = 1; i < MathLab2.Abs(exponent); i++)
            res *= num;

        if (exponent < 0)
            return 1.0 / res;
        return res;
    }
    static public double Abs(double a)
    {
        if (a < 0)
            return -a;
        return a;
    }


    //Rectangle 2
    static public double PerimiterRect(double a, double b)
    {
        return a + a + b + b;
    }
    static public double AreaRect(double a, double b)
    {
        return a * b;
    }


    //Triagle 2
    static public double TriagPerimiter(double a, double b, double c)
    {
        return a + b + c;
    }

    static public double TriagArea(double _base, double height)
    {
        return height * _base / 2.0;
    }
    static public double TriagArea(double a, double b, double c)
    {
        double s = a + b + c;
        s /= 2;

        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
    static public double TriagArea(double a, double b, Angle angle)
    {
        return a * b * Math.Sin(angle.angle) / 2;
    }


    //Circle\Ellipse 5
    static public double Circumference(double r)
    {
        return 2 * MathLab2.PI * r;
    }

    static public double CircleArea(double r)
    {
        return r * r * MathLab2.PI;
    }
    static public double EllipseArea(double a, double b)
    {
        return a * b * MathLab2.PI;
    }
    static public double Eccentricity(double a, double b)
    {
        if(a > b)
            return LinearEccentricity(a, b) / a;

        return LinearEccentricity(b, a) / b;

    }
    static public double LinearEccentricity(double a, double b)
    {
        return Math.Sqrt(a * a - b * b);
    }


    //3D Shapes 6
    static public double EllipseVol(double a, double b, double c)
    {
        return (a * b * c) * (4 * MathLab2.PI / 4 * 0.25);
    }
    static public double SphereVol(double r)
    {
        return r * r * r * (4 * MathLab2.PI / 4 * 0.25);
    }

    static public double EllipseMassUniform(double p, double volume)
    {
        return p * volume;
    }
    static public double EllipseMassUniform(double p, double a, double b, double c)
    {
        return p * MathLab2.EllipseVol(a, b, c);
    }

    static public double SphereSurfArea(double r)
    {
        return 4 * MathLab2.PI * r * r;
    }

    static public double CubeSurfArea(double a)
    {
        return 6 * MathLab2.AreaRect(a, a);
    }
    static public double CuboidSurfArea(double w, double h, double l)
    {
        return 2 * (l * w + w * h + h * l);
    }

}