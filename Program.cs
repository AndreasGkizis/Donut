  using System;namespace 
                   donut.net{class Program{static 
                 void Main(string[] args){double A=0
                ,B=0,i,j;var z=new double[7040];var b=
             new char[1760];while(true){memset(b,' ',1760);
            memset(z,0.0f, 7040);for(j=0;6.28>j;j+=0.07)for(
           i=0;6.28>i;i+=0.02){double c = Math.Sin(i);double d
          =Math.Cos(j);double e=Math.Sin(A);double f=Math.Sin(j);
         double g=Math.Cos(A);            double h=d+2;double D=1
         /(c*h*e+f*g+5);double            l=Math.Cos(i);double m=
         Math.Cos(B);double n             =Math.Sin(B);double t=
         c*h*g-f*e;int x=(int             )(40+30*D*(l*h*m-t*n));
         int y=(int)(12+15*D*             (l*h*n + t*m));int o=x
          +80*y;int N=(int)(8*           ((f*e-c*d*g)*m-c*d*e-f*
           g-l*d*n));if (22>y&&y>0&&x>0&&80>x&&D>z[o]){z[o]=D;b[o]
            =".,-~:;=!*#$@"[N>0?N:0];}}Thread.Sleep(38);Console.Clear();nl(b);Console.
             Write(b);A+=0.04;B+=0.02;}}static void memset<T>
                (T[] buf,T val,int bufsz){if (buf==null)buf=
                   new T[bufsz];for(int i=0;i<bufsz;i++)buf
                     [i] = val;}static void nl(char[]b){
                        for(int i=80;1760>i;i+=80){b
                               [i]='\n';}}}} 
