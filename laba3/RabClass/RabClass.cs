using System;
namespace RabClass
{
    public class RabClass
    {
        public double Rab(double s, double S, double K, double R1, double R2, double R3)
        {
            // ������ ������� ������������
            double R0 = Math.Sqrt(s / Math.PI);

            // ���������� ������� �������� ������� �������
            double R = Math.Sqrt(S / Math.PI);

            // ���������� ����� ���
            double L = K * ((R0 / R) * (R0 / R));

            // ���������� ���������� ������������
            double[] Mass = new double[3] { R1, R2, R3 };
            Array.Sort(Mass);
            double D1 = Mass[0] * Mass[0];
            double D2 = Mass[1] * Mass[1];
            double D3 = Mass[2] * Mass[2];
            double C = (D1 * (5 / 2)) + (D2 * (3 / 2)) + (D3 * (1 / 2));

            // ���������� ���������� ������ �������
            double n = L / C;

            return n;
        }
    }
}
