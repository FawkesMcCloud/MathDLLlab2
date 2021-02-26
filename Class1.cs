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

    static public double add(double[] args)
    {
        double sum = 0;
        foreach(double val in args)
            sum += val;

        return sum;
    }
    static public float add(float[] args)
    {
        float sum = 0;
        foreach (float val in args)
            sum += val;

        return sum;
    }
    static public int add(int[] args)
    {
        int sum = 0;
        foreach (int val in args)
            sum += val;

        return sum;
    }


    static public double sub(double[] args)
    {
        double sum = 0;
        foreach (double val in args)
            sum -= val;

        return sum;
    }
    static public float sub(float[] args)
    {
        float sum = 0;
        foreach (float val in args)
            sum -= val;

        return sum;
    }
    static public int sub(int[] args)
    {
        int sum = 0;
        foreach (int val in args)
            sum -= val;

        return sum;
    }


    static public double mul(double[] args)
    {
        double prod = 0;
        foreach (double val in args)
            prod *= val;

        return prod;
    }
    static public float mul(float[] args)
    {
        float prod = 0;
        foreach (float val in args)
            prod *= val;

        return prod;
    }
    static public int mul(int[] args)
    {
        int prod = 0;
        foreach (int val in args)
            prod *= val;

        return prod;
    }


    static public double div(double[] args)
    {
        double prod = args[0];
        for(int i = 1; i < args.Length-1; i++)
        {
            if (args[i] == 0.0)
                return double.NaN;

            prod /= args[i];
        }

        return prod;
    }
    static public double div(float[] args)
    {
        double prod = args[0];
        for (int i = 1; i < args.Length - 1; i++)
        {
            if (args[i] == 0.0)
                return double.NaN;

            prod /= args[i];
        }

        return prod;
    }
    static public double div(int[] args)
    {
        double prod = args[0];
        for (int i = 1; i < args.Length - 1; i++)
        {
            if (args[i] == 0.0)
                return double.NaN;

            prod /= args[i];
        }

        return prod;
    }


    static public double pow(int num, int exponent)
    {
        if (exponent == 0)
            return 0;

        double res = num;

        for (int i = 1; i < exponent; i++)
            res *= num;

        if (exponent < 0)
            return 1.0 / res;
        return res;
    }
    
    static public double getPerimiterRect(double a, double b)
    {
        return a + a + b + b;
    }
    static public double getPerimiterTriag(double a, double b, double c)
    {
        return a + b + c;
    }
    static public double getCircumference(double r)
    {
        return 2 * PI * r;
    }
    static public double TriagArea(double b, double h)
    {
        return h * b / 2.0;
    }
    static public double TriagArea(double a, double b, double c)
    {
        double s = a + b + c;
        s /= 2;

        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }
    static public double AreaRect(double a, double b)
    {
        return a * b;
    }
    static public double TriagArea(double a, double b, Angle angle)
    {
        return a * b * Math.Sin(angle.angle) / 2;
    }
}