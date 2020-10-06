using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Rettangolo
{
    public class Rettangolo 
    {
        

        double x;
        double y;
        double base_;
        double altezza;
        public Rettangolo(double x, double y,double B,double H)
        {
            this.x = x;
            this.y = y;
            base_ = B;
            altezza = H;
        }
        public double CalcolaArea()
        {
            return  base_ * altezza; 
        }
        public double CalcolaPerimetro()
        {
            return (base_ + altezza) * 2;
        }
        public bool Contiene()
        {
            double[] rettangolo = new double[1];
            foreach (int j in rettangolo)
            {
                double[] rettangolo1 = new double[1];
                rettangolo1[0] = CalcolaArea();
                rettangolo1[1] = CalcolaPerimetro();

            }
            if(rettangolo[0] < rettangolo[1])
            {
                return true;
            }
            else
            {
                return false;
            }
            
          
        }
              
    }
    
    
}
